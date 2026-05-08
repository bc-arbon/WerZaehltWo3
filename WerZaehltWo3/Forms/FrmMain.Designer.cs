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
            this.MnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileShowDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileTsMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileSetCourtCount = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileEditPlayers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuApplyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelpInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSettingsControls = new System.Windows.Forms.FlowLayoutPanel();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile,
            this.MnuApplyAll,
            this.MnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            this.MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFileShowDisplay,
            this.MnuFileTsMonitor,
            this.MnuFileSetCourtCount,
            this.MnuFileEditPlayers,
            this.toolStripSeparator1,
            this.MnuFileQuit});
            this.MnuFile.Name = "MnuFile";
            this.MnuFile.Size = new System.Drawing.Size(46, 22);
            this.MnuFile.Text = "Datei";
            // 
            // MnuFileShowDisplay
            // 
            this.MnuFileShowDisplay.Name = "MnuFileShowDisplay";
            this.MnuFileShowDisplay.Size = new System.Drawing.Size(205, 22);
            this.MnuFileShowDisplay.Text = "Display anzeigen";
            this.MnuFileShowDisplay.Click += new System.EventHandler(this.MnuFileShowDisplay_Click);
            // 
            // MnuFileTsMonitor
            // 
            this.MnuFileTsMonitor.Name = "MnuFileTsMonitor";
            this.MnuFileTsMonitor.Size = new System.Drawing.Size(205, 22);
            this.MnuFileTsMonitor.Text = "TTV Client anzeigen";
            this.MnuFileTsMonitor.Click += new System.EventHandler(this.MnuFileTsMonitor_Click);
            // 
            // MnuFileSetCourtCount
            // 
            this.MnuFileSetCourtCount.Name = "MnuFileSetCourtCount";
            this.MnuFileSetCourtCount.Size = new System.Drawing.Size(205, 22);
            this.MnuFileSetCourtCount.Text = "Anzahl Felder festlegen...";
            this.MnuFileSetCourtCount.Click += new System.EventHandler(this.MnuFileSetCourtCount_Click);
            // 
            // MnuFileEditPlayers
            // 
            this.MnuFileEditPlayers.Name = "MnuFileEditPlayers";
            this.MnuFileEditPlayers.Size = new System.Drawing.Size(205, 22);
            this.MnuFileEditPlayers.Text = "Spieler bearbeiten...";
            this.MnuFileEditPlayers.Click += new System.EventHandler(this.MnuFileEditPlayers_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // MnuFileQuit
            // 
            this.MnuFileQuit.Name = "MnuFileQuit";
            this.MnuFileQuit.Size = new System.Drawing.Size(205, 22);
            this.MnuFileQuit.Text = "Beenden";
            this.MnuFileQuit.Click += new System.EventHandler(this.MnuFileQuit_Click);
            // 
            // MnuApplyAll
            // 
            this.MnuApplyAll.Name = "MnuApplyAll";
            this.MnuApplyAll.Size = new System.Drawing.Size(113, 22);
            this.MnuApplyAll.Text = "Alles aktualisieren";
            this.MnuApplyAll.Click += new System.EventHandler(this.MnuApplyAll_Click);
            // 
            // MnuHelp
            // 
            this.MnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuHelpInfo});
            this.MnuHelp.Name = "MnuHelp";
            this.MnuHelp.Size = new System.Drawing.Size(24, 22);
            this.MnuHelp.Text = "?";
            // 
            // MnuHelpInfo
            // 
            this.MnuHelpInfo.Name = "MnuHelpInfo";
            this.MnuHelpInfo.Size = new System.Drawing.Size(95, 22);
            this.MnuHelpInfo.Text = "Info";
            this.MnuHelpInfo.Click += new System.EventHandler(this.MnuHelpInfo_Click);
            // 
            // pnlSettingsControls
            // 
            this.pnlSettingsControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingsControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
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
        private System.Windows.Forms.ToolStripMenuItem MnuFile;
        private System.Windows.Forms.ToolStripMenuItem MnuFileShowDisplay;
        private System.Windows.Forms.ToolStripMenuItem MnuFileSetCourtCount;
        private System.Windows.Forms.ToolStripMenuItem MnuFileEditPlayers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MnuFileQuit;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp;
        private System.Windows.Forms.ToolStripMenuItem MnuHelpInfo;
        private System.Windows.Forms.FlowLayoutPanel pnlSettingsControls;
        private System.Windows.Forms.ToolStripMenuItem MnuFileTsMonitor;
        private System.Windows.Forms.ToolStripMenuItem MnuApplyAll;
    }
}

