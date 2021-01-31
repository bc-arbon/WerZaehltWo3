namespace BCA.WerZaehltWo3.Tests.Gui.Forms
{
    partial class FrmMain
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
            this.btnTsTest = new System.Windows.Forms.Button();
            this.btnBadmanTest = new System.Windows.Forms.Button();
            this.courtCountControl1 = new BCA.WerZaehltWo3.Tests.Gui.Usercontrols.CourtCountControl();
            this.playerEditorControl1 = new BCA.WerZaehltWo3.Tests.Gui.Usercontrols.PlayerEditorControl();
            this.btnJsonTest = new System.Windows.Forms.Button();
            this.btnTsPlanningTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTsTest
            // 
            this.btnTsTest.Location = new System.Drawing.Point(12, 148);
            this.btnTsTest.Name = "btnTsTest";
            this.btnTsTest.Size = new System.Drawing.Size(142, 23);
            this.btnTsTest.TabIndex = 5;
            this.btnTsTest.Text = "TS Databse Test";
            this.btnTsTest.UseVisualStyleBackColor = true;
            this.btnTsTest.Click += new System.EventHandler(this.btnTsTest_Click);
            // 
            // btnBadmanTest
            // 
            this.btnBadmanTest.Location = new System.Drawing.Point(12, 119);
            this.btnBadmanTest.Name = "btnBadmanTest";
            this.btnBadmanTest.Size = new System.Drawing.Size(142, 23);
            this.btnBadmanTest.TabIndex = 4;
            this.btnBadmanTest.Text = "Badman Database Test";
            this.btnBadmanTest.UseVisualStyleBackColor = true;
            // 
            // courtCountControl1
            // 
            this.courtCountControl1.Location = new System.Drawing.Point(188, 12);
            this.courtCountControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courtCountControl1.Name = "courtCountControl1";
            this.courtCountControl1.Size = new System.Drawing.Size(150, 43);
            this.courtCountControl1.TabIndex = 6;
            // 
            // playerEditorControl1
            // 
            this.playerEditorControl1.Location = new System.Drawing.Point(12, 12);
            this.playerEditorControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerEditorControl1.Name = "playerEditorControl1";
            this.playerEditorControl1.Size = new System.Drawing.Size(152, 101);
            this.playerEditorControl1.TabIndex = 7;
            // 
            // btnJsonTest
            // 
            this.btnJsonTest.Location = new System.Drawing.Point(242, 62);
            this.btnJsonTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJsonTest.Name = "btnJsonTest";
            this.btnJsonTest.Size = new System.Drawing.Size(75, 23);
            this.btnJsonTest.TabIndex = 8;
            this.btnJsonTest.Text = "Json Test";
            this.btnJsonTest.UseVisualStyleBackColor = true;
            this.btnJsonTest.Click += new System.EventHandler(this.BtnJsonTest_Click);
            // 
            // btnTsPlanningTest
            // 
            this.btnTsPlanningTest.Location = new System.Drawing.Point(12, 177);
            this.btnTsPlanningTest.Name = "btnTsPlanningTest";
            this.btnTsPlanningTest.Size = new System.Drawing.Size(142, 23);
            this.btnTsPlanningTest.TabIndex = 9;
            this.btnTsPlanningTest.Text = "TS Planning Test";
            this.btnTsPlanningTest.UseVisualStyleBackColor = true;
            this.btnTsPlanningTest.Click += new System.EventHandler(this.BtnTsPlanningTest_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 269);
            this.Controls.Add(this.btnTsPlanningTest);
            this.Controls.Add(this.btnJsonTest);
            this.Controls.Add(this.playerEditorControl1);
            this.Controls.Add(this.courtCountControl1);
            this.Controls.Add(this.btnTsTest);
            this.Controls.Add(this.btnBadmanTest);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTsTest;
        private System.Windows.Forms.Button btnBadmanTest;
        private BCA.WerZaehltWo3.Tests.Gui.Usercontrols.CourtCountControl courtCountControl1;
        private BCA.WerZaehltWo3.Tests.Gui.Usercontrols.PlayerEditorControl playerEditorControl1;
        private System.Windows.Forms.Button btnJsonTest;
        private System.Windows.Forms.Button btnTsPlanningTest;
    }
}

