namespace BCA.WerZaehltWo3.Forms
{
    partial class FrmBadmanImport
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
            this.btnGetPlayers = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenDatabase = new System.Windows.Forms.Button();
            this.cbxTournaments = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.ofdBadmanDatabase = new System.Windows.Forms.OpenFileDialog();
            this.bgwWorker = new System.ComponentModel.BackgroundWorker();
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
            this.lvwPlayers.Location = new System.Drawing.Point(11, 70);
            this.lvwPlayers.Name = "lvwPlayers";
            this.lvwPlayers.Size = new System.Drawing.Size(621, 321);
            this.lvwPlayers.TabIndex = 7;
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
            this.txtDatabaseFilepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatabaseFilepath.Location = new System.Drawing.Point(81, 14);
            this.txtDatabaseFilepath.Name = "txtDatabaseFilepath";
            this.txtDatabaseFilepath.Size = new System.Drawing.Size(380, 20);
            this.txtDatabaseFilepath.TabIndex = 6;
            // 
            // btnGetPlayers
            // 
            this.btnGetPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetPlayers.Enabled = false;
            this.btnGetPlayers.Location = new System.Drawing.Point(502, 41);
            this.btnGetPlayers.Name = "btnGetPlayers";
            this.btnGetPlayers.Size = new System.Drawing.Size(130, 23);
            this.btnGetPlayers.TabIndex = 3;
            this.btnGetPlayers.Text = "Teilnehmer anzeigen";
            this.btnGetPlayers.UseVisualStyleBackColor = true;
            this.btnGetPlayers.Click += new System.EventHandler(this.BtnGetPlayers_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(502, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(130, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Verbinden";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Datenbank:";
            // 
            // btnOpenDatabase
            // 
            this.btnOpenDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDatabase.Location = new System.Drawing.Point(467, 12);
            this.btnOpenDatabase.Name = "btnOpenDatabase";
            this.btnOpenDatabase.Size = new System.Drawing.Size(29, 23);
            this.btnOpenDatabase.TabIndex = 9;
            this.btnOpenDatabase.Text = "...";
            this.btnOpenDatabase.UseVisualStyleBackColor = true;
            this.btnOpenDatabase.Click += new System.EventHandler(this.BtnOpenDatabase_Click);
            // 
            // cbxTournaments
            // 
            this.cbxTournaments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTournaments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTournaments.Enabled = false;
            this.cbxTournaments.FormattingEnabled = true;
            this.cbxTournaments.Location = new System.Drawing.Point(81, 43);
            this.cbxTournaments.Name = "cbxTournaments";
            this.cbxTournaments.Size = new System.Drawing.Size(415, 21);
            this.cbxTournaments.Sorted = true;
            this.cbxTournaments.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Turnier:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(523, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnImport.Location = new System.Drawing.Point(408, 397);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(109, 23);
            this.btnImport.TabIndex = 12;
            this.btnImport.Text = "Importieren";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // ofdBadmanDatabase
            // 
            this.ofdBadmanDatabase.FileName = "Badman.mdb";
            this.ofdBadmanDatabase.Title = "Badman Datenbank auswählen";
            // 
            // bgwWorker
            // 
            this.bgwWorker.WorkerReportsProgress = true;
            this.bgwWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwWorker_DoWork);
            this.bgwWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwWorker_ProgressChanged);
            this.bgwWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwWorker_RunWorkerCompleted);
            // 
            // BadmanImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 431);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTournaments);
            this.Controls.Add(this.btnOpenDatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwPlayers);
            this.Controls.Add(this.txtDatabaseFilepath);
            this.Controls.Add(this.btnGetPlayers);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BadmanImportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aus Badman importieren";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BadmanImportForm_FormClosing);
            this.Load += new System.EventHandler(this.BadmanImportForm_Load);
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
        private System.Windows.Forms.Button btnGetPlayers;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenDatabase;
        private System.Windows.Forms.ComboBox cbxTournaments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.OpenFileDialog ofdBadmanDatabase;
        private System.ComponentModel.BackgroundWorker bgwWorker;
    }
}