namespace BCA.WerZaehltWo3.Tests.Gui.Forms
{
    partial class TsPlanningTestForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnGetPlanningIds = new System.Windows.Forms.Button();
            this.txtEventId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetCurrentMatches = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Events";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(38, 147);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(750, 239);
            this.txtOutput.TabIndex = 1;
            // 
            // btnGetPlanningIds
            // 
            this.btnGetPlanningIds.Location = new System.Drawing.Point(483, 13);
            this.btnGetPlanningIds.Name = "btnGetPlanningIds";
            this.btnGetPlanningIds.Size = new System.Drawing.Size(138, 46);
            this.btnGetPlanningIds.TabIndex = 2;
            this.btnGetPlanningIds.Text = "Get Planning Ids";
            this.btnGetPlanningIds.UseVisualStyleBackColor = true;
            this.btnGetPlanningIds.Click += new System.EventHandler(this.BtnGetPlanningIds_Click);
            // 
            // txtEventId
            // 
            this.txtEventId.Location = new System.Drawing.Point(688, 20);
            this.txtEventId.Name = "txtEventId";
            this.txtEventId.Size = new System.Drawing.Size(100, 26);
            this.txtEventId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Event:";
            // 
            // btnGetCurrentMatches
            // 
            this.btnGetCurrentMatches.Location = new System.Drawing.Point(483, 65);
            this.btnGetCurrentMatches.Name = "btnGetCurrentMatches";
            this.btnGetCurrentMatches.Size = new System.Drawing.Size(138, 55);
            this.btnGetCurrentMatches.TabIndex = 5;
            this.btnGetCurrentMatches.Text = "get current matches";
            this.btnGetCurrentMatches.UseVisualStyleBackColor = true;
            this.btnGetCurrentMatches.Click += new System.EventHandler(this.BtnGetCurrentMatches_Click);
            // 
            // TsPlanningTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetCurrentMatches);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEventId);
            this.Controls.Add(this.btnGetPlanningIds);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.button1);
            this.Name = "TsPlanningTestForm";
            this.Text = "TsPlanningTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnGetPlanningIds;
        private System.Windows.Forms.TextBox txtEventId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetCurrentMatches;
    }
}