namespace BCA.WerZaehltWo3.Forms
{
    partial class FrmTsData
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
            this.PnlControls = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.TxtRabbitPassword = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtRabbitVhost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtRabbitUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRabbitServer = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlControls
            // 
            this.PnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlControls.Location = new System.Drawing.Point(12, 70);
            this.PnlControls.Name = "PnlControls";
            this.PnlControls.Size = new System.Drawing.Size(751, 348);
            this.PnlControls.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnConnect);
            this.groupBox1.Controls.Add(this.TxtRabbitPassword);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtRabbitVhost);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtRabbitUser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtRabbitServer);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 52);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konfiguration";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConnect.Location = new System.Drawing.Point(659, 17);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(86, 23);
            this.BtnConnect.TabIndex = 22;
            this.BtnConnect.Text = "Verbinden";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // TxtRabbitPassword
            // 
            this.TxtRabbitPassword.Location = new System.Drawing.Point(533, 19);
            this.TxtRabbitPassword.Name = "TxtRabbitPassword";
            this.TxtRabbitPassword.Size = new System.Drawing.Size(120, 20);
            this.TxtRabbitPassword.TabIndex = 21;
            this.TxtRabbitPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Vhost:";
            // 
            // TxtRabbitVhost
            // 
            this.TxtRabbitVhost.Location = new System.Drawing.Point(214, 19);
            this.TxtRabbitVhost.Name = "TxtRabbitVhost";
            this.TxtRabbitVhost.Size = new System.Drawing.Size(84, 20);
            this.TxtRabbitVhost.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Passwort:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "User:";
            // 
            // TxtRabbitUser
            // 
            this.TxtRabbitUser.Location = new System.Drawing.Point(346, 19);
            this.TxtRabbitUser.Name = "TxtRabbitUser";
            this.TxtRabbitUser.Size = new System.Drawing.Size(121, 20);
            this.TxtRabbitUser.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Server:";
            // 
            // TxtRabbitServer
            // 
            this.TxtRabbitServer.Location = new System.Drawing.Point(47, 19);
            this.TxtRabbitServer.Name = "TxtRabbitServer";
            this.TxtRabbitServer.Size = new System.Drawing.Size(118, 20);
            this.TxtRabbitServer.TabIndex = 11;
            // 
            // FrmTsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PnlControls);
            this.Name = "FrmTsData";
            this.Text = "FrmTsData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTsData_FormClosing);
            this.Load += new System.EventHandler(this.FrmTsData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PnlControls;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.MaskedTextBox TxtRabbitPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtRabbitVhost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtRabbitUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtRabbitServer;
    }
}