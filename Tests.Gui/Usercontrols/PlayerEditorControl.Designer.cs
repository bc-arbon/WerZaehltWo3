namespace BCA.WerZaehltWo3.Tests.Gui.Usercontrols
{
    partial class PlayerEditorControl
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
            this.lblClub = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnNewPlayer = new System.Windows.Forms.Button();
            this.btnEditPlayer = new System.Windows.Forms.Button();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Location = new System.Drawing.Point(84, 35);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(56, 13);
            this.lblClub.TabIndex = 7;
            this.lblClub.Text = "Playerclub";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(84, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Playername";
            // 
            // btnNewPlayer
            // 
            this.btnNewPlayer.Location = new System.Drawing.Point(3, 1);
            this.btnNewPlayer.Name = "btnNewPlayer";
            this.btnNewPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnNewPlayer.TabIndex = 5;
            this.btnNewPlayer.Text = "New player";
            this.btnNewPlayer.UseVisualStyleBackColor = true;
            this.btnNewPlayer.Click += new System.EventHandler(this.BtnNewPlayer_Click);
            // 
            // btnEditPlayer
            // 
            this.btnEditPlayer.Location = new System.Drawing.Point(3, 30);
            this.btnEditPlayer.Name = "btnEditPlayer";
            this.btnEditPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnEditPlayer.TabIndex = 4;
            this.btnEditPlayer.Text = "Edit player";
            this.btnEditPlayer.UseVisualStyleBackColor = true;
            this.btnEditPlayer.Click += new System.EventHandler(this.BtnEditPlayer_Click);
            // 
            // btnPlayers
            // 
            this.btnPlayers.Location = new System.Drawing.Point(3, 59);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(143, 23);
            this.btnPlayers.TabIndex = 8;
            this.btnPlayers.Text = "Players...";
            this.btnPlayers.UseVisualStyleBackColor = true;
            this.btnPlayers.Click += new System.EventHandler(this.BtnPlayers_Click);
            // 
            // PlayerEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPlayers);
            this.Controls.Add(this.lblClub);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnNewPlayer);
            this.Controls.Add(this.btnEditPlayer);
            this.Name = "PlayerEditorControl";
            this.Size = new System.Drawing.Size(152, 101);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnNewPlayer;
        private System.Windows.Forms.Button btnEditPlayer;
        private System.Windows.Forms.Button btnPlayers;
    }
}
