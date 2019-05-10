using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace ObjectFilter
{
    public class ButtonManager
    {
        public RibbonItem GetPanelItem(string itemName)
        {
            RibbonPanel panel = SingleData.Instance.RibbonPanel;
            if (panel == null)
                return null;

            IList<RibbonItem> panelItems = panel.GetItems();

            foreach (RibbonItem item in panelItems)
            {
                if (item.Name == itemName)
                    return item;
            }

            return null;
        }

        public bool DisableItem(string itemName)
        {
            RibbonItem item = GetPanelItem(itemName);
            if (item == null)
                return false;
            
            item.Enabled = false;
            return true;
        }

        public bool EnableItem(string itemName)
        {
            RibbonItem item = GetPanelItem(itemName);
            if (item == null)
                return false;

            item.Enabled = true;
            return true;
        }
    }

    public sealed class SingleData
    {
        SingleData()
        {
        }
        private static readonly object mutex = new object();

        private static SingleData instance = null;
        public static SingleData Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (mutex)
                    {
                        if (instance == null)
                            instance = new SingleData();
                    }
                }
                return instance;
            }
        }

        public Document Doc { get; set; }
        public bool WindowOpen { get; set; }
        public RibbonPanel RibbonPanel { get; set; }

    }
}
