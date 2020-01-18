namespace BCA.WerZaehltWo3.Tests.Gui.Usercontrols
{
    partial class CourtCountControl
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
            this.btnCourtCount = new System.Windows.Forms.Button();
            this.lblCourtCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCourtCount
            // 
            this.btnCourtCount.Location = new System.Drawing.Point(55, 5);
            this.btnCourtCount.Name = "btnCourtCount";
            this.btnCourtCount.Size = new System.Drawing.Size(75, 23);
            this.btnCourtCount.TabIndex = 0;
            this.btnCourtCount.Text = "CourtCount";
            this.btnCourtCount.UseVisualStyleBackColor = true;
            this.btnCourtCount.Click += new System.EventHandler(this.BtnCourtCount_Click);
            // 
            // lblCourtCount
            // 
            this.lblCourtCount.AutoSize = true;
            this.lblCourtCount.Location = new System.Drawing.Point(3, 10);
            this.lblCourtCount.Name = "lblCourtCount";
            this.lblCourtCount.Size = new System.Drawing.Size(13, 13);
            this.lblCourtCount.TabIndex = 1;
            this.lblCourtCount.Text = "0";
            // 
            // CourtCountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCourtCount);
            this.Controls.Add(this.btnCourtCount);
            this.Name = "CourtCountControl";
            this.Size = new System.Drawing.Size(150, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCourtCount;
        private System.Windows.Forms.Label lblCourtCount;
    }
}
