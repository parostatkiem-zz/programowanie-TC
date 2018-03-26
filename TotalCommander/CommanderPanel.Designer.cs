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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.textBoxPath.Size = new System.Drawing.Size(347, 20);
            this.textBoxPath.TabIndex = 0;
            this.textBoxPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPath_KeyPress);
            // 
            // comboBoxDriveSelect
            // 
            this.comboBoxDriveSelect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxDriveSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDriveSelect.FormattingEnabled = true;
            this.comboBoxDriveSelect.Location = new System.Drawing.Point(277, 54);
            this.comboBoxDriveSelect.Name = "comboBoxDriveSelect";
            this.comboBoxDriveSelect.Size = new System.Drawing.Size(81, 21);
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
            this.listBoxOutput.Location = new System.Drawing.Point(14, 111);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(369, 329);
            this.listBoxOutput.TabIndex = 2;
            this.listBoxOutput.DoubleClick += new System.EventHandler(this.listBoxOutput_DoubleClick);
            this.listBoxOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBoxOutput_KeyPress);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput.Controls.Add(this.button4);
            this.groupBoxInput.Controls.Add(this.button3);
            this.groupBoxInput.Controls.Add(this.button2);
            this.groupBoxInput.Controls.Add(this.button1);
            this.groupBoxInput.Controls.Add(this.textBoxPath);
            this.groupBoxInput.Controls.Add(this.comboBoxDriveSelect);
            this.groupBoxInput.Location = new System.Drawing.Point(14, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(369, 84);
            this.groupBoxInput.TabIndex = 3;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kopiuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Przenieś";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(128, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Usuń";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(178, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Nowy Folder";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // CommanderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.listBoxOutput);
            this.MinimumSize = new System.Drawing.Size(396, 288);
            this.Name = "CommanderPanel";
            this.Size = new System.Drawing.Size(396, 465);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ComboBox comboBoxDriveSelect;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
