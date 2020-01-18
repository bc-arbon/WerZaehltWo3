namespace BCA.WerZaehltWo3.Tests.Gui.Forms
{
    partial class FrmTsDatabaseTest
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
            this.lvwPlayers = new System.Windows.Forms.ListView();
            this.chrId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chrName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chrClub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chrCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDatabaseFilepath = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnGetPlayers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwPlayers
            // 
            this.lvwPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chrId,
            this.chrName,
            this.chrClub,
            this.chrCategory});
            this.lvwPlayers.HideSelection = false;
            this.lvwPlayers.Location = new System.Drawing.Point(12, 71);
            this.lvwPlayers.Name = "lvwPlayers";
            this.lvwPlayers.Size = new System.Drawing.Size(519, 321);
            this.lvwPlayers.TabIndex = 6;
            this.lvwPlayers.UseCompatibleStateImageBehavior = false;
            this.lvwPlayers.View = System.Windows.Forms.View.Details;
            // 
            // chrId
            // 
            this.chrId.Text = "Id";
            // 
            // chrName
            // 
            this.chrName.Text = "Name";
            this.chrName.Width = 125;
            // 
            // chrClub
            // 
            this.chrClub.Text = "Club";
            this.chrClub.Width = 129;
            // 
            // chrCategory
            // 
            this.chrCategory.Text = "Category";
            this.chrCategory.Width = 111;
            // 
            // txtDatabaseFilepath
            // 
            this.txtDatabaseFilepath.Location = new System.Drawing.Point(149, 15);
            this.txtDatabaseFilepath.Name = "txtDatabaseFilepath";
            this.txtDatabaseFilepath.Size = new System.Drawing.Size(382, 20);
            this.txtDatabaseFilepath.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(13, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(130, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnGetPlayers
            // 
            this.btnGetPlayers.Location = new System.Drawing.Point(13, 42);
            this.btnGetPlayers.Name = "btnGetPlayers";
            this.btnGetPlayers.Size = new System.Drawing.Size(518, 23);
            this.btnGetPlayers.TabIndex = 4;
            this.btnGetPlayers.Text = "Get Players";
            this.btnGetPlayers.UseVisualStyleBackColor = true;
            this.btnGetPlayers.Click += new System.EventHandler(this.BtnGetPlayers_Click);
            // 
            // FrmTsDatabaseTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 404);
            this.Controls.Add(this.lvwPlayers);
            this.Controls.Add(this.txtDatabaseFilepath);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnGetPlayers);
            this.Name = "FrmTsDatabaseTest";
            this.Text = "FrmTsDatabaseTest";
            this.Load += new System.EventHandler(this.TsDatabaseTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwPlayers;
        private System.Windows.Forms.ColumnHeader chrId;
        private System.Windows.Forms.ColumnHeader chrName;
        private System.Windows.Forms.ColumnHeader chrClub;
        private System.Windows.Forms.ColumnHeader chrCategory;
        private System.Windows.Forms.TextBox txtDatabaseFilepath;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnGetPlayers;
    }
}