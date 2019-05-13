using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI.Selection;

namespace ObjectFilter
{
    public partial class ObjectFilterForm : System.Windows.Forms.Form
    {

        private Document Doc { get; set; } = null;

        private UIDocument UIDoc { get; set; } = null;

        private ElementId ViewId { get; set; } = null;

        private List<Element> Elements { get; set; } = null;

        private List<ElementId> SelElements { get; set; } = null;

        private InterfaceSection.Category CategoryInterface { get; set; } = null;

        private InterfaceSection.Filter FilterInterface { get; set; } = null;

        private InterfaceSection.NewVal NewValInterface { get; set; } = null;

        public ObjectFilterForm()
        {
            InitializeComponent();

            /*
            // Get items into the CheckedListBox
            List<Object> items = new List<Object>();

            StringBuilder sb = new StringBuilder();

            sb.Append("");
            foreach (Element e in Elements)
            {
                Category c = e.Category;

                String s = "null";
                if (c != null)
                    s = c.Name; 

                sb.Append("\n> " + s);
            }

            TaskDialog.Show("Debug", "ItemList:" + sb.ToString());
            */

        }

        /// <summary>
        /// 
        /// </summary>
        private void Initialize_Globals()
        {
            // Set global variables needed for this class
            Doc = SingleData.Instance.Doc;
            UIDoc = SingleData.Instance.UIDoc;
            ViewId = Doc.ActiveView.Id;

            FilteredElementCollector elementCollector = new FilteredElementCollector(Doc, ViewId);

            if (elementCollector != null)
                Elements = elementCollector.ToList<Element>();
            else
                Elements = new List<Element>();

            SelElements = new List<ElementId>();

            return;
        }

        /// <summary>
        /// 
        /// </summary>
        private void Initialize_PreviewElementHost()
        {
            // Get the preview object from the document and viewId
            PreviewControl preview = new PreviewControl(Doc, ViewId);
            // Set the ElementHost to host the preview within it
            PreviewElementHost.Child = preview;

            return;
        }

        /// <summary>
        /// Use Elements to fill in the categories checklist box
        /// </summary>
        private void Initialize_CategoriesCheckListBox()
        {
            // List<Object> items = new List<Object>();
            CheckedListBox.ObjectCollection items = CategoriesCheckedListBox.Items;

            Category c = null;

            // Create a list of unique categories of the given elements
            foreach (Element e in Elements)
            {
                // Get 'e's category
                c = e.Category;

                if (c == null)
                    // Skip if c is null
                    continue;
                else if (!items.Contains(c.Name))
                    // If c's name isn't already in items, then add it
                    items.Insert(0, c.Name);
            }

            CategoriesCheckedListBox.Refresh();

            return;
        }

        private void Initialize_FilterSection()
        {
            // Disable dropdown list
            FilterComboBox.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SingleData.Instance.WindowOpen = true;

            Initialize_Globals();

            Initialize_PreviewElementHost();

            Initialize_CategoriesCheckListBox();

            Initialize_FilterSection();

            CategoryInterface = new InterfaceSection.Category(CategoriesCheckedListBox);

            FilterInterface = new InterfaceSection.Filter(FilterComboBox);

            NewValInterface = new InterfaceSection.NewVal();

            return;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;

            // Reenable buttons for Revit
            SingleData.Instance.WindowOpen = false;
            ButtonManager buttonManager = new ButtonManager();
            buttonManager.EnableItem("ObjectFilter");
        }

        private void CategoriesCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update Category Interface
            int catResult = CategoryInterface.Update(UIDoc, Elements);
            switch (catResult)
            {
                case 0:
                    FilterInterface.Disable();
                    return;
                case -1:
                    TaskDialog.Show("Error", "Error, Category interface failed");
                    return;
                default:
                    FilterInterface.Enable();
                    break;
            }

            List<ElementId> selElements = CategoryInterface.SelElements;
            FilterInterface.UpdateList(selElements, UIDoc);


            return;
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterInterface.SetupFilterByParameter();
            return;
        }
    }
}

namespace InterfaceSection
{
    public class Category
    {
        private CheckedListBox CategoriesCL { get; set; } = null;

        public List<ElementId> SelElements { get; set; } = null;

        public Category(CheckedListBox categoriesCL)
        {
            CategoriesCL = categoriesCL;

            return;
        }

        private List<ElementId> GetElementIdsFromCategories(List<string> categories, List<Element> allElements)
        {
            List<ElementId> output = new List<ElementId>();

            Autodesk.Revit.DB.Category eC = null;

            foreach (string c in categories)
            {
                foreach (Element e in allElements)
                {
                    eC = e.Category;

                    if (eC == null)
                        continue;
                    else if (c == eC.Name)
                        output.Add(e.Id);
                }
            }

            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uidoc"></param>
        /// <param name="allElements"></param>
        /// <returns></returns>
        public int Update(UIDocument uidoc, List<Element> allElements)
        {
            // Get checked categories
            List<string> chkCategories = CategoriesCL.CheckedItems.OfType<string>().ToList();

            // If checked categories doesn't have anythng, then return premeturely
            if (chkCategories == null) return -1;

            // Get the Collection of ElementIds and clear it
            ICollection<ElementId> elIdCollection = uidoc.Selection.GetElementIds();
            elIdCollection.Clear();

            if (chkCategories.Count == 0)
            {
                // Set nothing to be highlighted
                uidoc.Selection.SetElementIds(elIdCollection);
                return 0;
            }

            // Get all ElementIds that belongs to the given categories
            SelElements = GetElementIdsFromCategories(chkCategories, allElements);

            // Add all selected elements to the element ids
            foreach (ElementId eId in SelElements)
                elIdCollection.Add(eId);

            // Set the given Elements to be highlighted
            uidoc.Selection.SetElementIds(elIdCollection);
            uidoc.ShowElements(elIdCollection);

            return chkCategories.Count;
        }

    }

    public class Filter
    {
        private System.Windows.Forms.ComboBox FilterCB { get; set; } = null;

        private ParameterSet ParamSet { get; set; } = null;

        public Filter(System.Windows.Forms.ComboBox filterComboBox)
        {
            FilterCB = filterComboBox;
            ParamSet = new ParameterSet();
            return;
        }

        private ParameterSet GetCommonParameters(List<ElementId> selElements, Document doc)
        {
            ParameterSet paramSet = new ParameterSet();

            Element e = null;

            bool first_time = true;

            foreach (ElementId eId in selElements)
            {
                e = doc.GetElement(eId);
                if (paramSet.IsEmpty && first_time)
                {
                    // If paramSet.IsEmpty and it is the first time it has entered the loop
                    paramSet = e.Parameters;
                    first_time = false;
                }
                else
                {
                    // If paramSet isn't empty or its no the first time it entered the loop
                    IEnumerable<Parameter> LinqQuery
                        = from Parameter p in e.Parameters
                          where paramSet.Contains(p)
                          select p;

                    paramSet = new ParameterSet();

                    foreach (Parameter p in LinqQuery)
                        paramSet.Insert(p);
                }
            }

            return paramSet;
        }

        public void Disable()
        {
            FilterCB.Enabled = false;

            System.Windows.Forms.ComboBox.ObjectCollection filterCollection = FilterCB.Items;
            filterCollection.Clear();

            return;
        }

        public void Enable()
        {
            FilterCB.Enabled = true;
            return;
        }

        public void UpdateList(List<ElementId> selElements, UIDocument uidoc)
        {
            Document doc = uidoc.Document;

            ParamSet = GetCommonParameters(selElements, doc);

            System.Windows.Forms.ComboBox.ObjectCollection filterCollection = FilterCB.Items;
            filterCollection.Clear();

            foreach (Parameter p in ParamSet)
            {
                filterCollection.Add(p.Definition.Name);
            }

            return;
        }

        public void SetupFilterByParameter()
        {
            string x = FilterCB.SelectedValue.ToString();

            TaskDialog.Show("Debug", x);

            return;
        }

    }

    public class NewVal
    {
        public NewVal()
        {
            return;
        }
    }
}
