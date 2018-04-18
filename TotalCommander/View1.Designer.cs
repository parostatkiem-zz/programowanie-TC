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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.progressBarIsWorking = new System.Windows.Forms.ProgressBar();
            this.commanderPanelLeft = new TotalCommander.CommanderPanel();
            this.commanderPanelRight = new TotalCommander.CommanderPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Location = new System.Drawing.Point(10, 13);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.commanderPanelLeft);
            this.splitContainerMain.Panel1MinSize = 414;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.commanderPanelRight);
            this.splitContainerMain.Panel2MinSize = 414;
            this.splitContainerMain.Size = new System.Drawing.Size(834, 489);
            this.splitContainerMain.SplitterDistance = 414;
            this.splitContainerMain.TabIndex = 1;
            // 
            // progressBarIsWorking
            // 
            this.progressBarIsWorking.AccessibleDescription = "";
            this.progressBarIsWorking.AccessibleName = "";
            this.progressBarIsWorking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarIsWorking.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarIsWorking.ForeColor = System.Drawing.Color.DarkOrchid;
            this.progressBarIsWorking.Location = new System.Drawing.Point(10, 1);
            this.progressBarIsWorking.MarqueeAnimationSpeed = 1;
            this.progressBarIsWorking.Name = "progressBarIsWorking";
            this.progressBarIsWorking.Size = new System.Drawing.Size(834, 10);
            this.progressBarIsWorking.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarIsWorking.TabIndex = 2;
            this.progressBarIsWorking.Value = 20;
            this.progressBarIsWorking.Visible = false;
            // 
            // commanderPanelLeft
            // 
            this.commanderPanelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commanderPanelLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.commanderPanelLeft.DriveList = null;
            this.commanderPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.commanderPanelLeft.MinimumSize = new System.Drawing.Size(170, 288);
            this.commanderPanelLeft.Name = "commanderPanelLeft";
            this.commanderPanelLeft.Padding = new System.Windows.Forms.Padding(5);
            this.commanderPanelLeft.Size = new System.Drawing.Size(406, 508);
            this.commanderPanelLeft.TabIndex = 0;
            // 
            // commanderPanelRight
            // 
            this.commanderPanelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commanderPanelRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.commanderPanelRight.DriveList = null;
            this.commanderPanelRight.Location = new System.Drawing.Point(3, 3);
            this.commanderPanelRight.MinimumSize = new System.Drawing.Size(170, 288);
            this.commanderPanelRight.Name = "commanderPanelRight";
            this.commanderPanelRight.Padding = new System.Windows.Forms.Padding(5);
            this.commanderPanelRight.Size = new System.Drawing.Size(405, 508);
            this.commanderPanelRight.TabIndex = 1;
            // 
            // View1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 512);
            this.Controls.Add(this.progressBarIsWorking);
            this.Controls.Add(this.splitContainerMain);
            this.MinimumSize = new System.Drawing.Size(832, 328);
            this.Name = "View1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Mini Total Commander";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CommanderPanel commanderPanelLeft;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private CommanderPanel commanderPanelRight;
        private System.Windows.Forms.ProgressBar progressBarIsWorking;
    }
}

