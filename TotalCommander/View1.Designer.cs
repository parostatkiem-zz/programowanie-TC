namespace TotalCommander
{
    partial class View1
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
            this.commanderPanel1 = new TotalCommander.CommanderPanel();
            this.SuspendLayout();
            // 
            // commanderPanel1
            // 
            this.commanderPanel1.DriveList = null;
            this.commanderPanel1.Location = new System.Drawing.Point(13, 13);
            this.commanderPanel1.Name = "commanderPanel1";
            this.commanderPanel1.Size = new System.Drawing.Size(486, 414);
            this.commanderPanel1.TabIndex = 0;
            // 
            // View1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 628);
            this.Controls.Add(this.commanderPanel1);
            this.Name = "View1";
            this.Text = "Mini Total Commander";
            this.ResumeLayout(false);

        }

        #endregion

        private CommanderPanel commanderPanel1;
    }
}

