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
            this.buttonNewFolder = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.groupBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.comboBoxDriveSelect.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.comboBoxDriveSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDriveSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDriveSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxDriveSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxDriveSelect.FormattingEnabled = true;
            this.comboBoxDriveSelect.Location = new System.Drawing.Point(260, 54);
            this.comboBoxDriveSelect.Name = "comboBoxDriveSelect";
            this.comboBoxDriveSelect.Size = new System.Drawing.Size(98, 21);
            this.comboBoxDriveSelect.TabIndex = 1;
            this.comboBoxDriveSelect.DropDown += new System.EventHandler(this.comboBoxDriveSelect_DropDown);
            this.comboBoxDriveSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxDriveSelect_SelectedIndexChanged);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.ItemHeight = 16;
            this.listBoxOutput.Location = new System.Drawing.Point(14, 111);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(369, 324);
            this.listBoxOutput.TabIndex = 2;
            this.listBoxOutput.DoubleClick += new System.EventHandler(this.listBoxOutput_DoubleClick);
            this.listBoxOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBoxOutput_KeyPress);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput.Controls.Add(this.buttonNewFolder);
            this.groupBoxInput.Controls.Add(this.buttonDelete);
            this.groupBoxInput.Controls.Add(this.buttonMove);
            this.groupBoxInput.Controls.Add(this.buttonCopy);
            this.groupBoxInput.Controls.Add(this.textBoxPath);
            this.groupBoxInput.Controls.Add(this.comboBoxDriveSelect);
            this.groupBoxInput.Location = new System.Drawing.Point(14, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(369, 84);
            this.groupBoxInput.TabIndex = 3;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Panel kontrolny";
            // 
            // buttonNewFolder
            // 
            this.buttonNewFolder.BackColor = System.Drawing.Color.Khaki;
            this.buttonNewFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewFolder.Location = new System.Drawing.Point(178, 53);
            this.buttonNewFolder.Name = "buttonNewFolder";
            this.buttonNewFolder.Size = new System.Drawing.Size(76, 23);
            this.buttonNewFolder.TabIndex = 5;
            this.buttonNewFolder.Text = "Nowy Folder";
            this.buttonNewFolder.UseVisualStyleBackColor = false;
            this.buttonNewFolder.Click += new System.EventHandler(this.buttonNewFolder_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(128, 53);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(44, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonMove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMove.Location = new System.Drawing.Point(65, 53);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(57, 23);
            this.buttonMove.TabIndex = 3;
            this.buttonMove.Text = "Przenieś";
            this.buttonMove.UseVisualStyleBackColor = false;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCopy.Location = new System.Drawing.Point(11, 53);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(48, 23);
            this.buttonCopy.TabIndex = 2;
            this.buttonCopy.Text = "Kopiuj";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
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
        private System.Windows.Forms.Button buttonNewFolder;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonCopy;
    }
}
