namespace Exam
{
    partial class frmExam
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.picQuiz = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblMarks = new System.Windows.Forms.Label();
            this.txtMarks = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQuiz)).BeginInit();
            this.SuspendLayout();
            // 
            // cboChoice
            // 
            this.cboChoice.FormattingEnabled = true;
            this.cboChoice.Location = new System.Drawing.Point(342, 133);
            this.cboChoice.Name = "cboChoice";
            this.cboChoice.Size = new System.Drawing.Size(210, 28);
            this.cboChoice.TabIndex = 0;
            this.cboChoice.SelectedIndexChanged += new System.EventHandler(this.cboChoice_SelectedIndexChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(39, 42);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(206, 20);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "The question will show here!";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(558, 127);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(132, 38);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // picQuiz
            // 
            this.picQuiz.Location = new System.Drawing.Point(28, 171);
            this.picQuiz.Name = "picQuiz";
            this.picQuiz.Size = new System.Drawing.Size(745, 335);
            this.picQuiz.TabIndex = 3;
            this.picQuiz.TabStop = false;
            this.picQuiz.Click += new System.EventHandler(this.picQuiz_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(696, 127);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(601, 523);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(172, 52);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(32, 546);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(95, 20);
            this.lblMarks.TabIndex = 6;
            this.lblMarks.Text = "Total Marks:";
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(133, 540);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(77, 26);
            this.txtMarks.TabIndex = 7;
            this.txtMarks.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 634);
            this.ControlBox = false;
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picQuiz);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.cboChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Exam System 2023";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQuiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboChoice;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.PictureBox picQuiz;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.TextBox txtMarks;
    }
}

