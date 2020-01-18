namespace BCA.WerZaehltWo3.Usercontrols
{
    partial class CourtDisplayControl
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
            this.lblCourtNumber = new System.Windows.Forms.Label();
            this.pnlReady = new System.Windows.Forms.Panel();
            this.tlpRed = new System.Windows.Forms.TableLayoutPanel();
            this.lblReady2 = new System.Windows.Forms.Label();
            this.lblReady1 = new System.Windows.Forms.Label();
            this.pnlCount = new System.Windows.Forms.Panel();
            this.tlpYellow = new System.Windows.Forms.TableLayoutPanel();
            this.lblCounting1 = new System.Windows.Forms.Label();
            this.lblCounting2 = new System.Windows.Forms.Label();
            this.pnlPlay = new System.Windows.Forms.Panel();
            this.tlpGreen = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlay2 = new System.Windows.Forms.Label();
            this.lblPlay1 = new System.Windows.Forms.Label();
            this.tlpCourt = new System.Windows.Forms.TableLayoutPanel();
            this.pnlReady.SuspendLayout();
            this.tlpRed.SuspendLayout();
            this.pnlCount.SuspendLayout();
            this.tlpYellow.SuspendLayout();
            this.pnlPlay.SuspendLayout();
            this.tlpGreen.SuspendLayout();
            this.tlpCourt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCourtNumber
            // 
            this.lblCourtNumber.BackColor = System.Drawing.SystemColors.Control;
            this.lblCourtNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCourtNumber.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourtNumber.Location = new System.Drawing.Point(0, 0);
            this.lblCourtNumber.Margin = new System.Windows.Forms.Padding(0);
            this.lblCourtNumber.Name = "lblCourtNumber";
            this.lblCourtNumber.Size = new System.Drawing.Size(200, 279);
            this.lblCourtNumber.TabIndex = 0;
            this.lblCourtNumber.Text = "0";
            this.lblCourtNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlReady
            // 
            this.pnlReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.pnlReady.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReady.Controls.Add(this.tlpRed);
            this.pnlReady.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReady.Location = new System.Drawing.Point(200, 0);
            this.pnlReady.Margin = new System.Windows.Forms.Padding(0);
            this.pnlReady.Name = "pnlReady";
            this.pnlReady.Size = new System.Drawing.Size(400, 279);
            this.pnlReady.TabIndex = 1;
            this.pnlReady.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlReady_Paint);
            // 
            // tlpRed
            // 
            this.tlpRed.ColumnCount = 1;
            this.tlpRed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRed.Controls.Add(this.lblReady2, 0, 1);
            this.tlpRed.Controls.Add(this.lblReady1, 0, 0);
            this.tlpRed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRed.Location = new System.Drawing.Point(0, 0);
            this.tlpRed.Name = "tlpRed";
            this.tlpRed.RowCount = 2;
            this.tlpRed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRed.Size = new System.Drawing.Size(396, 275);
            this.tlpRed.TabIndex = 1;
            // 
            // lblReady2
            // 
            this.lblReady2.BackColor = System.Drawing.Color.Transparent;
            this.lblReady2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReady2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReady2.Location = new System.Drawing.Point(4, 137);
            this.lblReady2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReady2.Name = "lblReady2";
            this.lblReady2.Size = new System.Drawing.Size(388, 138);
            this.lblReady2.TabIndex = 0;
            this.lblReady2.Text = "Bereit halten 2";
            this.lblReady2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReady1
            // 
            this.lblReady1.BackColor = System.Drawing.Color.Transparent;
            this.lblReady1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReady1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReady1.Location = new System.Drawing.Point(4, 0);
            this.lblReady1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReady1.Name = "lblReady1";
            this.lblReady1.Size = new System.Drawing.Size(388, 137);
            this.lblReady1.TabIndex = 0;
            this.lblReady1.Text = "Bereit halten 1";
            this.lblReady1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCount
            // 
            this.pnlCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(149)))));
            this.pnlCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCount.Controls.Add(this.tlpYellow);
            this.pnlCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCount.Location = new System.Drawing.Point(600, 0);
            this.pnlCount.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCount.Name = "pnlCount";
            this.pnlCount.Size = new System.Drawing.Size(400, 279);
            this.pnlCount.TabIndex = 2;
            this.pnlCount.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlCount_Paint);
            // 
            // tlpYellow
            // 
            this.tlpYellow.ColumnCount = 1;
            this.tlpYellow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpYellow.Controls.Add(this.lblCounting1, 0, 0);
            this.tlpYellow.Controls.Add(this.lblCounting2, 0, 1);
            this.tlpYellow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpYellow.Location = new System.Drawing.Point(0, 0);
            this.tlpYellow.Name = "tlpYellow";
            this.tlpYellow.RowCount = 2;
            this.tlpYellow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpYellow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpYellow.Size = new System.Drawing.Size(396, 275);
            this.tlpYellow.TabIndex = 3;
            // 
            // lblCounting1
            // 
            this.lblCounting1.BackColor = System.Drawing.Color.Transparent;
            this.lblCounting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCounting1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounting1.Location = new System.Drawing.Point(4, 0);
            this.lblCounting1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounting1.Name = "lblCounting1";
            this.lblCounting1.Size = new System.Drawing.Size(388, 137);
            this.lblCounting1.TabIndex = 2;
            this.lblCounting1.Text = "Zählen 1";
            this.lblCounting1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCounting2
            // 
            this.lblCounting2.BackColor = System.Drawing.Color.Transparent;
            this.lblCounting2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCounting2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounting2.Location = new System.Drawing.Point(4, 137);
            this.lblCounting2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounting2.Name = "lblCounting2";
            this.lblCounting2.Size = new System.Drawing.Size(388, 138);
            this.lblCounting2.TabIndex = 1;
            this.lblCounting2.Text = "Zählen 2";
            this.lblCounting2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPlay
            // 
            this.pnlPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlPlay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlay.Controls.Add(this.tlpGreen);
            this.pnlPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlay.Location = new System.Drawing.Point(1000, 0);
            this.pnlPlay.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPlay.Name = "pnlPlay";
            this.pnlPlay.Size = new System.Drawing.Size(400, 279);
            this.pnlPlay.TabIndex = 3;
            this.pnlPlay.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlPlay_Paint);
            // 
            // tlpGreen
            // 
            this.tlpGreen.ColumnCount = 1;
            this.tlpGreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGreen.Controls.Add(this.lblPlay2, 0, 1);
            this.tlpGreen.Controls.Add(this.lblPlay1, 0, 0);
            this.tlpGreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGreen.Location = new System.Drawing.Point(0, 0);
            this.tlpGreen.Name = "tlpGreen";
            this.tlpGreen.RowCount = 2;
            this.tlpGreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGreen.Size = new System.Drawing.Size(396, 275);
            this.tlpGreen.TabIndex = 3;
            // 
            // lblPlay2
            // 
            this.lblPlay2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay2.Location = new System.Drawing.Point(4, 137);
            this.lblPlay2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlay2.Name = "lblPlay2";
            this.lblPlay2.Size = new System.Drawing.Size(388, 138);
            this.lblPlay2.TabIndex = 1;
            this.lblPlay2.Text = "Spielen 2";
            this.lblPlay2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlay1
            // 
            this.lblPlay1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay1.Location = new System.Drawing.Point(4, 0);
            this.lblPlay1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlay1.Name = "lblPlay1";
            this.lblPlay1.Size = new System.Drawing.Size(388, 137);
            this.lblPlay1.TabIndex = 2;
            this.lblPlay1.Text = "Spielen 1";
            this.lblPlay1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpCourt
            // 
            this.tlpCourt.ColumnCount = 4;
            this.tlpCourt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpCourt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCourt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCourt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCourt.Controls.Add(this.lblCourtNumber, 0, 0);
            this.tlpCourt.Controls.Add(this.pnlPlay, 3, 0);
            this.tlpCourt.Controls.Add(this.pnlCount, 2, 0);
            this.tlpCourt.Controls.Add(this.pnlReady, 1, 0);
            this.tlpCourt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCourt.Location = new System.Drawing.Point(0, 0);
            this.tlpCourt.Name = "tlpCourt";
            this.tlpCourt.RowCount = 1;
            this.tlpCourt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCourt.Size = new System.Drawing.Size(1400, 279);
            this.tlpCourt.TabIndex = 4;
            // 
            // CourtDisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlpCourt);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(18, 18, 18, 30);
            this.Name = "CourtDisplayControl";
            this.Size = new System.Drawing.Size(1400, 279);
            this.pnlReady.ResumeLayout(false);
            this.tlpRed.ResumeLayout(false);
            this.pnlCount.ResumeLayout(false);
            this.tlpYellow.ResumeLayout(false);
            this.pnlPlay.ResumeLayout(false);
            this.tlpGreen.ResumeLayout(false);
            this.tlpCourt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCourtNumber;
        private System.Windows.Forms.Panel pnlReady;
        private System.Windows.Forms.Label lblReady2;
        private System.Windows.Forms.Label lblReady1;
        private System.Windows.Forms.Panel pnlCount;
        private System.Windows.Forms.Label lblCounting2;
        private System.Windows.Forms.Label lblCounting1;
        private System.Windows.Forms.Panel pnlPlay;
        private System.Windows.Forms.Label lblPlay2;
        private System.Windows.Forms.Label lblPlay1;
        private System.Windows.Forms.TableLayoutPanel tlpCourt;
        private System.Windows.Forms.TableLayoutPanel tlpRed;
        private System.Windows.Forms.TableLayoutPanel tlpYellow;
        private System.Windows.Forms.TableLayoutPanel tlpGreen;
    }
}
