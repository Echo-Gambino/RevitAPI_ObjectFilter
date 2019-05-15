using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace FilterSection
{
    public abstract class TemplateSection
    {
        public Panel Self { get; set; } = null;

        public TemplateSection(Panel panel)
        {
            Self = panel;
        }

        public void Show()
        {
            Self.Visible = true;
        }

        public void Hide()
        {
            Self.Visible = false;
        }

        public abstract void Setup();

        public abstract bool IsFieldsReady();

    }

    public class MainSection : TemplateSection
    {
        public TemplateSection SubSection { get; set; } = null;

        private ComboBox Categories { get; set; } = null;

        private Button SearchButton { get; set; } = null;
        private Button ResetButton { get; set; } = null;

        public MainSection(Panel panel, ComboBox categories, Button searchButton, Button resetButton) : base(panel)
        {
            Categories = categories;
            SearchButton = searchButton;
            ResetButton = resetButton;
        }

        public override void Setup()
        {
            SearchButton.Enabled = false;
            ResetButton.Enabled = false;

            if (SubSection != null)
                SubSection.Setup();

            return;
        }

        public override bool IsFieldsReady()
        {
            if (SubSection != null)
                return SubSection.IsFieldsReady();

            return false;
        }

        public void Enable()
        {
            Categories.Enabled = true;

            Update();

            return;
        }

        public void Disable()
        {
            Categories.Enabled = false;

            WhenSubSectionNull();

            if (SubSection == null)
                return;

            SubSection.Setup();
            SubSection.Hide();

            return;
        }


        public void Update()
        {
            if (SubSection == null)
            {
                WhenSubSectionNull();
                return;
            }

            SubSection.Show();

            if (IsFieldsReady())
                WhenFieldsIsReady();
            else
                WhenFieldsNotReady();
        }

        public void WhenSubSectionNull()
        {
            SearchButton.Enabled = false;
            ResetButton.Enabled = false;
        }

        public void WhenFieldsNotReady()
        {
            SearchButton.Enabled = false;
            ResetButton.Enabled = true;
        }

        public void WhenFieldsIsReady()
        {
            SearchButton.Enabled = true;
            ResetButton.Enabled = true;
        }

    }

    public class BinarySection : TemplateSection
    {
        private ComboBox YesNoBox { get; set; } = null;

        public BinarySection(Panel panel, ComboBox comboBox) : base(panel)
        {
            YesNoBox = comboBox;
        }

        public override void Setup()
        {
            YesNoBox.SelectedText = "";

            return;
        }

        public override bool IsFieldsReady()
        {
            int result = GetInformation();

            if (result == -1) return false;

            return true;
        }

        public int GetInformation()
        {
            int index = YesNoBox.SelectedIndex;

            if (index == -1) return -1;

            string result = YesNoBox.Items[index].ToString();

            if (result == "True")
                return 1;
            else if (result == "False")
                return 0;

            return -1;
        }

    }

    public class NumericSection : TemplateSection
    {
        private Label MainLabel = null;

        private TextBox MainTB = null;
        private TextBox LesserThanTB = null;
        private TextBox GreaterThanTB = null;

        private ComboBox LesserThanCB = null;
        private ComboBox GreaterThanCB = null;

        public NumericSection(
            Panel panel,
            List<Label> LBs,
            List<TextBox> TBs,
            List<ComboBox> CBs
            ) : base(panel)
        {
            MainLabel = LBs[0];

            MainTB = TBs[0];
            LesserThanTB = TBs[1];
            GreaterThanTB = TBs[2];

            LesserThanCB = CBs[0];
            GreaterThanCB = CBs[1];

            return;
        }

        public override void Setup()
        {
            MainTB.Text = "";
            LesserThanTB.Text = "";
            GreaterThanTB.Text = "";

            LesserThanCB.SelectedText = "";
            GreaterThanTB.SelectedText = "";

            return;
        }

        public override bool IsFieldsReady()
        {
            List<int> result = GetInformation();

            return ((result[0] != -1) || (result[1] != -1) || (result[2] != -1));
        }

        public List<int> GetInformation()
        {
            int EXStatus = -1;
            int EXNumber = 0;

            int LTStatus = -1;
            int LTNumber = 0;

            int GTStatus = -1;
            int GTNumber = 0;

            if (Int32.TryParse(MainTB.Text, out EXNumber))
                EXStatus = 0;

            if (Int32.TryParse(LesserThanTB.Text, out LTNumber))
            {
                string LTResult = LesserThanCB.Items[LesserThanCB.SelectedIndex].ToString();
                if ((LTResult == "<") || (LTResult == "=<"))
                {
                    if (LTResult == "=<")
                        LTStatus = 1;
                    else
                        LTStatus = 0;
                }
            }

            if (Int32.TryParse(GreaterThanTB.Text, out GTNumber))
            {
                string GTResult = GreaterThanCB.Items[GreaterThanCB.SelectedIndex].ToString();
                if ((GTResult == ">") || (GTResult == "=>"))
                {
                    if (GTResult == "=>")
                        GTStatus = 1;
                    else
                        GTStatus = 0;
                }
            }

            List<int> output = new List<int>()
            {
                EXStatus, EXNumber,
                LTStatus, LTNumber,
                GTStatus, GTNumber
            };            
            

            return output;
        }


    }

    public class TextSection : TemplateSection
    {
        private TextBox MainTB = null;
        private TextBox InclTB = null;
        private TextBox ExclTB = null;

        public TextSection(
            Panel panel,
            List<TextBox> TBs
            ) : base(panel)
        {
            MainTB = TBs[0];
            InclTB = TBs[1];
            ExclTB = TBs[2];

            return;
        }

        public override void Setup()
        {
            MainTB.Text = "";
            InclTB.Text = "";
            ExclTB.Text = "";

            return;
        }

        public override bool IsFieldsReady() {

            List<string> output = GetInformation();

            foreach (string s in output)
            {
                if (s != "")
                    return true;
            }

            return false;
        }

        public List<string> GetInformation()
        {
            List<string> output = new List<string>()
            {
                MainTB.Text,
                InclTB.Text,
                ExclTB.Text
            };

            return output;
        }

    }

    // TODO: Need to implement
    public class ImageSection : TemplateSection
    {
        private TextBox ImagePathTB = null;
        private Button ImagePathBN = null;

        public ImageSection(
            Panel panel,
            TextBox pathPreviewer,
            Button browseButton
            ) : base(panel)
        {
            ImagePathTB = pathPreviewer;
            ImagePathBN = browseButton;
        }

        public override void Setup()
        {
            ImagePathTB.Text = "";

            return;
        }

        public override bool IsFieldsReady()
        {
            // TODO need to implement GetInformation!
            GetInformation();

            return false;
        }

        public void GetInformation()
        {
            return;
        }

    }

    // TODO: Need to implement
    public class InvalidSection : TemplateSection
    {
        private Label MainLabel = null;

        public InvalidSection(
            Panel panel,
            Label mainLabel
            ) : base(panel)
        {
            MainLabel = mainLabel;
        }

        public override void Setup()
        {
            // TODO: Need to implement this
            MainLabel.Text = "Invalid: Not Available For Now";
        }

        public override bool IsFieldsReady()
        {
            // TODO: Need to implement
            GetInformation();

            return false;
        }

        public void GetInformation()
        {
            return;
        }

    }
}


