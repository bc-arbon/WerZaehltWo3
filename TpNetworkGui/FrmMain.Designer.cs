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
            label3 = new Label();
            label4 = new Label();
            TxtUnicode = new TextBox();
            TxtRequest = new TextBox();
            label5 = new Label();
            TxtResponse = new TextBox();
            BtnUpdate = new Button();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 50);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 5;
            label3.Text = "Request:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 11);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 6;
            label4.Text = "Unicode:";
            // 
            // TxtUnicode
            // 
            TxtUnicode.Location = new Point(514, 6);
            TxtUnicode.Name = "TxtUnicode";
            TxtUnicode.Size = new Size(243, 23);
            TxtUnicode.TabIndex = 7;
            // 
            // TxtRequest
            // 
            TxtRequest.Location = new Point(12, 68);
            TxtRequest.Multiline = true;
            TxtRequest.Name = "TxtRequest";
            TxtRequest.Size = new Size(376, 375);
            TxtRequest.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(400, 50);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 5;
            label5.Text = "Response:";
            // 
            // TxtResponse
            // 
            TxtResponse.Location = new Point(400, 68);
            TxtResponse.Multiline = true;
            TxtResponse.Name = "TxtResponse";
            TxtResponse.Size = new Size(376, 375);
            TxtResponse.TabIndex = 8;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(313, 39);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(75, 23);
            BtnUpdate.TabIndex = 9;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 455);
            Controls.Add(BtnUpdate);
            Controls.Add(TxtResponse);
            Controls.Add(TxtRequest);
            Controls.Add(TxtUnicode);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private TextBox TxtUnicode;
        private TextBox TxtRequest;
        private Label label5;
        private TextBox TxtResponse;
        private Button BtnUpdate;
    }
}
