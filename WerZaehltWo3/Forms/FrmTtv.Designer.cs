using BCA.WerZaehltWo3.Shared.TournamentTv;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BCA.WerZaehltWo3.Forms
{
    partial class FrmTtv
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTtv));
            this.BtnStart = new System.Windows.Forms.Button();
            this.LvwOnCourt = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CmsApply = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MnuApply = new System.Windows.Forms.ToolStripMenuItem();
            this.LvwScheduled = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvwFinished = new System.Windows.Forms.ListView();
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblLastUpdate = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LvwCounting = new System.Windows.Forms.ListView();
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LvwReady = new System.Windows.Forms.ListView();
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CmsApply.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(10, 10);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(110, 24);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LvwOnCourt
            // 
            this.LvwOnCourt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LvwOnCourt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.LvwOnCourt.ContextMenuStrip = this.CmsApply;
            this.LvwOnCourt.FullRowSelect = true;
            this.LvwOnCourt.HideSelection = false;
            this.LvwOnCourt.Location = new System.Drawing.Point(10, 67);
            this.LvwOnCourt.Name = "LvwOnCourt";
            this.LvwOnCourt.Size = new System.Drawing.Size(748, 167);
            this.LvwOnCourt.TabIndex = 1;
            this.LvwOnCourt.UseCompatibleStateImageBehavior = false;
            this.LvwOnCourt.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Feld";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zeit";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Auslosung";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Runde";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mannschaft 1";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mannschaft 2";
            this.columnHeader6.Width = 200;
            // 
            // CmsApply
            // 
            this.CmsApply.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuApply});
            this.CmsApply.Name = "CmsApply";
            this.CmsApply.Size = new System.Drawing.Size(232, 26);
            this.CmsApply.Opening += new System.ComponentModel.CancelEventHandler(this.CmsApply_Opening);
            // 
            // MnuApply
            // 
            this.MnuApply.Name = "MnuApply";
            this.MnuApply.Size = new System.Drawing.Size(231, 22);
            this.MnuApply.Text = "Übernehmen zu xx auf Feld yy";
            this.MnuApply.Click += new System.EventHandler(this.MnuApply_Click);
            // 
            // LvwScheduled
            // 
            this.LvwScheduled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LvwScheduled.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader12,
            this.columnHeader13});
            this.LvwScheduled.ContextMenuStrip = this.CmsApply;
            this.LvwScheduled.FullRowSelect = true;
            this.LvwScheduled.HideSelection = false;
            this.LvwScheduled.Location = new System.Drawing.Point(0, 18);
            this.LvwScheduled.Name = "LvwScheduled";
            this.LvwScheduled.Size = new System.Drawing.Size(745, 217);
            this.LvwScheduled.TabIndex = 2;
            this.LvwScheduled.UseCompatibleStateImageBehavior = false;
            this.LvwScheduled.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Feld";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Zeit";
            this.columnHeader8.Width = 140;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Auslosung";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Runde";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Mannschaft 1";
            this.columnHeader12.Width = 200;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Mannschaft 2";
            this.columnHeader13.Width = 200;
            // 
            // LvwFinished
            // 
            this.LvwFinished.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LvwFinished.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader21,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader19,
            this.columnHeader20});
            this.LvwFinished.ContextMenuStrip = this.CmsApply;
            this.LvwFinished.FullRowSelect = true;
            this.LvwFinished.HideSelection = false;
            this.LvwFinished.Location = new System.Drawing.Point(0, 253);
            this.LvwFinished.Name = "LvwFinished";
            this.LvwFinished.Size = new System.Drawing.Size(745, 243);
            this.LvwFinished.TabIndex = 3;
            this.LvwFinished.UseCompatibleStateImageBehavior = false;
            this.LvwFinished.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Feld";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Zeit";
            this.columnHeader15.Width = 140;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Auslosung";
            this.columnHeader16.Width = 80;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Runde";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Mannschaft 1";
            this.columnHeader19.Width = 200;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Mannschaft 2";
            this.columnHeader20.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "On Court";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Scheduled";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Finished";
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(125, 10);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(110, 24);
            this.BtnStop.TabIndex = 0;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last update:";
            // 
            // LblLastUpdate
            // 
            this.LblLastUpdate.AutoSize = true;
            this.LblLastUpdate.Location = new System.Drawing.Point(325, 16);
            this.LblLastUpdate.Name = "LblLastUpdate";
            this.LblLastUpdate.Size = new System.Drawing.Size(36, 13);
            this.LblLastUpdate.TabIndex = 8;
            this.LblLastUpdate.Text = "Never";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 238);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 520);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LvwCounting);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.LvwReady);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(743, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Count / Ready";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LvwCounting
            // 
            this.LvwCounting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LvwCounting.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader24,
            this.columnHeader4,
            this.columnHeader11,
            this.columnHeader18,
            this.columnHeader22,
            this.columnHeader23});
            this.LvwCounting.ContextMenuStrip = this.CmsApply;
            this.LvwCounting.FullRowSelect = true;
            this.LvwCounting.HideSelection = false;
            this.LvwCounting.Location = new System.Drawing.Point(0, 17);
            this.LvwCounting.Name = "LvwCounting";
            this.LvwCounting.Size = new System.Drawing.Size(745, 217);
            this.LvwCounting.TabIndex = 7;
            this.LvwCounting.UseCompatibleStateImageBehavior = false;
            this.LvwCounting.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Feld";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Zeit";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Auslosung";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Runde";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Mannschaft 1";
            this.columnHeader22.Width = 200;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Mannschaft 2";
            this.columnHeader23.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Counting";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Get ready";
            // 
            // LvwReady
            // 
            this.LvwReady.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LvwReady.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader30,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader29});
            this.LvwReady.ContextMenuStrip = this.CmsApply;
            this.LvwReady.FullRowSelect = true;
            this.LvwReady.HideSelection = false;
            this.LvwReady.Location = new System.Drawing.Point(0, 252);
            this.LvwReady.Name = "LvwReady";
            this.LvwReady.Size = new System.Drawing.Size(745, 243);
            this.LvwReady.TabIndex = 8;
            this.LvwReady.UseCompatibleStateImageBehavior = false;
            this.LvwReady.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Feld";
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Zeit";
            this.columnHeader25.Width = 140;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Auslosung";
            this.columnHeader26.Width = 80;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Runde";
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Mannschaft 1";
            this.columnHeader28.Width = 200;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Mannschaft 2";
            this.columnHeader29.Width = 200;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LvwScheduled);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.LvwFinished);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(743, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Scheduled / Finished";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmTtv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 769);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LblLastUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LvwOnCourt);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTtv";
            this.Text = "TTV Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTtv_FormClosing);
            this.CmsApply.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ContextMenuStrip CmsApply;
        private ToolStripMenuItem MnuApply;
    }
}
