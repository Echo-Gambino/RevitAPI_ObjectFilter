using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

// using Autodesk.Revit.UI;

namespace AdvancedFilterControl
{
    public class NumericalUI
    {
        private Panel SubPanel = null;

        private Label TextLabel = null;

        private struct Conditionals
        {
            public Panel SubSubPanel;
            public ComboBox ConditionalTypeCB;
            public TextBox ConditionalInputTB;

            public Conditionals( int i )
            {
                SubSubPanel = new Panel();
                ConditionalTypeCB = new ComboBox();
                ConditionalInputTB = new TextBox();
            }
        }

        public NumericalUI()
        {
            Panel k = new Panel();

            return;
        }

    }

    public class BinaryUI
    {
        private Panel SubPanel = null;

        private ComboBox BinaryComboBox = null;

        public BinaryUI(Panel panel)
        {
            if (SubPanel != null && BinaryComboBox != null)
                return;

            // Generate SubPanel
            SubPanel = GenerateSubPanel(panel);

            // Generate ComboBox
            BinaryComboBox = GenerateComboBox(SubPanel);

            // Generate EventHandlers
            BinaryComboBox.SelectedIndexChanged += new EventHandler(BinaryDropDown_SelectedIndexChanged);
        }

        public void Start()
        {
            SubPanel.Visible = true;

            BinaryComboBox.SelectedValue = "";

            return;
        }

        public void Halt()
        {
            SubPanel.Visible = false;

            return;
        }

        private ComboBox GenerateComboBox(Panel panel)
        {
            // Create an instance of subPanel
            System.Windows.Forms.ComboBox bCombo = new System.Windows.Forms.ComboBox();

            // Place the subPanel inside the panel
            panel.Controls.Add(bCombo);

            // Change the settings of the element thats not related to sizing and anchoring in relation to the panel
            bCombo.DropDownStyle = ComboBoxStyle.DropDownList;

            // Add True / False items to binary combo box
            System.Windows.Forms.ComboBox.ObjectCollection items = bCombo.Items;
            items.Add("True");
            items.Add("False");

            // Change the sizing of the element to fit the panel
            int guestSizeX = panel.Size.Width - bCombo.Margin.Horizontal - 2;
            int guestSizeY = panel.Size.Height - (panel.Size.Height / 4);
            bCombo.Size = new Size(guestSizeX, guestSizeY);

            // Change the location of the element to align with the panel
            int guestLocX = bCombo.Margin.Left;
            int guestLocY = bCombo.Margin.Top;
            bCombo.Location = new System.Drawing.Point(guestLocX, guestLocY);

            // Set the element's anchor correctly
            bCombo.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);

            return bCombo;
        }

        private Panel GenerateSubPanel(Panel panel)
        {
            // Create an instance of subPanel
            System.Windows.Forms.Panel subPanel = new System.Windows.Forms.Panel();

            // Place the subPanel inside the panel
            panel.Controls.Add(subPanel);

            // Change the settings thats not related to sizing and anchoring in relation to the panel
            subPanel.BorderStyle = BorderStyle.FixedSingle;

            // Change the sizing of subPanel to fit panel
            int guestSizeX = panel.Size.Width - subPanel.Margin.Horizontal;
            int guestSizeY = panel.Size.Height - (panel.Size.Height / 4);
            subPanel.Size = new Size(guestSizeX, guestSizeY);

            // Change the location of the subPanel to align with panel
            int guestLocX = subPanel.Margin.Left;
            int guestLocY = panel.Size.Height / 4;
            subPanel.Location = new System.Drawing.Point(guestLocX, guestLocY);

            // Set the element's anchor correctly
            subPanel.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);

            return subPanel;
        }

        private void BinaryDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = BinaryComboBox.Items[BinaryComboBox.SelectedIndex].ToString();

            MessageBox.Show("Debug", "Update element selection!" + "\n" + result);

            return;
        }


    }

    public class TextUI
    {

    }

    public class ImageUI
    {

    }

    public class InvalidUI
    {

    }

}
