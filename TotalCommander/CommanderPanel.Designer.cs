namespace TotalCommander
{
    partial class CommanderPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.comboBoxDriveSelect = new System.Windows.Forms.ComboBox();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.groupBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(11, 24);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(163, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // comboBoxDriveSelect
            // 
            this.comboBoxDriveSelect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxDriveSelect.FormattingEnabled = true;
            this.comboBoxDriveSelect.Location = new System.Drawing.Point(53, 55);
            this.comboBoxDriveSelect.Name = "comboBoxDriveSelect";
            this.comboBoxDriveSelect.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDriveSelect.TabIndex = 1;
            this.comboBoxDriveSelect.DropDown += new System.EventHandler(this.comboBoxDriveSelect_DropDown);
            this.comboBoxDriveSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxDriveSelect_SelectedIndexChanged);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(14, 102);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(185, 160);
            this.listBoxOutput.TabIndex = 2;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput.Controls.Add(this.textBoxPath);
            this.groupBoxInput.Controls.Add(this.comboBoxDriveSelect);
            this.groupBoxInput.Location = new System.Drawing.Point(14, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(185, 84);
            this.groupBoxInput.TabIndex = 3;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "groupBox1";
            // 
            // CommanderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.listBoxOutput);
            this.MaximumSize = new System.Drawing.Size(212, 284);
            this.Name = "CommanderPanel";
            this.Size = new System.Drawing.Size(212, 284);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ComboBox comboBoxDriveSelect;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.GroupBox groupBoxInput;
    }
}
