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
        public ObjectFilterForm()
        {
            InitializeComponent();

            Document doc = SingleData.Instance.Doc;
            ElementId viewId = doc.ActiveView.Id;
            PreviewControl preview = new PreviewControl(doc, viewId);
            PreviewElementHost.Child = preview;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SingleData.Instance.WindowOpen = true;

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

    }
}
