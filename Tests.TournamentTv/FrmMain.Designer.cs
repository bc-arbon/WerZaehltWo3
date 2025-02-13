namespace Tests.TournamentTv
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnStart = new Button();
            LvwOnCourt = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            LvwScheduled = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            LvwFinished = new ListView();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            columnHeader21 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnStop = new Button();
            label4 = new Label();
            LblLastUpdate = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            LvwCounting = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            columnHeader24 = new ColumnHeader();
            label5 = new Label();
            label6 = new Label();
            LvwReady = new ListView();
            columnHeader25 = new ColumnHeader();
            columnHeader26 = new ColumnHeader();
            columnHeader27 = new ColumnHeader();
            columnHeader28 = new ColumnHeader();
            columnHeader29 = new ColumnHeader();
            columnHeader30 = new ColumnHeader();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(12, 12);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(128, 28);
            BtnStart.TabIndex = 0;
            BtnStart.Text = "Start";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // LvwOnCourt
            // 
            LvwOnCourt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LvwOnCourt.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5, columnHeader6, columnHeader7 });
            LvwOnCourt.FullRowSelect = true;
            LvwOnCourt.Location = new Point(12, 77);
            LvwOnCourt.Name = "LvwOnCourt";
            LvwOnCourt.Size = new Size(872, 192);
            LvwOnCourt.TabIndex = 1;
            LvwOnCourt.UseCompatibleStateImageBehavior = false;
            LvwOnCourt.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Zeit";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Auslosung";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Runde";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Mannschaft 1";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Mannschaft 2";
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Feld";
            // 
            // LvwScheduled
            // 
            LvwScheduled.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LvwScheduled.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader12, columnHeader13, columnHeader14 });
            LvwScheduled.FullRowSelect = true;
            LvwScheduled.Location = new Point(0, 21);
            LvwScheduled.Name = "LvwScheduled";
            LvwScheduled.Size = new Size(868, 250);
            LvwScheduled.TabIndex = 2;
            LvwScheduled.UseCompatibleStateImageBehavior = false;
            LvwScheduled.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Zeit";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Auslosung";
            columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Runde";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Mannschaft 1";
            columnHeader12.Width = 200;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Mannschaft 2";
            columnHeader13.Width = 200;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Feld";
            // 
            // LvwFinished
            // 
            LvwFinished.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LvwFinished.Columns.AddRange(new ColumnHeader[] { columnHeader15, columnHeader16, columnHeader17, columnHeader19, columnHeader20, columnHeader21 });
            LvwFinished.FullRowSelect = true;
            LvwFinished.Location = new Point(0, 292);
            LvwFinished.Name = "LvwFinished";
            LvwFinished.Size = new Size(868, 280);
            LvwFinished.TabIndex = 3;
            LvwFinished.UseCompatibleStateImageBehavior = false;
            LvwFinished.View = View.Details;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Zeit";
            columnHeader15.Width = 150;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Auslosung";
            columnHeader16.Width = 80;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Runde";
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Mannschaft 1";
            columnHeader19.Width = 200;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Mannschaft 2";
            columnHeader20.Width = 200;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Feld";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 4;
            label1.Text = "On Court";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 3);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 5;
            label2.Text = "Scheduled";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 274);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Finished";
            // 
            // BtnStop
            // 
            BtnStop.Enabled = false;
            BtnStop.Location = new Point(146, 12);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(128, 28);
            BtnStop.TabIndex = 0;
            BtnStop.Text = "Stop";
            BtnStop.UseVisualStyleBackColor = true;
            BtnStop.Click += BtnStop_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 19);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 7;
            label4.Text = "Last update:";
            // 
            // LblLastUpdate
            // 
            LblLastUpdate.AutoSize = true;
            LblLastUpdate.Location = new Point(379, 19);
            LblLastUpdate.Name = "LblLastUpdate";
            LblLastUpdate.Size = new Size(38, 15);
            LblLastUpdate.TabIndex = 8;
            LblLastUpdate.Text = "Never";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 275);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(876, 600);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(LvwCounting);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(LvwReady);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(868, 572);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Count / Ready";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // LvwCounting
            // 
            LvwCounting.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LvwCounting.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader11, columnHeader18, columnHeader22, columnHeader23, columnHeader24 });
            LvwCounting.FullRowSelect = true;
            LvwCounting.Location = new Point(0, 20);
            LvwCounting.Name = "LvwCounting";
            LvwCounting.Size = new Size(868, 250);
            LvwCounting.TabIndex = 7;
            LvwCounting.UseCompatibleStateImageBehavior = false;
            LvwCounting.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Zeit";
            columnHeader4.Width = 150;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Auslosung";
            columnHeader11.Width = 80;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Runde";
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Mannschaft 1";
            columnHeader22.Width = 200;
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "Mannschaft 2";
            columnHeader23.Width = 200;
            // 
            // columnHeader24
            // 
            columnHeader24.Text = "Feld";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 2);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Counting";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1, 273);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Get ready";
            // 
            // LvwReady
            // 
            LvwReady.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LvwReady.Columns.AddRange(new ColumnHeader[] { columnHeader25, columnHeader26, columnHeader27, columnHeader28, columnHeader29, columnHeader30 });
            LvwReady.FullRowSelect = true;
            LvwReady.Location = new Point(0, 291);
            LvwReady.Name = "LvwReady";
            LvwReady.Size = new Size(868, 280);
            LvwReady.TabIndex = 8;
            LvwReady.UseCompatibleStateImageBehavior = false;
            LvwReady.View = View.Details;
            // 
            // columnHeader25
            // 
            columnHeader25.Text = "Zeit";
            columnHeader25.Width = 150;
            // 
            // columnHeader26
            // 
            columnHeader26.Text = "Auslosung";
            columnHeader26.Width = 80;
            // 
            // columnHeader27
            // 
            columnHeader27.Text = "Runde";
            // 
            // columnHeader28
            // 
            columnHeader28.Text = "Mannschaft 1";
            columnHeader28.Width = 200;
            // 
            // columnHeader29
            // 
            columnHeader29.Text = "Mannschaft 2";
            columnHeader29.Width = 200;
            // 
            // columnHeader30
            // 
            columnHeader30.Text = "Feld";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(LvwScheduled);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(LvwFinished);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(868, 572);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Scheduled / Finished";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 887);
            Controls.Add(tabControl1);
            Controls.Add(LblLastUpdate);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(LvwOnCourt);
            Controls.Add(BtnStop);
            Controls.Add(BtnStart);
            Name = "FrmMain";
            Text = "TTV Client";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnStart;
        private ListView LvwOnCourt;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ListView LvwScheduled;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ListView LvwFinished;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnStop;
        private Label label4;
        private Label LblLastUpdate;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListView LvwCounting;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
        private Label label5;
        private Label label6;
        private ListView LvwReady;
        private ColumnHeader columnHeader25;
        private ColumnHeader columnHeader26;
        private ColumnHeader columnHeader27;
        private ColumnHeader columnHeader28;
        private ColumnHeader columnHeader29;
        private ColumnHeader columnHeader30;
        private TabPage tabPage2;
    }
}
