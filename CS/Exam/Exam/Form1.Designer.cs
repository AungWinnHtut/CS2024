namespace Exam
{
    partial class Form1
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
            this.cboChoice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboChoice
            // 
            this.cboChoice.FormattingEnabled = true;
            this.cboChoice.Items.AddRange(new object[] {
            "chin dwin",
            "ayeyarwaddy",
            "than lwin"});
            this.cboChoice.Location = new System.Drawing.Point(342, 33);
            this.cboChoice.Name = "cboChoice";
            this.cboChoice.Size = new System.Drawing.Size(210, 28);
            this.cboChoice.TabIndex = 0;
            this.cboChoice.Text = "chin dwin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "What is the longest river in Myanmar?";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(597, 36);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(132, 30);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboChoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheck;
    }
}

