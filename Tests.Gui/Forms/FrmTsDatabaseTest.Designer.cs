namespace BCA.WerZaehltWo3.Tests.Gui.Forms
{
    partial class FrmTsDatabaseTest
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
            this.components = new System.ComponentModel.Container();
            this.lvwPlayers = new System.Windows.Forms.ListView();
            this.chrName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDatabaseFilepath = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnGetPlayers = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpgPlayers = new System.Windows.Forms.TabPage();
            this.TpgMatches = new System.Windows.Forms.TabPage();
            this.BtnOneTimeUpdate = new System.Windows.Forms.Button();
            this.BtnStopAutoupdate = new System.Windows.Forms.Button();
            this.BtnStartAutoUpdate = new System.Windows.Forms.Button();
            this.LvwCurrentMatches = new System.Windows.Forms.ListView();
            this.ChrCourt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrPlayer1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrPlayer2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrDraw = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrRound = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TmrMatches = new System.Windows.Forms.Timer(this.components);
            this.LvwPlannedMatches = new System.Windows.Forms.ListView();
            this.ChrCourt2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrPlanDate2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrPlayer12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrPlayer22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrDraw2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrPlanDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrRound2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.TpgPlayers.SuspendLayout();
            this.TpgMatches.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwPlayers
            // 
            this.lvwPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chrName});
            this.lvwPlayers.HideSelection = false;
            this.lvwPlayers.Location = new System.Drawing.Point(3, 35);
            this.lvwPlayers.Name = "lvwPlayers";
            this.lvwPlayers.Size = new System.Drawing.Size(501, 363);
            this.lvwPlayers.TabIndex = 6;
            this.lvwPlayers.UseCompatibleStateImageBehavior = false;
            this.lvwPlayers.View = System.Windows.Forms.View.Details;
            // 
            // chrName
            // 
            this.chrName.Text = "Name";
            this.chrName.Width = 300;
            // 
            // txtDatabaseFilepath
            // 
            this.txtDatabaseFilepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatabaseFilepath.Location = new System.Drawing.Point(149, 15);
            this.txtDatabaseFilepath.Name = "txtDatabaseFilepath";
            this.txtDatabaseFilepath.Size = new System.Drawing.Size(632, 20);
            this.txtDatabaseFilepath.TabIndex = 5;
            this.txtDatabaseFilepath.Text = "C:\\repos\\dahafner\\WerZaehltWo3\\WerZaehltWo3\\bin\\Debug\\ts.accdb";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(13, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(130, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnGetPlayers
            // 
            this.btnGetPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetPlayers.Location = new System.Drawing.Point(3, 6);
            this.btnGetPlayers.Name = "btnGetPlayers";
            this.btnGetPlayers.Size = new System.Drawing.Size(501, 23);
            this.btnGetPlayers.TabIndex = 4;
            this.btnGetPlayers.Text = "Get Players";
            this.btnGetPlayers.UseVisualStyleBackColor = true;
            this.btnGetPlayers.Click += new System.EventHandler(this.BtnGetPlayers_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.TpgPlayers);
            this.tabControl1.Controls.Add(this.TpgMatches);
            this.tabControl1.Location = new System.Drawing.Point(13, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 530);
            this.tabControl1.TabIndex = 7;
            // 
            // TpgPlayers
            // 
            this.TpgPlayers.Controls.Add(this.lvwPlayers);
            this.TpgPlayers.Controls.Add(this.btnGetPlayers);
            this.TpgPlayers.Location = new System.Drawing.Point(4, 22);
            this.TpgPlayers.Name = "TpgPlayers";
            this.TpgPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.TpgPlayers.Size = new System.Drawing.Size(764, 420);
            this.TpgPlayers.TabIndex = 0;
            this.TpgPlayers.Text = "Players";
            this.TpgPlayers.UseVisualStyleBackColor = true;
            // 
            // TpgMatches
            // 
            this.TpgMatches.Controls.Add(this.LvwPlannedMatches);
            this.TpgMatches.Controls.Add(this.BtnOneTimeUpdate);
            this.TpgMatches.Controls.Add(this.BtnStopAutoupdate);
            this.TpgMatches.Controls.Add(this.BtnStartAutoUpdate);
            this.TpgMatches.Controls.Add(this.LvwCurrentMatches);
            this.TpgMatches.Location = new System.Drawing.Point(4, 22);
            this.TpgMatches.Name = "TpgMatches";
            this.TpgMatches.Padding = new System.Windows.Forms.Padding(3);
            this.TpgMatches.Size = new System.Drawing.Size(760, 504);
            this.TpgMatches.TabIndex = 1;
            this.TpgMatches.Text = "Matches";
            this.TpgMatches.UseVisualStyleBackColor = true;
            // 
            // BtnOneTimeUpdate
            // 
            this.BtnOneTimeUpdate.Location = new System.Drawing.Point(332, 6);
            this.BtnOneTimeUpdate.Name = "BtnOneTimeUpdate";
            this.BtnOneTimeUpdate.Size = new System.Drawing.Size(112, 23);
            this.BtnOneTimeUpdate.TabIndex = 2;
            this.BtnOneTimeUpdate.Text = "One Time Update";
            this.BtnOneTimeUpdate.UseVisualStyleBackColor = true;
            this.BtnOneTimeUpdate.Click += new System.EventHandler(this.BtnOneTimeUpdate_Click);
            // 
            // BtnStopAutoupdate
            // 
            this.BtnStopAutoupdate.Location = new System.Drawing.Point(169, 6);
            this.BtnStopAutoupdate.Name = "BtnStopAutoupdate";
            this.BtnStopAutoupdate.Size = new System.Drawing.Size(157, 23);
            this.BtnStopAutoupdate.TabIndex = 1;
            this.BtnStopAutoupdate.Text = "Stop";
            this.BtnStopAutoupdate.UseVisualStyleBackColor = true;
            this.BtnStopAutoupdate.Click += new System.EventHandler(this.BtnStopAutoupdate_Click);
            // 
            // BtnStartAutoUpdate
            // 
            this.BtnStartAutoUpdate.Location = new System.Drawing.Point(6, 6);
            this.BtnStartAutoUpdate.Name = "BtnStartAutoUpdate";
            this.BtnStartAutoUpdate.Size = new System.Drawing.Size(157, 23);
            this.BtnStartAutoUpdate.TabIndex = 1;
            this.BtnStartAutoUpdate.Text = "Start Auto Update";
            this.BtnStartAutoUpdate.UseVisualStyleBackColor = true;
            this.BtnStartAutoUpdate.Click += new System.EventHandler(this.BtnStartAutoUpdate_Click);
            // 
            // LvwCurrentMatches
            // 
            this.LvwCurrentMatches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LvwCurrentMatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChrCourt,
            this.ChrPlanDate,
            this.ChrPlayer1,
            this.ChrPlayer2,
            this.ChrDraw,
            this.ChrRound});
            this.LvwCurrentMatches.HideSelection = false;
            this.LvwCurrentMatches.Location = new System.Drawing.Point(6, 35);
            this.LvwCurrentMatches.Name = "LvwCurrentMatches";
            this.LvwCurrentMatches.Size = new System.Drawing.Size(748, 185);
            this.LvwCurrentMatches.TabIndex = 0;
            this.LvwCurrentMatches.UseCompatibleStateImageBehavior = false;
            this.LvwCurrentMatches.View = System.Windows.Forms.View.Details;
            // 
            // ChrCourt
            // 
            this.ChrCourt.Text = "Court";
            // 
            // ChrPlayer1
            // 
            this.ChrPlayer1.Text = "Player 1";
            this.ChrPlayer1.Width = 200;
            // 
            // ChrPlayer2
            // 
            this.ChrPlayer2.Text = "Player 2";
            this.ChrPlayer2.Width = 200;
            // 
            // ChrDraw
            // 
            this.ChrDraw.Text = "Draw";
            // 
            // ChrRound
            // 
            this.ChrRound.Text = "Round";
            // 
            // TmrMatches
            // 
            this.TmrMatches.Interval = 2000;
            this.TmrMatches.Tick += new System.EventHandler(this.TmrMatches_Tick);
            // 
            // LvwPlannedMatches
            // 
            this.LvwPlannedMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LvwPlannedMatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChrCourt2,
            this.ChrPlanDate2,
            this.ChrPlayer12,
            this.ChrPlayer22,
            this.ChrDraw2,
            this.ChrRound2});
            this.LvwPlannedMatches.HideSelection = false;
            this.LvwPlannedMatches.Location = new System.Drawing.Point(3, 226);
            this.LvwPlannedMatches.Name = "LvwPlannedMatches";
            this.LvwPlannedMatches.Size = new System.Drawing.Size(751, 275);
            this.LvwPlannedMatches.TabIndex = 3;
            this.LvwPlannedMatches.UseCompatibleStateImageBehavior = false;
            this.LvwPlannedMatches.View = System.Windows.Forms.View.Details;
            // 
            // ChrCourt2
            // 
            this.ChrCourt2.Text = "Court";
            // 
            // ChrPlanDate2
            // 
            this.ChrPlanDate2.Text = "Plan Date";
            this.ChrPlanDate2.Width = 120;
            // 
            // ChrPlayer12
            // 
            this.ChrPlayer12.Text = "Player 1";
            this.ChrPlayer12.Width = 200;
            // 
            // ChrPlayer22
            // 
            this.ChrPlayer22.Text = "Player 2";
            this.ChrPlayer22.Width = 200;
            // 
            // ChrDraw2
            // 
            this.ChrDraw2.Text = "Draw";
            // 
            // ChrPlanDate
            // 
            this.ChrPlanDate.Text = "Plan Date";
            this.ChrPlanDate.Width = 120;
            // 
            // ChrRound2
            // 
            this.ChrRound2.Text = "Round";
            // 
            // FrmTsDatabaseTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 584);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtDatabaseFilepath);
            this.Controls.Add(this.btnConnect);
            this.Name = "FrmTsDatabaseTest";
            this.Text = "FrmTsDatabaseTest";
            this.tabControl1.ResumeLayout(false);
            this.TpgPlayers.ResumeLayout(false);
            this.TpgMatches.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwPlayers;
        private System.Windows.Forms.ColumnHeader chrName;
        private System.Windows.Forms.TextBox txtDatabaseFilepath;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnGetPlayers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TpgPlayers;
        private System.Windows.Forms.TabPage TpgMatches;
        private System.Windows.Forms.Timer TmrMatches;
        private System.Windows.Forms.Button BtnStopAutoupdate;
        private System.Windows.Forms.Button BtnStartAutoUpdate;
        private System.Windows.Forms.ListView LvwCurrentMatches;
        private System.Windows.Forms.ColumnHeader ChrCourt;
        private System.Windows.Forms.ColumnHeader ChrPlayer1;
        private System.Windows.Forms.ColumnHeader ChrPlayer2;
        private System.Windows.Forms.Button BtnOneTimeUpdate;
        private System.Windows.Forms.ColumnHeader ChrDraw;
        private System.Windows.Forms.ColumnHeader ChrRound;
        private System.Windows.Forms.ListView LvwPlannedMatches;
        private System.Windows.Forms.ColumnHeader ChrCourt2;
        private System.Windows.Forms.ColumnHeader ChrPlanDate2;
        private System.Windows.Forms.ColumnHeader ChrPlayer12;
        private System.Windows.Forms.ColumnHeader ChrPlayer22;
        private System.Windows.Forms.ColumnHeader ChrDraw2;
        private System.Windows.Forms.ColumnHeader ChrRound2;
        private System.Windows.Forms.ColumnHeader ChrPlanDate;
    }
}