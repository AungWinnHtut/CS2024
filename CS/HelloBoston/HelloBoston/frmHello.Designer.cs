namespace HelloBoston
{
    partial class frmHello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHello));
            this.btnHello = new System.Windows.Forms.Button();
            this.picRiver = new System.Windows.Forms.PictureBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cboSigns = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRiver)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(33, 37);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(183, 55);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Say Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            this.btnHello.MouseHover += new System.EventHandler(this.btnHello_MouseHover);
            // 
            // picRiver
            // 
            this.picRiver.Image = ((System.Drawing.Image)(resources.GetObject("picRiver.Image")));
            this.picRiver.Location = new System.Drawing.Point(234, 37);
            this.picRiver.Name = "picRiver";
            this.picRiver.Size = new System.Drawing.Size(270, 243);
            this.picRiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRiver.TabIndex = 1;
            this.picRiver.TabStop = false;
            this.picRiver.MouseHover += new System.EventHandler(this.picRiver_MouseHover);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(40, 172);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(175, 56);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "Hide River";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            this.btnHide.MouseHover += new System.EventHandler(this.btnHide_MouseHover);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(40, 244);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(174, 63);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show River";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            this.btnShow.MouseHover += new System.EventHandler(this.btnShow_MouseHover);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(40, 126);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(174, 26);
            this.txtPass.TabIndex = 4;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(572, 96);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(65, 26);
            this.txtA.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(726, 96);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(60, 26);
            this.txtB.TabIndex = 6;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(572, 187);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(214, 26);
            this.txtSum.TabIndex = 7;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(571, 67);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(20, 20);
            this.lblA.TabIndex = 8;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(687, 61);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(20, 20);
            this.lblB.TabIndex = 9;
            this.lblB.Text = "B";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(571, 152);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(150, 20);
            this.lblSum.TabIndex = 10;
            this.lblSum.Text = "Enter Answer below";
            this.lblSum.Click += new System.EventHandler(this.lblSum_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(572, 233);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(214, 47);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // cboSigns
            // 
            this.cboSigns.FormattingEnabled = true;
            this.cboSigns.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cboSigns.Location = new System.Drawing.Point(650, 98);
            this.cboSigns.Name = "cboSigns";
            this.cboSigns.Size = new System.Drawing.Size(57, 28);
            this.cboSigns.TabIndex = 12;
            this.cboSigns.Text = "+";
            // 
            // frmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.cboSigns);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.picRiver);
            this.Controls.Add(this.btnHello);
            this.Name = "frmHello";
            this.MouseHover += new System.EventHandler(this.frmHello_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.picRiver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.PictureBox picRiver;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ComboBox cboSigns;
    }
}

