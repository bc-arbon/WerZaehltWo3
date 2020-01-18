namespace BCA.WerZaehltWo3.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileShowDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSetCourtCount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileEditPlayers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSettingsControls = new System.Windows.Forms.FlowLayoutPanel();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileShowDisplay,
            this.mnuFileSetCourtCount,
            this.mnuFileEditPlayers,
            this.toolStripSeparator1,
            this.mnuFileQuit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 20);
            this.mnuFile.Text = "Datei";
            // 
            // mnuFileShowDisplay
            // 
            this.mnuFileShowDisplay.Name = "mnuFileShowDisplay";
            this.mnuFileShowDisplay.Size = new System.Drawing.Size(205, 22);
            this.mnuFileShowDisplay.Text = "Display anzeigen";
            this.mnuFileShowDisplay.Click += new System.EventHandler(this.mnuFileShowDisplay_Click);
            // 
            // mnuFileSetCourtCount
            // 
            this.mnuFileSetCourtCount.Name = "mnuFileSetCourtCount";
            this.mnuFileSetCourtCount.Size = new System.Drawing.Size(205, 22);
            this.mnuFileSetCourtCount.Text = "Anzahl Felder festlegen...";
            this.mnuFileSetCourtCount.Click += new System.EventHandler(this.mnuFileSetCourtCount_Click);
            // 
            // mnuFileEditPlayers
            // 
            this.mnuFileEditPlayers.Name = "mnuFileEditPlayers";
            this.mnuFileEditPlayers.Size = new System.Drawing.Size(205, 22);
            this.mnuFileEditPlayers.Text = "Spieler bearbeiten...";
            this.mnuFileEditPlayers.Click += new System.EventHandler(this.mnuFileEditPlayers_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // mnuFileQuit
            // 
            this.mnuFileQuit.Name = "mnuFileQuit";
            this.mnuFileQuit.Size = new System.Drawing.Size(205, 22);
            this.mnuFileQuit.Text = "Beenden";
            this.mnuFileQuit.Click += new System.EventHandler(this.mnuFileQuit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpInfo});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(24, 20);
            this.mnuHelp.Text = "?";
            // 
            // mnuHelpInfo
            // 
            this.mnuHelpInfo.Name = "mnuHelpInfo";
            this.mnuHelpInfo.Size = new System.Drawing.Size(95, 22);
            this.mnuHelpInfo.Text = "Info";
            this.mnuHelpInfo.Click += new System.EventHandler(this.mnuHelpInfo_Click);
            // 
            // pnlSettingsControls
            // 
            this.pnlSettingsControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingsControls.Location = new System.Drawing.Point(0, 24);
            this.pnlSettingsControls.Name = "pnlSettingsControls";
            this.pnlSettingsControls.Size = new System.Drawing.Size(800, 426);
            this.pnlSettingsControls.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSettingsControls);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wer Zählt Wo 3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileShowDisplay;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSetCourtCount;
        private System.Windows.Forms.ToolStripMenuItem mnuFileEditPlayers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileQuit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpInfo;
        private System.Windows.Forms.FlowLayoutPanel pnlSettingsControls;
    }
}

