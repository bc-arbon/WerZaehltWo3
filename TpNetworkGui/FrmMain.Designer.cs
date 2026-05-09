namespace TpNetworkGui
{
    partial class FrmMain
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
            label1 = new Label();
            TxtIp = new TextBox();
            label2 = new Label();
            TxtPassword = new TextBox();
            BtnLogin = new Button();
            BtnUpdate = new Button();
            CbxDraws = new ComboBox();
            label3 = new Label();
            listView1 = new ListView();
            ChrRank = new ColumnHeader();
            ChrPlanning = new ColumnHeader();
            ChrName = new ColumnHeader();
            ChrClub = new ColumnHeader();
            ChrPlayed = new ColumnHeader();
            ChrWon = new ColumnHeader();
            ChrBhz = new ColumnHeader();
            ChrSets = new ColumnHeader();
            ChrGames = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "IP:";
            // 
            // TxtIp
            // 
            TxtIp.Location = new Point(38, 6);
            TxtIp.Name = "TxtIp";
            TxtIp.Size = new Size(100, 23);
            TxtIp.TabIndex = 1;
            TxtIp.Text = "192.168.10.146";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 9);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Passwort:";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(207, 6);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(100, 23);
            TxtPassword.TabIndex = 3;
            TxtPassword.Text = "1234";
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(313, 6);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(75, 23);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(394, 6);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(75, 23);
            BtnUpdate.TabIndex = 9;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // CbxDraws
            // 
            CbxDraws.DisplayMember = "Name";
            CbxDraws.DropDownStyle = ComboBoxStyle.DropDownList;
            CbxDraws.FormattingEnabled = true;
            CbxDraws.Location = new Point(60, 50);
            CbxDraws.Name = "CbxDraws";
            CbxDraws.Size = new Size(155, 23);
            CbxDraws.Sorted = true;
            CbxDraws.TabIndex = 10;
            CbxDraws.SelectedIndexChanged += CbxDraws_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 53);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 11;
            label3.Text = "Draws:";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { ChrRank, ChrPlanning, ChrName, ChrClub, ChrPlayed, ChrWon, ChrBhz, ChrSets, ChrGames });
            listView1.Location = new Point(12, 79);
            listView1.Name = "listView1";
            listView1.Size = new Size(767, 364);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ChrRank
            // 
            ChrRank.Text = "Rang";
            // 
            // ChrPlanning
            // 
            ChrPlanning.Text = "Plannung";
            ChrPlanning.Width = 80;
            // 
            // ChrName
            // 
            ChrName.Text = "Name";
            ChrName.Width = 80;
            // 
            // ChrClub
            // 
            ChrClub.Text = "Club";
            // 
            // ChrPlayed
            // 
            ChrPlayed.Text = "Played";
            // 
            // ChrWon
            // 
            ChrWon.Text = "Won";
            // 
            // ChrBhz
            // 
            ChrBhz.Text = "BHZ";
            // 
            // ChrSets
            // 
            ChrSets.Text = "Sets";
            // 
            // ChrGames
            // 
            ChrGames.Text = "Games";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 455);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(CbxDraws);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPassword);
            Controls.Add(label2);
            Controls.Add(TxtIp);
            Controls.Add(label1);
            Name = "FrmMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtIp;
        private Label label2;
        private TextBox TxtPassword;
        private Button BtnLogin;
        private Button BtnUpdate;
        private ComboBox CbxDraws;
        private Label label3;
        private ListView listView1;
        private ColumnHeader ChrRank;
        private ColumnHeader ChrPlanning;
        private ColumnHeader ChrName;
        private ColumnHeader ChrClub;
        private ColumnHeader ChrPlayed;
        private ColumnHeader ChrWon;
        private ColumnHeader ChrBhz;
        private ColumnHeader ChrSets;
        private ColumnHeader ChrGames;
    }
}
