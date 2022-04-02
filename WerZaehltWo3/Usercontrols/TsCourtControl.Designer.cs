namespace BCA.WerZaehltWo3.Usercontrols
{
    partial class TsCourtControl
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
            this.components = new System.ComponentModel.Container();
            this.BtnApplyPlay = new System.Windows.Forms.Button();
            this.txtPlay2 = new System.Windows.Forms.TextBox();
            this.txtCount2 = new System.Windows.Forms.TextBox();
            this.txtReady2 = new System.Windows.Forms.TextBox();
            this.txtPlay1 = new System.Windows.Forms.TextBox();
            this.txtCount1 = new System.Windows.Forms.TextBox();
            this.txtReady1 = new System.Windows.Forms.TextBox();
            this.lblCourtNumber = new System.Windows.Forms.Label();
            this.ttpButtons = new System.Windows.Forms.ToolTip(this.components);
            this.BtnApplyCount = new System.Windows.Forms.Button();
            this.BtnApplyReady = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnApplyPlay
            // 
            this.BtnApplyPlay.BackgroundImage = global::BCA.WerZaehltWo3.Properties.Resources.Apply;
            this.BtnApplyPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnApplyPlay.Location = new System.Drawing.Point(572, 16);
            this.BtnApplyPlay.Name = "BtnApplyPlay";
            this.BtnApplyPlay.Size = new System.Drawing.Size(27, 27);
            this.BtnApplyPlay.TabIndex = 20;
            this.ttpButtons.SetToolTip(this.BtnApplyPlay, "Text auf Display übertragen");
            this.BtnApplyPlay.UseVisualStyleBackColor = true;
            this.BtnApplyPlay.Click += new System.EventHandler(this.BtnApplyPlay_Click);
            // 
            // txtPlay2
            // 
            this.txtPlay2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPlay2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPlay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPlay2.Location = new System.Drawing.Point(430, 35);
            this.txtPlay2.Name = "txtPlay2";
            this.txtPlay2.Size = new System.Drawing.Size(136, 20);
            this.txtPlay2.TabIndex = 16;
            // 
            // txtCount2
            // 
            this.txtCount2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCount2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCount2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(149)))));
            this.txtCount2.Location = new System.Drawing.Point(242, 35);
            this.txtCount2.Name = "txtCount2";
            this.txtCount2.Size = new System.Drawing.Size(136, 20);
            this.txtCount2.TabIndex = 14;
            // 
            // txtReady2
            // 
            this.txtReady2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtReady2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtReady2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.txtReady2.Location = new System.Drawing.Point(53, 35);
            this.txtReady2.Name = "txtReady2";
            this.txtReady2.Size = new System.Drawing.Size(136, 20);
            this.txtReady2.TabIndex = 12;
            // 
            // txtPlay1
            // 
            this.txtPlay1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPlay1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPlay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPlay1.Location = new System.Drawing.Point(430, 7);
            this.txtPlay1.Name = "txtPlay1";
            this.txtPlay1.Size = new System.Drawing.Size(136, 20);
            this.txtPlay1.TabIndex = 15;
            // 
            // txtCount1
            // 
            this.txtCount1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCount1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCount1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(149)))));
            this.txtCount1.Location = new System.Drawing.Point(242, 7);
            this.txtCount1.Name = "txtCount1";
            this.txtCount1.Size = new System.Drawing.Size(136, 20);
            this.txtCount1.TabIndex = 13;
            // 
            // txtReady1
            // 
            this.txtReady1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtReady1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtReady1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.txtReady1.Location = new System.Drawing.Point(53, 7);
            this.txtReady1.Name = "txtReady1";
            this.txtReady1.Size = new System.Drawing.Size(136, 20);
            this.txtReady1.TabIndex = 10;
            // 
            // lblCourtNumber
            // 
            this.lblCourtNumber.AutoSize = true;
            this.lblCourtNumber.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourtNumber.Location = new System.Drawing.Point(3, 16);
            this.lblCourtNumber.Name = "lblCourtNumber";
            this.lblCourtNumber.Size = new System.Drawing.Size(31, 32);
            this.lblCourtNumber.TabIndex = 11;
            this.lblCourtNumber.Text = "0";
            // 
            // BtnApplyCount
            // 
            this.BtnApplyCount.BackgroundImage = global::BCA.WerZaehltWo3.Properties.Resources.Apply;
            this.BtnApplyCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnApplyCount.Location = new System.Drawing.Point(384, 16);
            this.BtnApplyCount.Name = "BtnApplyCount";
            this.BtnApplyCount.Size = new System.Drawing.Size(27, 27);
            this.BtnApplyCount.TabIndex = 21;
            this.ttpButtons.SetToolTip(this.BtnApplyCount, "Text auf Display übertragen");
            this.BtnApplyCount.UseVisualStyleBackColor = true;
            this.BtnApplyCount.Click += new System.EventHandler(this.BtnApplyCount_Click);
            // 
            // BtnApplyReady
            // 
            this.BtnApplyReady.BackgroundImage = global::BCA.WerZaehltWo3.Properties.Resources.Apply;
            this.BtnApplyReady.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnApplyReady.Location = new System.Drawing.Point(195, 16);
            this.BtnApplyReady.Name = "BtnApplyReady";
            this.BtnApplyReady.Size = new System.Drawing.Size(27, 27);
            this.BtnApplyReady.TabIndex = 22;
            this.ttpButtons.SetToolTip(this.BtnApplyReady, "Text auf Display übertragen");
            this.BtnApplyReady.UseVisualStyleBackColor = true;
            this.BtnApplyReady.Click += new System.EventHandler(this.BtnApplyReady_Click);
            // 
            // TsCourtControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnApplyReady);
            this.Controls.Add(this.BtnApplyCount);
            this.Controls.Add(this.BtnApplyPlay);
            this.Controls.Add(this.txtPlay2);
            this.Controls.Add(this.txtCount2);
            this.Controls.Add(this.txtReady2);
            this.Controls.Add(this.txtPlay1);
            this.Controls.Add(this.txtCount1);
            this.Controls.Add(this.txtReady1);
            this.Controls.Add(this.lblCourtNumber);
            this.Name = "TsCourtControl";
            this.Size = new System.Drawing.Size(613, 63);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnApplyPlay;
        private System.Windows.Forms.ToolTip ttpButtons;
        private System.Windows.Forms.TextBox txtPlay2;
        private System.Windows.Forms.TextBox txtCount2;
        private System.Windows.Forms.TextBox txtReady2;
        private System.Windows.Forms.TextBox txtPlay1;
        private System.Windows.Forms.TextBox txtCount1;
        private System.Windows.Forms.TextBox txtReady1;
        private System.Windows.Forms.Label lblCourtNumber;
        private System.Windows.Forms.Button BtnApplyCount;
        private System.Windows.Forms.Button BtnApplyReady;
    }
}
