namespace TsDataServer
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
            this.components = new System.ComponentModel.Container();
            this.LvwPlannedMatches = new System.Windows.Forms.ListView();
            this.ChrCourt2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrPlanDate2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrPlayer12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrPlayer22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrDraw2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrRound2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnStopAutoupdate = new System.Windows.Forms.Button();
            this.BtnStartAutoUpdate = new System.Windows.Forms.Button();
            this.LvwCurrentMatches = new System.Windows.Forms.ListView();
            this.ChrCourt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrPlanDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrPlayer1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrPlayer2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrDraw = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChrRound = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NudInterval = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtRabbitVhost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtRabbitUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRabbitServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnOpenDatabase = new System.Windows.Forms.Button();
            this.TxtDatabaseFilepath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LblNextUpdate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblStatusRabbit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblStatusDatabase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TmrUpdater = new System.Windows.Forms.Timer(this.components);
            this.TmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.TxtRabbitPassword = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudInterval)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.LvwPlannedMatches.Location = new System.Drawing.Point(6, 19);
            this.LvwPlannedMatches.Name = "LvwPlannedMatches";
            this.LvwPlannedMatches.Size = new System.Drawing.Size(735, 363);
            this.LvwPlannedMatches.TabIndex = 8;
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
            // ChrRound2
            // 
            this.ChrRound2.Text = "Round";
            // 
            // BtnStopAutoupdate
            // 
            this.BtnStopAutoupdate.Enabled = false;
            this.BtnStopAutoupdate.Location = new System.Drawing.Point(6, 48);
            this.BtnStopAutoupdate.Name = "BtnStopAutoupdate";
            this.BtnStopAutoupdate.Size = new System.Drawing.Size(157, 23);
            this.BtnStopAutoupdate.TabIndex = 5;
            this.BtnStopAutoupdate.Text = "Stop";
            this.BtnStopAutoupdate.UseVisualStyleBackColor = true;
            this.BtnStopAutoupdate.Click += new System.EventHandler(this.BtnStopAutoupdate_Click);
            // 
            // BtnStartAutoUpdate
            // 
            this.BtnStartAutoUpdate.Location = new System.Drawing.Point(6, 19);
            this.BtnStartAutoUpdate.Name = "BtnStartAutoUpdate";
            this.BtnStartAutoUpdate.Size = new System.Drawing.Size(157, 23);
            this.BtnStartAutoUpdate.TabIndex = 6;
            this.BtnStartAutoUpdate.Text = "Start";
            this.BtnStartAutoUpdate.UseVisualStyleBackColor = true;
            this.BtnStartAutoUpdate.Click += new System.EventHandler(this.BtnStartAutoUpdate_Click);
            // 
            // LvwCurrentMatches
            // 
            this.LvwCurrentMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LvwCurrentMatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChrCourt,
            this.ChrPlanDate,
            this.ChrPlayer1,
            this.ChrPlayer2,
            this.ChrDraw,
            this.ChrRound});
            this.LvwCurrentMatches.HideSelection = false;
            this.LvwCurrentMatches.Location = new System.Drawing.Point(6, 19);
            this.LvwCurrentMatches.Name = "LvwCurrentMatches";
            this.LvwCurrentMatches.Size = new System.Drawing.Size(735, 170);
            this.LvwCurrentMatches.TabIndex = 4;
            this.LvwCurrentMatches.UseCompatibleStateImageBehavior = false;
            this.LvwCurrentMatches.View = System.Windows.Forms.View.Details;
            // 
            // ChrCourt
            // 
            this.ChrCourt.Text = "Court";
            // 
            // ChrPlanDate
            // 
            this.ChrPlanDate.Text = "Plan Date";
            this.ChrPlanDate.Width = 120;
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TxtRabbitPassword);
            this.groupBox1.Controls.Add(this.NudInterval);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtRabbitVhost);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtRabbitUser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtRabbitServer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnOpenDatabase);
            this.groupBox1.Controls.Add(this.TxtDatabaseFilepath);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 111);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konfiguration";
            // 
            // NudInterval
            // 
            this.NudInterval.Location = new System.Drawing.Point(97, 76);
            this.NudInterval.Name = "NudInterval";
            this.NudInterval.Size = new System.Drawing.Size(93, 20);
            this.NudInterval.TabIndex = 20;
            this.NudInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Update Intervall:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Vhost:";
            // 
            // TxtRabbitVhost
            // 
            this.TxtRabbitVhost.Location = new System.Drawing.Point(302, 44);
            this.TxtRabbitVhost.Name = "TxtRabbitVhost";
            this.TxtRabbitVhost.Size = new System.Drawing.Size(84, 20);
            this.TxtRabbitVhost.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(562, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Passwort:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "User:";
            // 
            // TxtRabbitUser
            // 
            this.TxtRabbitUser.Location = new System.Drawing.Point(434, 44);
            this.TxtRabbitUser.Name = "TxtRabbitUser";
            this.TxtRabbitUser.Size = new System.Drawing.Size(121, 20);
            this.TxtRabbitUser.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Server:";
            // 
            // TxtRabbitServer
            // 
            this.TxtRabbitServer.Location = new System.Drawing.Point(135, 44);
            this.TxtRabbitServer.Name = "TxtRabbitServer";
            this.TxtRabbitServer.Size = new System.Drawing.Size(118, 20);
            this.TxtRabbitServer.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "RabbitMQ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datenbank:";
            // 
            // BtnOpenDatabase
            // 
            this.BtnOpenDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenDatabase.Location = new System.Drawing.Point(711, 15);
            this.BtnOpenDatabase.Name = "BtnOpenDatabase";
            this.BtnOpenDatabase.Size = new System.Drawing.Size(30, 23);
            this.BtnOpenDatabase.TabIndex = 8;
            this.BtnOpenDatabase.Text = "...";
            this.BtnOpenDatabase.UseVisualStyleBackColor = true;
            // 
            // TxtDatabaseFilepath
            // 
            this.TxtDatabaseFilepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDatabaseFilepath.Location = new System.Drawing.Point(97, 17);
            this.TxtDatabaseFilepath.Name = "TxtDatabaseFilepath";
            this.TxtDatabaseFilepath.Size = new System.Drawing.Size(608, 20);
            this.TxtDatabaseFilepath.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.LvwCurrentMatches);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 195);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Laufende Spiele";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.LvwPlannedMatches);
            this.groupBox3.Location = new System.Drawing.Point(12, 415);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(747, 388);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Geplante Spiele";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.LblNextUpdate);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.LblStatusRabbit);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.LblStatusDatabase);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.BtnStartAutoUpdate);
            this.groupBox4.Controls.Add(this.BtnStopAutoupdate);
            this.groupBox4.Location = new System.Drawing.Point(18, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(747, 83);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Steuerung";
            // 
            // LblNextUpdate
            // 
            this.LblNextUpdate.AutoSize = true;
            this.LblNextUpdate.Location = new System.Drawing.Point(480, 24);
            this.LblNextUpdate.Name = "LblNextUpdate";
            this.LblNextUpdate.Size = new System.Drawing.Size(18, 13);
            this.LblNextUpdate.TabIndex = 12;
            this.LblNextUpdate.Text = "--s";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nächstes Update:";
            // 
            // LblStatusRabbit
            // 
            this.LblStatusRabbit.AutoSize = true;
            this.LblStatusRabbit.ForeColor = System.Drawing.Color.Red;
            this.LblStatusRabbit.Location = new System.Drawing.Point(266, 53);
            this.LblStatusRabbit.Name = "LblStatusRabbit";
            this.LblStatusRabbit.Size = new System.Drawing.Size(86, 13);
            this.LblStatusRabbit.TabIndex = 10;
            this.LblStatusRabbit.Text = "Nicht verbunden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "RabbitMQ:";
            // 
            // LblStatusDatabase
            // 
            this.LblStatusDatabase.AutoSize = true;
            this.LblStatusDatabase.ForeColor = System.Drawing.Color.Red;
            this.LblStatusDatabase.Location = new System.Drawing.Point(266, 24);
            this.LblStatusDatabase.Name = "LblStatusDatabase";
            this.LblStatusDatabase.Size = new System.Drawing.Size(86, 13);
            this.LblStatusDatabase.TabIndex = 8;
            this.LblStatusDatabase.Text = "Nicht verbunden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Datenbank:";
            // 
            // TmrUpdater
            // 
            this.TmrUpdater.Interval = 10000;
            this.TmrUpdater.Tick += new System.EventHandler(this.TmrUpdater_Tick);
            // 
            // TmrCountdown
            // 
            this.TmrCountdown.Interval = 900;
            this.TmrCountdown.Tick += new System.EventHandler(this.TmrCountdown_Tick);
            // 
            // TxtRabbitPassword
            // 
            this.TxtRabbitPassword.Location = new System.Drawing.Point(621, 44);
            this.TxtRabbitPassword.Name = "TxtRabbitPassword";
            this.TxtRabbitPassword.Size = new System.Drawing.Size(120, 20);
            this.TxtRabbitPassword.TabIndex = 21;
            this.TxtRabbitPassword.UseSystemPasswordChar = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 815);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TS Data Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudInterval)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvwPlannedMatches;
        private System.Windows.Forms.ColumnHeader ChrCourt2;
        private System.Windows.Forms.ColumnHeader ChrPlanDate2;
        private System.Windows.Forms.ColumnHeader ChrPlayer12;
        private System.Windows.Forms.ColumnHeader ChrPlayer22;
        private System.Windows.Forms.ColumnHeader ChrDraw2;
        private System.Windows.Forms.ColumnHeader ChrRound2;
        private System.Windows.Forms.Button BtnStopAutoupdate;
        private System.Windows.Forms.Button BtnStartAutoUpdate;
        private System.Windows.Forms.ListView LvwCurrentMatches;
        private System.Windows.Forms.ColumnHeader ChrCourt;
        private System.Windows.Forms.ColumnHeader ChrPlanDate;
        private System.Windows.Forms.ColumnHeader ChrPlayer1;
        private System.Windows.Forms.ColumnHeader ChrPlayer2;
        private System.Windows.Forms.ColumnHeader ChrDraw;
        private System.Windows.Forms.ColumnHeader ChrRound;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtRabbitVhost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtRabbitUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtRabbitServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnOpenDatabase;
        private System.Windows.Forms.TextBox TxtDatabaseFilepath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label LblStatusDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NudInterval;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblNextUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblStatusRabbit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer TmrUpdater;
        private System.Windows.Forms.Timer TmrCountdown;
        private System.Windows.Forms.MaskedTextBox TxtRabbitPassword;
    }
}

