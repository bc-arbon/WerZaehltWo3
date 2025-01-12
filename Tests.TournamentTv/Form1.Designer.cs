namespace Tests.TournamentTv
{
    partial class Form1
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
            button1 = new Button();
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(438, 12);
            button1.Name = "button1";
            button1.Size = new Size(210, 28);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LvwOnCourt
            // 
            LvwOnCourt.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader5, columnHeader6, columnHeader7 });
            LvwOnCourt.Location = new Point(12, 77);
            LvwOnCourt.Name = "LvwOnCourt";
            LvwOnCourt.Size = new Size(918, 192);
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
            LvwScheduled.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader12, columnHeader13, columnHeader14 });
            LvwScheduled.Location = new Point(12, 301);
            LvwScheduled.Name = "LvwScheduled";
            LvwScheduled.Size = new Size(918, 333);
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
            LvwFinished.Columns.AddRange(new ColumnHeader[] { columnHeader15, columnHeader16, columnHeader17, columnHeader19, columnHeader20, columnHeader21 });
            LvwFinished.Location = new Point(12, 655);
            LvwFinished.Name = "LvwFinished";
            LvwFinished.Size = new Size(918, 249);
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
            label2.Location = new Point(12, 283);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 5;
            label2.Text = "Scheduled";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 637);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Finished";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 916);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LvwFinished);
            Controls.Add(LvwScheduled);
            Controls.Add(LvwOnCourt);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
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
    }
}
