using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI.Selection;
using System.Reflection;
using System.Windows.Media.Imaging;


/* Naming conventions I learned:
 * 
 * variables: catDogDonkey123
 * methods: DoThis(...)
 * 
 * 
 */

namespace ObjectFilter
{
    public class MainClass : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication app)
        {

            // Create a custom ribbin tab
            string tabName = "Object Filter";
            app.CreateRibbonTab(tabName);

            // Create a ribbon panel

            RibbonPanel ribbonPanel = app.CreateRibbonPanel(tabName, "Actions");
            SingleData.Instance.RibbonPanel = ribbonPanel;

            // Add the buttons to the panel
            List<RibbonItem> projectButtons = new List<RibbonItem>();

            // Create button
            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;
            PushButtonData buttonData = new PushButtonData("ObjectFilter", "Filter",
                thisAssemblyPath, "ObjectFilter.Filter");

            PushButton pushButton = ribbonPanel.AddItem(buttonData) as PushButton;

            // Add tooltip
            pushButton.ToolTip = "Begin filtering objects in the project";
            // Add bitmap
            // TODO: Need to get icon to work
            Uri uriImage = new Uri(@"C:\Users\Henry\Projects\RevitAPI_ObjectFilter\ObjectFilter\ObjectFilter\filter.png");
            BitmapImage image = new BitmapImage(uriImage);
            pushButton.LargeImage = image;

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication app)
        {
            return Result.Succeeded;
        }
    }

    [Transaction(TransactionMode.Manual)]
    public class Filter : IExternalCommand
    {

        [STAThread]
        // The main Execute method (inherited from IExternalCommand) must be public
        public Result Execute(ExternalCommandData revit,
            ref string message, ElementSet elements)
        {

            ButtonManager buttonManager = new ButtonManager();
            if (!buttonManager.DisableItem("ObjectFilter"))
            {
                TaskDialog.Show("Debug", "panel is null!?!");
                return Result.Failed;
            }

            try
            {
                System.Windows.Forms.Application.EnableVisualStyles();
                System.Windows.Forms.Application.Run(new Form1());
            }
            catch (Exception e)
            {
                TaskDialog.Show("Error", e.ToString());
                if (!buttonManager.DisableItem("ObjectFilter"))
                    TaskDialog.Show("Fatal", "Cannot Re-Enable Filter");
                return Result.Failed;
            }

            //TaskDialog.Show("Revit", "Hello World");
            return Result.Succeeded;
        }
    }
}

