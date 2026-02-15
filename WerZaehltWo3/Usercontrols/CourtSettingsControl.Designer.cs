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
            this.LblCourtNumber = new System.Windows.Forms.Label();
            this.TxtReady1 = new System.Windows.Forms.TextBox();
            this.TxtReady2 = new System.Windows.Forms.TextBox();
            this.TxtCount1 = new System.Windows.Forms.TextBox();
            this.TxtCount2 = new System.Windows.Forms.TextBox();
            this.TxtPlay1 = new System.Windows.Forms.TextBox();
            this.TxtPlay2 = new System.Windows.Forms.TextBox();
            this.BtnUndo = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnMove = new System.Windows.Forms.Button();
            this.BtnApply = new System.Windows.Forms.Button();
            this.ttpButtons = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // LblCourtNumber
            // 
            this.LblCourtNumber.AutoSize = true;
            this.LblCourtNumber.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCourtNumber.Location = new System.Drawing.Point(10, 12);
            this.LblCourtNumber.Name = "LblCourtNumber";
            this.LblCourtNumber.Size = new System.Drawing.Size(31, 32);
            this.LblCourtNumber.TabIndex = 0;
            this.LblCourtNumber.Text = "0";
            // 
            // TxtReady1
            // 
            this.TxtReady1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtReady1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtReady1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.TxtReady1.Location = new System.Drawing.Point(60, 3);
            this.TxtReady1.Name = "TxtReady1";
            this.TxtReady1.Size = new System.Drawing.Size(136, 20);
            this.TxtReady1.TabIndex = 0;
            this.TxtReady1.TextChanged += new System.EventHandler(this.Txtboxes_TextChanged);
            // 
            // TxtReady2
            // 
            this.TxtReady2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtReady2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtReady2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.TxtReady2.Location = new System.Drawing.Point(60, 31);
            this.TxtReady2.Name = "TxtReady2";
            this.TxtReady2.Size = new System.Drawing.Size(136, 20);
            this.TxtReady2.TabIndex = 1;
            this.TxtReady2.TextChanged += new System.EventHandler(this.Txtboxes_TextChanged);
            // 
            // TxtCount1
            // 
            this.TxtCount1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtCount1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtCount1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(149)))));
            this.TxtCount1.Location = new System.Drawing.Point(202, 3);
            this.TxtCount1.Name = "TxtCount1";
            this.TxtCount1.Size = new System.Drawing.Size(136, 20);
            this.TxtCount1.TabIndex = 2;
            this.TxtCount1.TextChanged += new System.EventHandler(this.Txtboxes_TextChanged);
            // 
            // TxtCount2
            // 
            this.TxtCount2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtCount2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtCount2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(149)))));
            this.TxtCount2.Location = new System.Drawing.Point(202, 31);
            this.TxtCount2.Name = "TxtCount2";
            this.TxtCount2.Size = new System.Drawing.Size(136, 20);
            this.TxtCount2.TabIndex = 3;
            this.TxtCount2.TextChanged += new System.EventHandler(this.Txtboxes_TextChanged);
            // 
            // TxtPlay1
            // 
            this.TxtPlay1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtPlay1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtPlay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtPlay1.Location = new System.Drawing.Point(344, 3);
            this.TxtPlay1.Name = "TxtPlay1";
            this.TxtPlay1.Size = new System.Drawing.Size(136, 20);
            this.TxtPlay1.TabIndex = 4;
            this.TxtPlay1.TextChanged += new System.EventHandler(this.Txtboxes_TextChanged);
            // 
            // TxtPlay2
            // 
            this.TxtPlay2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtPlay2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtPlay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtPlay2.Location = new System.Drawing.Point(344, 31);
            this.TxtPlay2.Name = "TxtPlay2";
            this.TxtPlay2.Size = new System.Drawing.Size(136, 20);
            this.TxtPlay2.TabIndex = 5;
            this.TxtPlay2.TextChanged += new System.EventHandler(this.Txtboxes_TextChanged);
            // 
            // BtnUndo
            // 
            this.BtnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUndo.BackgroundImage = global::BCA.WerZaehltWo3.Properties.Resources.Undo;
            this.BtnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnUndo.Enabled = false;
            this.BtnUndo.Location = new System.Drawing.Point(490, -1);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(27, 27);
            this.BtnUndo.TabIndex = 6;
            this.ttpButtons.SetToolTip(this.BtnUndo, "Rückgängig");
            this.BtnUndo.UseVisualStyleBackColor = true;
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.BackgroundImage = global::BCA.WerZaehltWo3.Properties.Resources.Clear;
            this.BtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnClear.Location = new System.Drawing.Point(490, 27);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(27, 27);
            this.BtnClear.TabIndex = 8;
            this.ttpButtons.SetToolTip(this.BtnClear, "Alles löschen");
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnMove
            // 
            this.BtnMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMove.BackgroundImage = global::BCA.WerZaehltWo3.Properties.Resources.Move;
            this.BtnMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMove.Location = new System.Drawing.Point(523, -1);
            this.BtnMove.Name = "BtnMove";
            this.BtnMove.Size = new System.Drawing.Size(27, 27);
            this.BtnMove.TabIndex = 7;
            this.ttpButtons.SetToolTip(this.BtnMove, "Spieler nach rechts schieben");
            this.BtnMove.UseVisualStyleBackColor = true;
            this.BtnMove.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // BtnApply
            // 
            this.BtnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnApply.BackgroundImage = global::BCA.WerZaehltWo3.Properties.Resources.Apply;
            this.BtnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnApply.Location = new System.Drawing.Point(523, 27);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(27, 27);
            this.BtnApply.TabIndex = 9;
            this.ttpButtons.SetToolTip(this.BtnApply, "Text auf Display übertragen");
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // CourtSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.BtnUndo);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnMove);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.TxtPlay2);
            this.Controls.Add(this.TxtCount2);
            this.Controls.Add(this.TxtReady2);
            this.Controls.Add(this.TxtPlay1);
            this.Controls.Add(this.TxtCount1);
            this.Controls.Add(this.TxtReady1);
            this.Controls.Add(this.LblCourtNumber);
            this.Name = "CourtSettingsControl";
            this.Size = new System.Drawing.Size(565, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCourtNumber;
        private System.Windows.Forms.TextBox TxtReady1;
        private System.Windows.Forms.TextBox TxtReady2;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TxtCount1;
        private System.Windows.Forms.TextBox TxtCount2;
        private System.Windows.Forms.TextBox TxtPlay1;
        private System.Windows.Forms.TextBox TxtPlay2;
        private System.Windows.Forms.Button BtnMove;
        private System.Windows.Forms.Button BtnUndo;
        private System.Windows.Forms.ToolTip ttpButtons;
    }
}
