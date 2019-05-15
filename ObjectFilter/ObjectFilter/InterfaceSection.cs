using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

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

        private AdvancedFilterControl.BinaryUI BinaryUI { get; set; } = null;

        private ParameterSet ParamSet { get; set; } = null;

        public Filter(System.Windows.Forms.ComboBox filterComboBox, System.Windows.Forms.Panel panel)
        {
            FilterCB = filterComboBox;
            ParamSet = new ParameterSet();

            if (BinaryUI == null)
                BinaryUI = new AdvancedFilterControl.BinaryUI(panel);
            BinaryUI.Halt();

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

        private Parameter GetSelectedParameter()
        {
            int x = 0;

            try
            {
                x = FilterCB.SelectedIndex;
            }
            catch (Exception ex)
            {
                TaskDialog.Show("Error: " + ex.GetType().ToString(), ex.Message);
                return null;
            }

            string parameterName = FilterCB.Items[x].ToString();

            Parameter parameter = null;

            foreach (Parameter p in ParamSet)
            {
                if (p.Definition.Name == parameterName)
                {
                    parameter = p;
                    break;
                }
            }

            return parameter;
        }

        public string GetParameterType()
        {
            // Get parameter from ParamSet
            Parameter parameter = GetSelectedParameter();

            if (parameter == null) return "";

            ParameterType pType = parameter.Definition.ParameterType;

            return pType.ToString();
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
