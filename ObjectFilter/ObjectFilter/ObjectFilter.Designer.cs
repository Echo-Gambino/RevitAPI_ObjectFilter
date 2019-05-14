namespace ObjectFilter
{
    partial class ObjectFilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PreviewElementHost = new System.Windows.Forms.Integration.ElementHost();
            this.CategoriesLabel = new System.Windows.Forms.Label();
            this.FiltersLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.CategoriesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.CategoriesPanel = new System.Windows.Forms.Panel();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.ImageFilterPanel = new System.Windows.Forms.Panel();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ImagePathTextBox = new System.Windows.Forms.TextBox();
            this.SearchByImageLabel = new System.Windows.Forms.Label();
            this.TextFilterPanel = new System.Windows.Forms.Panel();
            this.ExcludeLabel = new System.Windows.Forms.Label();
            this.IncludeLabel = new System.Windows.Forms.Label();
            this.ExcludeTextBox = new System.Windows.Forms.TextBox();
            this.IncludeTextBox = new System.Windows.Forms.TextBox();
            this.MainWordTextBox = new System.Windows.Forms.TextBox();
            this.MainWordLabel = new System.Windows.Forms.Label();
            this.BinaryFilterPanel = new System.Windows.Forms.Panel();
            this.BinaryComboBox = new System.Windows.Forms.ComboBox();
            this.NumericFilterPanel = new System.Windows.Forms.Panel();
            this.GreaterThanTextBox = new System.Windows.Forms.TextBox();
            this.LesserThanTextBox = new System.Windows.Forms.TextBox();
            this.ExactNumTextBox = new System.Windows.Forms.TextBox();
            this.GreaterThanComboBox = new System.Windows.Forms.ComboBox();
            this.LesserThanComboBox = new System.Windows.Forms.ComboBox();
            this.NumericFilterLabel = new System.Windows.Forms.Label();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.ValuePanel = new System.Windows.Forms.Panel();
            this.CategoriesPanel.SuspendLayout();
            this.FilterPanel.SuspendLayout();
            this.ImageFilterPanel.SuspendLayout();
            this.TextFilterPanel.SuspendLayout();
            this.BinaryFilterPanel.SuspendLayout();
            this.NumericFilterPanel.SuspendLayout();
            this.ValuePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewElementHost
            // 
            this.PreviewElementHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewElementHost.Location = new System.Drawing.Point(12, 12);
            this.PreviewElementHost.MinimumSize = new System.Drawing.Size(660, 337);
            this.PreviewElementHost.Name = "PreviewElementHost";
            this.PreviewElementHost.Size = new System.Drawing.Size(660, 337);
            this.PreviewElementHost.TabIndex = 2;
            this.PreviewElementHost.Text = "Preview";
            this.PreviewElementHost.Child = null;
            // 
            // CategoriesLabel
            // 
            this.CategoriesLabel.AutoSize = true;
            this.CategoriesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesLabel.Location = new System.Drawing.Point(0, 0);
            this.CategoriesLabel.Name = "CategoriesLabel";
            this.CategoriesLabel.Size = new System.Drawing.Size(86, 20);
            this.CategoriesLabel.TabIndex = 3;
            this.CategoriesLabel.Text = "Categories";
            // 
            // FiltersLabel
            // 
            this.FiltersLabel.AutoSize = true;
            this.FiltersLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FiltersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltersLabel.Location = new System.Drawing.Point(0, 0);
            this.FiltersLabel.Name = "FiltersLabel";
            this.FiltersLabel.Size = new System.Drawing.Size(52, 20);
            this.FiltersLabel.TabIndex = 4;
            this.FiltersLabel.Text = "Filters";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.Location = new System.Drawing.Point(0, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(85, 20);
            this.ValueLabel.TabIndex = 5;
            this.ValueLabel.Text = "New Value";
            // 
            // CategoriesCheckedListBox
            // 
            this.CategoriesCheckedListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CategoriesCheckedListBox.FormattingEnabled = true;
            this.CategoriesCheckedListBox.Location = new System.Drawing.Point(0, 31);
            this.CategoriesCheckedListBox.Name = "CategoriesCheckedListBox";
            this.CategoriesCheckedListBox.Size = new System.Drawing.Size(222, 169);
            this.CategoriesCheckedListBox.TabIndex = 6;
            this.CategoriesCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.CategoriesCheckedListBox_SelectedIndexChanged);
            // 
            // CategoriesPanel
            // 
            this.CategoriesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoriesPanel.Controls.Add(this.CategoriesLabel);
            this.CategoriesPanel.Controls.Add(this.CategoriesCheckedListBox);
            this.CategoriesPanel.Location = new System.Drawing.Point(12, 355);
            this.CategoriesPanel.MaximumSize = new System.Drawing.Size(1000000000, 500);
            this.CategoriesPanel.MinimumSize = new System.Drawing.Size(222, 200);
            this.CategoriesPanel.Name = "CategoriesPanel";
            this.CategoriesPanel.Size = new System.Drawing.Size(222, 200);
            this.CategoriesPanel.TabIndex = 7;
            // 
            // FilterPanel
            // 
            this.FilterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterPanel.Controls.Add(this.ImageFilterPanel);
            this.FilterPanel.Controls.Add(this.TextFilterPanel);
            this.FilterPanel.Controls.Add(this.BinaryFilterPanel);
            this.FilterPanel.Controls.Add(this.NumericFilterPanel);
            this.FilterPanel.Controls.Add(this.FilterComboBox);
            this.FilterPanel.Controls.Add(this.FiltersLabel);
            this.FilterPanel.Location = new System.Drawing.Point(240, 181);
            this.FilterPanel.MaximumSize = new System.Drawing.Size(1000000000, 500);
            this.FilterPanel.MinimumSize = new System.Drawing.Size(200, 200);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(217, 374);
            this.FilterPanel.TabIndex = 8;
            this.FilterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FilterPanel_Paint);
            // 
            // ImageFilterPanel
            // 
            this.ImageFilterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageFilterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageFilterPanel.Controls.Add(this.BrowseButton);
            this.ImageFilterPanel.Controls.Add(this.ImagePathTextBox);
            this.ImageFilterPanel.Controls.Add(this.SearchByImageLabel);
            this.ImageFilterPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ImageFilterPanel.Location = new System.Drawing.Point(3, 259);
            this.ImageFilterPanel.Name = "ImageFilterPanel";
            this.ImageFilterPanel.Size = new System.Drawing.Size(210, 49);
            this.ImageFilterPanel.TabIndex = 9;
            this.ImageFilterPanel.Visible = false;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Location = new System.Drawing.Point(154, 19);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(51, 23);
            this.BrowseButton.TabIndex = 8;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            // 
            // ImagePathTextBox
            // 
            this.ImagePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePathTextBox.Location = new System.Drawing.Point(4, 19);
            this.ImagePathTextBox.MinimumSize = new System.Drawing.Size(4, 23);
            this.ImagePathTextBox.Name = "ImagePathTextBox";
            this.ImagePathTextBox.ReadOnly = true;
            this.ImagePathTextBox.Size = new System.Drawing.Size(146, 20);
            this.ImagePathTextBox.TabIndex = 7;
            // 
            // SearchByImageLabel
            // 
            this.SearchByImageLabel.AutoSize = true;
            this.SearchByImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByImageLabel.Location = new System.Drawing.Point(3, 0);
            this.SearchByImageLabel.MinimumSize = new System.Drawing.Size(50, 0);
            this.SearchByImageLabel.Name = "SearchByImageLabel";
            this.SearchByImageLabel.Size = new System.Drawing.Size(111, 16);
            this.SearchByImageLabel.TabIndex = 0;
            this.SearchByImageLabel.Text = "Search By Image";
            this.SearchByImageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextFilterPanel
            // 
            this.TextFilterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextFilterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextFilterPanel.Controls.Add(this.ExcludeLabel);
            this.TextFilterPanel.Controls.Add(this.IncludeLabel);
            this.TextFilterPanel.Controls.Add(this.ExcludeTextBox);
            this.TextFilterPanel.Controls.Add(this.IncludeTextBox);
            this.TextFilterPanel.Controls.Add(this.MainWordTextBox);
            this.TextFilterPanel.Controls.Add(this.MainWordLabel);
            this.TextFilterPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextFilterPanel.Location = new System.Drawing.Point(4, 173);
            this.TextFilterPanel.Name = "TextFilterPanel";
            this.TextFilterPanel.Size = new System.Drawing.Size(210, 80);
            this.TextFilterPanel.TabIndex = 8;
            this.TextFilterPanel.Visible = false;
            // 
            // ExcludeLabel
            // 
            this.ExcludeLabel.AutoSize = true;
            this.ExcludeLabel.Location = new System.Drawing.Point(3, 57);
            this.ExcludeLabel.MinimumSize = new System.Drawing.Size(50, 0);
            this.ExcludeLabel.Name = "ExcludeLabel";
            this.ExcludeLabel.Size = new System.Drawing.Size(50, 13);
            this.ExcludeLabel.TabIndex = 10;
            this.ExcludeLabel.Text = "Exclude:";
            this.ExcludeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // IncludeLabel
            // 
            this.IncludeLabel.AutoSize = true;
            this.IncludeLabel.Location = new System.Drawing.Point(3, 30);
            this.IncludeLabel.MinimumSize = new System.Drawing.Size(50, 0);
            this.IncludeLabel.Name = "IncludeLabel";
            this.IncludeLabel.Size = new System.Drawing.Size(50, 13);
            this.IncludeLabel.TabIndex = 9;
            this.IncludeLabel.Text = "Include:";
            this.IncludeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ExcludeTextBox
            // 
            this.ExcludeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExcludeTextBox.Location = new System.Drawing.Point(59, 54);
            this.ExcludeTextBox.MinimumSize = new System.Drawing.Size(4, 21);
            this.ExcludeTextBox.Name = "ExcludeTextBox";
            this.ExcludeTextBox.Size = new System.Drawing.Size(146, 20);
            this.ExcludeTextBox.TabIndex = 8;
            // 
            // IncludeTextBox
            // 
            this.IncludeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncludeTextBox.Location = new System.Drawing.Point(59, 27);
            this.IncludeTextBox.MinimumSize = new System.Drawing.Size(4, 21);
            this.IncludeTextBox.Name = "IncludeTextBox";
            this.IncludeTextBox.Size = new System.Drawing.Size(146, 20);
            this.IncludeTextBox.TabIndex = 7;
            // 
            // MainWordTextBox
            // 
            this.MainWordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainWordTextBox.Location = new System.Drawing.Point(59, 1);
            this.MainWordTextBox.Name = "MainWordTextBox";
            this.MainWordTextBox.Size = new System.Drawing.Size(146, 20);
            this.MainWordTextBox.TabIndex = 6;
            // 
            // MainWordLabel
            // 
            this.MainWordLabel.AutoSize = true;
            this.MainWordLabel.Location = new System.Drawing.Point(3, 4);
            this.MainWordLabel.MinimumSize = new System.Drawing.Size(50, 0);
            this.MainWordLabel.Name = "MainWordLabel";
            this.MainWordLabel.Size = new System.Drawing.Size(50, 13);
            this.MainWordLabel.TabIndex = 0;
            this.MainWordLabel.Text = "Search:";
            this.MainWordLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BinaryFilterPanel
            // 
            this.BinaryFilterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BinaryFilterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BinaryFilterPanel.Controls.Add(this.BinaryComboBox);
            this.BinaryFilterPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BinaryFilterPanel.Location = new System.Drawing.Point(4, 137);
            this.BinaryFilterPanel.Name = "BinaryFilterPanel";
            this.BinaryFilterPanel.Size = new System.Drawing.Size(210, 30);
            this.BinaryFilterPanel.TabIndex = 7;
            this.BinaryFilterPanel.Visible = false;
            // 
            // BinaryComboBox
            // 
            this.BinaryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BinaryComboBox.FormattingEnabled = true;
            this.BinaryComboBox.Location = new System.Drawing.Point(3, 3);
            this.BinaryComboBox.Name = "BinaryComboBox";
            this.BinaryComboBox.Size = new System.Drawing.Size(202, 21);
            this.BinaryComboBox.TabIndex = 0;
            // 
            // NumericFilterPanel
            // 
            this.NumericFilterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericFilterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericFilterPanel.Controls.Add(this.GreaterThanTextBox);
            this.NumericFilterPanel.Controls.Add(this.LesserThanTextBox);
            this.NumericFilterPanel.Controls.Add(this.ExactNumTextBox);
            this.NumericFilterPanel.Controls.Add(this.GreaterThanComboBox);
            this.NumericFilterPanel.Controls.Add(this.LesserThanComboBox);
            this.NumericFilterPanel.Controls.Add(this.NumericFilterLabel);
            this.NumericFilterPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumericFilterPanel.Location = new System.Drawing.Point(4, 50);
            this.NumericFilterPanel.Name = "NumericFilterPanel";
            this.NumericFilterPanel.Size = new System.Drawing.Size(210, 81);
            this.NumericFilterPanel.TabIndex = 6;
            this.NumericFilterPanel.Visible = false;
            // 
            // GreaterThanTextBox
            // 
            this.GreaterThanTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GreaterThanTextBox.Location = new System.Drawing.Point(49, 54);
            this.GreaterThanTextBox.MinimumSize = new System.Drawing.Size(4, 21);
            this.GreaterThanTextBox.Name = "GreaterThanTextBox";
            this.GreaterThanTextBox.Size = new System.Drawing.Size(156, 20);
            this.GreaterThanTextBox.TabIndex = 8;
            // 
            // LesserThanTextBox
            // 
            this.LesserThanTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LesserThanTextBox.Location = new System.Drawing.Point(49, 27);
            this.LesserThanTextBox.MinimumSize = new System.Drawing.Size(4, 21);
            this.LesserThanTextBox.Name = "LesserThanTextBox";
            this.LesserThanTextBox.Size = new System.Drawing.Size(156, 20);
            this.LesserThanTextBox.TabIndex = 7;
            // 
            // ExactNumTextBox
            // 
            this.ExactNumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExactNumTextBox.Location = new System.Drawing.Point(86, 1);
            this.ExactNumTextBox.Name = "ExactNumTextBox";
            this.ExactNumTextBox.Size = new System.Drawing.Size(119, 20);
            this.ExactNumTextBox.TabIndex = 6;
            // 
            // GreaterThanComboBox
            // 
            this.GreaterThanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GreaterThanComboBox.FormattingEnabled = true;
            this.GreaterThanComboBox.Items.AddRange(new object[] {
            ">",
            "=>"});
            this.GreaterThanComboBox.Location = new System.Drawing.Point(3, 54);
            this.GreaterThanComboBox.MaxDropDownItems = 2;
            this.GreaterThanComboBox.Name = "GreaterThanComboBox";
            this.GreaterThanComboBox.Size = new System.Drawing.Size(40, 21);
            this.GreaterThanComboBox.TabIndex = 3;
            // 
            // LesserThanComboBox
            // 
            this.LesserThanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LesserThanComboBox.FormattingEnabled = true;
            this.LesserThanComboBox.Items.AddRange(new object[] {
            "<",
            "=<"});
            this.LesserThanComboBox.Location = new System.Drawing.Point(3, 27);
            this.LesserThanComboBox.MaxDropDownItems = 2;
            this.LesserThanComboBox.Name = "LesserThanComboBox";
            this.LesserThanComboBox.Size = new System.Drawing.Size(40, 21);
            this.LesserThanComboBox.TabIndex = 2;
            // 
            // NumericFilterLabel
            // 
            this.NumericFilterLabel.AutoSize = true;
            this.NumericFilterLabel.Location = new System.Drawing.Point(3, 4);
            this.NumericFilterLabel.Name = "NumericFilterLabel";
            this.NumericFilterLabel.Size = new System.Drawing.Size(77, 13);
            this.NumericFilterLabel.TabIndex = 0;
            this.NumericFilterLabel.Text = "Exact Number:";
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(4, 23);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(210, 21);
            this.FilterComboBox.TabIndex = 5;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // ValuePanel
            // 
            this.ValuePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ValuePanel.Controls.Add(this.ValueLabel);
            this.ValuePanel.Location = new System.Drawing.Point(463, 355);
            this.ValuePanel.MaximumSize = new System.Drawing.Size(1000000000, 500);
            this.ValuePanel.MinimumSize = new System.Drawing.Size(200, 200);
            this.ValuePanel.Name = "ValuePanel";
            this.ValuePanel.Size = new System.Drawing.Size(209, 200);
            this.ValuePanel.TabIndex = 9;
            // 
            // ObjectFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.ValuePanel);
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.CategoriesPanel);
            this.Controls.Add(this.PreviewElementHost);
            this.MaximumSize = new System.Drawing.Size(1000000016, 1000);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "ObjectFilterForm";
            this.Text = "Object Filter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CategoriesPanel.ResumeLayout(false);
            this.CategoriesPanel.PerformLayout();
            this.FilterPanel.ResumeLayout(false);
            this.FilterPanel.PerformLayout();
            this.ImageFilterPanel.ResumeLayout(false);
            this.ImageFilterPanel.PerformLayout();
            this.TextFilterPanel.ResumeLayout(false);
            this.TextFilterPanel.PerformLayout();
            this.BinaryFilterPanel.ResumeLayout(false);
            this.NumericFilterPanel.ResumeLayout(false);
            this.NumericFilterPanel.PerformLayout();
            this.ValuePanel.ResumeLayout(false);
            this.ValuePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Integration.ElementHost PreviewElementHost;
        private System.Windows.Forms.Label CategoriesLabel;
        private System.Windows.Forms.Label FiltersLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.CheckedListBox CategoriesCheckedListBox;
        private System.Windows.Forms.Panel CategoriesPanel;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.Panel ValuePanel;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Panel NumericFilterPanel;
        private System.Windows.Forms.Label NumericFilterLabel;
        private System.Windows.Forms.ComboBox LesserThanComboBox;
        private System.Windows.Forms.ComboBox GreaterThanComboBox;
        private System.Windows.Forms.TextBox GreaterThanTextBox;
        private System.Windows.Forms.TextBox LesserThanTextBox;
        private System.Windows.Forms.TextBox ExactNumTextBox;
        private System.Windows.Forms.Panel TextFilterPanel;
        private System.Windows.Forms.Label ExcludeLabel;
        private System.Windows.Forms.Label IncludeLabel;
        private System.Windows.Forms.TextBox ExcludeTextBox;
        private System.Windows.Forms.TextBox IncludeTextBox;
        private System.Windows.Forms.TextBox MainWordTextBox;
        private System.Windows.Forms.Label MainWordLabel;
        private System.Windows.Forms.Panel BinaryFilterPanel;
        private System.Windows.Forms.ComboBox BinaryComboBox;
        private System.Windows.Forms.Panel ImageFilterPanel;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox ImagePathTextBox;
        private System.Windows.Forms.Label SearchByImageLabel;
    }
}