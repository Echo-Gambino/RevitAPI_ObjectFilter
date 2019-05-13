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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviewElementHost
            // 
            this.PreviewElementHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewElementHost.Location = new System.Drawing.Point(12, 12);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.CategoriesLabel);
            this.panel1.Controls.Add(this.CategoriesCheckedListBox);
            this.panel1.Location = new System.Drawing.Point(12, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 200);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.FilterComboBox);
            this.panel2.Controls.Add(this.FiltersLabel);
            this.panel2.Location = new System.Drawing.Point(240, 355);
            this.panel2.MinimumSize = new System.Drawing.Size(200, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 200);
            this.panel2.TabIndex = 8;
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(4, 31);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(210, 21);
            this.FilterComboBox.TabIndex = 5;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.ValueLabel);
            this.panel3.Location = new System.Drawing.Point(463, 355);
            this.panel3.MinimumSize = new System.Drawing.Size(200, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 200);
            this.panel3.TabIndex = 9;
            // 
            // ObjectFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PreviewElementHost);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "ObjectFilterForm";
            this.Text = "Object Filter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Integration.ElementHost PreviewElementHost;
        private System.Windows.Forms.Label CategoriesLabel;
        private System.Windows.Forms.Label FiltersLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.CheckedListBox CategoriesCheckedListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox FilterComboBox;
    }
}