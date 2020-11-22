namespace BCA.WerZaehltWo3.Forms
{
    partial class FrmPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlayer));
            this.lvwPlayers = new System.Windows.Forms.ListView();
            this.chrId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chrName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chrCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chrClub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnImportBadman = new System.Windows.Forms.Button();
            this.btnImportTs = new System.Windows.Forms.Button();
            this.lblImport = new System.Windows.Forms.Label();
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
            this.chrCategory,
            this.chrClub});
            this.lvwPlayers.FullRowSelect = true;
            this.lvwPlayers.HideSelection = false;
            this.lvwPlayers.Location = new System.Drawing.Point(12, 12);
            this.lvwPlayers.Name = "lvwPlayers";
            this.lvwPlayers.Size = new System.Drawing.Size(624, 323);
            this.lvwPlayers.TabIndex = 0;
            this.lvwPlayers.UseCompatibleStateImageBehavior = false;
            this.lvwPlayers.View = System.Windows.Forms.View.Details;
            this.lvwPlayers.DoubleClick += new System.EventHandler(this.LvwPlayers_DoubleClick);
            // 
            // chrId
            // 
            this.chrId.Text = "Id";
            // 
            // chrName
            // 
            this.chrName.Text = "Name";
            this.chrName.Width = 168;
            // 
            // chrCategory
            // 
            this.chrCategory.Text = "Kategorie";
            this.chrCategory.Width = 80;
            // 
            // chrClub
            // 
            this.chrClub.Text = "Club";
            this.chrClub.Width = 180;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(561, 341);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNew.Location = new System.Drawing.Point(12, 341);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Neu...";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(93, 341);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Bearbeiten...";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(174, 341);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnImportBadman
            // 
            this.btnImportBadman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportBadman.Location = new System.Drawing.Point(330, 341);
            this.btnImportBadman.Name = "btnImportBadman";
            this.btnImportBadman.Size = new System.Drawing.Size(77, 23);
            this.btnImportBadman.TabIndex = 3;
            this.btnImportBadman.Text = "Badman...";
            this.btnImportBadman.UseVisualStyleBackColor = true;
            this.btnImportBadman.Click += new System.EventHandler(this.BtnImportBadman_Click);
            // 
            // btnImportTs
            // 
            this.btnImportTs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportTs.Location = new System.Drawing.Point(413, 341);
            this.btnImportTs.Name = "btnImportTs";
            this.btnImportTs.Size = new System.Drawing.Size(122, 23);
            this.btnImportTs.TabIndex = 4;
            this.btnImportTs.Text = "Tournamentsoftware...";
            this.btnImportTs.UseVisualStyleBackColor = true;
            this.btnImportTs.Click += new System.EventHandler(this.BtnImportTs_Click);
            // 
            // lblImport
            // 
            this.lblImport.AutoSize = true;
            this.lblImport.Location = new System.Drawing.Point(289, 346);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(39, 13);
            this.lblImport.TabIndex = 5;
            this.lblImport.Text = "Import:";
            // 
            // FrmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 376);
            this.Controls.Add(this.lblImport);
            this.Controls.Add(this.btnImportTs);
            this.Controls.Add(this.btnImportBadman);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvwPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spieler";
            this.Load += new System.EventHandler(this.PlayerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwPlayers;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader chrName;
        private System.Windows.Forms.ColumnHeader chrCategory;
        private System.Windows.Forms.ColumnHeader chrClub;
        private System.Windows.Forms.ColumnHeader chrId;
        private System.Windows.Forms.Button btnImportBadman;
        private System.Windows.Forms.Button btnImportTs;
        private System.Windows.Forms.Label lblImport;
    }
}