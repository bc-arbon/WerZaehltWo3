namespace BCA.WerZaehltWo3.Usercontrols
{
    partial class CourtSettingsControl
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
            this.lblCourtNumber = new System.Windows.Forms.Label();
            this.txtReady1 = new System.Windows.Forms.TextBox();
            this.txtReady2 = new System.Windows.Forms.TextBox();
            this.txtCount1 = new System.Windows.Forms.TextBox();
            this.txtCount2 = new System.Windows.Forms.TextBox();
            this.txtPlay1 = new System.Windows.Forms.TextBox();
            this.txtPlay2 = new System.Windows.Forms.TextBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.ttpButtons = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblCourtNumber
            // 
            this.lblCourtNumber.AutoSize = true;
            this.lblCourtNumber.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourtNumber.Location = new System.Drawing.Point(10, 12);
            this.lblCourtNumber.Name = "lblCourtNumber";
            this.lblCourtNumber.Size = new System.Drawing.Size(32, 32);
            this.lblCourtNumber.TabIndex = 0;
            this.lblCourtNumber.Text = "0";
            // 
            // txtReady1
            // 
            this.txtReady1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtReady1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtReady1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.txtReady1.Location = new System.Drawing.Point(60, 3);
            this.txtReady1.Name = "txtReady1";
            this.txtReady1.Size = new System.Drawing.Size(136, 20);
            this.txtReady1.TabIndex = 0;
            // 
            // txtReady2
            // 
            this.txtReady2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtReady2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtReady2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.txtReady2.Location = new System.Drawing.Point(60, 31);
            this.txtReady2.Name = "txtReady2";
            this.txtReady2.Size = new System.Drawing.Size(136, 20);
            this.txtReady2.TabIndex = 1;
            // 
            // txtCount1
            // 
            this.txtCount1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCount1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCount1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(149)))));
            this.txtCount1.Location = new System.Drawing.Point(202, 3);
            this.txtCount1.Name = "txtCount1";
            this.txtCount1.Size = new System.Drawing.Size(136, 20);
            this.txtCount1.TabIndex = 2;
            // 
            // txtCount2
            // 
            this.txtCount2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCount2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCount2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(149)))));
            this.txtCount2.Location = new System.Drawing.Point(202, 31);
            this.txtCount2.Name = "txtCount2";
            this.txtCount2.Size = new System.Drawing.Size(136, 20);
            this.txtCount2.TabIndex = 3;
            // 
            // txtPlay1
            // 
            this.txtPlay1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPlay1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPlay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPlay1.Location = new System.Drawing.Point(344, 3);
            this.txtPlay1.Name = "txtPlay1";
            this.txtPlay1.Size = new System.Drawing.Size(136, 20);
            this.txtPlay1.TabIndex = 4;
            // 
            // txtPlay2
            // 
            this.txtPlay2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPlay2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPlay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPlay2.Location = new System.Drawing.Point(344, 31);
            this.txtPlay2.Name = "txtPlay2";
            this.txtPlay2.Size = new System.Drawing.Size(136, 20);
            this.txtPlay2.TabIndex = 5;
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo.BackgroundImage = global::BCA.WerZaehltWo3.Properties.Resources.Undo;
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUndo.Enabled = false;
            this.btnUndo.Location = new System.Drawing.Point(490, -1);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(27, 27);
            this.btnUndo.TabIndex = 6;
            this.ttpButtons.SetToolTip(this.btnUndo, "Rückgängig");
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackgroundImage = global::BCA.WerZaehltWo3.Properties.Resources.Clear;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Location = new System.Drawing.Point(490, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(27, 27);
            this.btnClear.TabIndex = 8;
            this.ttpButtons.SetToolTip(this.btnClear, "Alles löschen");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnMove
            // 
            this.btnMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMove.BackgroundImage = global::BCA.WerZaehltWo3.Properties.Resources.Move;
            this.btnMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMove.Location = new System.Drawing.Point(523, -1);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(27, 27);
            this.btnMove.TabIndex = 7;
            this.ttpButtons.SetToolTip(this.btnMove, "Spieler nach rechts schieben");
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BackgroundImage = global::BCA.WerZaehltWo3.Properties.Resources.Apply;
            this.btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnApply.Location = new System.Drawing.Point(523, 27);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(27, 27);
            this.btnApply.TabIndex = 9;
            this.ttpButtons.SetToolTip(this.btnApply, "Text auf Display übertragen");
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // CourtSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtPlay2);
            this.Controls.Add(this.txtCount2);
            this.Controls.Add(this.txtReady2);
            this.Controls.Add(this.txtPlay1);
            this.Controls.Add(this.txtCount1);
            this.Controls.Add(this.txtReady1);
            this.Controls.Add(this.lblCourtNumber);
            this.Name = "CourtSettingsControl";
            this.Size = new System.Drawing.Size(565, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourtNumber;
        private System.Windows.Forms.TextBox txtReady1;
        private System.Windows.Forms.TextBox txtReady2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtCount1;
        private System.Windows.Forms.TextBox txtCount2;
        private System.Windows.Forms.TextBox txtPlay1;
        private System.Windows.Forms.TextBox txtPlay2;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.ToolTip ttpButtons;
    }
}
