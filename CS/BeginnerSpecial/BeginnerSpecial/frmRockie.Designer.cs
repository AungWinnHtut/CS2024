namespace BeginnerSpecial
{
    partial class frmRockie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRockie));
            this.btnSayHello = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.picRiver = new System.Windows.Forms.PictureBox();
            this.btnHide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picRiver)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSayHello
            // 
            this.btnSayHello.Location = new System.Drawing.Point(12, 314);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(139, 60);
            this.btnSayHello.TabIndex = 1;
            this.btnSayHello.Text = "Say Hello";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(107, 22);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(322, 26);
            this.txtPass.TabIndex = 0;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 22);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // picRiver
            // 
            this.picRiver.Image = ((System.Drawing.Image)(resources.GetObject("picRiver.Image")));
            this.picRiver.Location = new System.Drawing.Point(16, 82);
            this.picRiver.Name = "picRiver";
            this.picRiver.Size = new System.Drawing.Size(412, 222);
            this.picRiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRiver.TabIndex = 3;
            this.picRiver.TabStop = false;
            this.picRiver.Visible = false;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(470, 82);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(148, 62);
            this.btnHide.TabIndex = 4;
            this.btnHide.Text = "Hide & Show";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // frmRockie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 386);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.picRiver);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnSayHello);
            this.Name = "frmRockie";
            this.Text = "Green Hackers";
            this.Load += new System.EventHandler(this.frmRockie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRiver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox picRiver;
        private System.Windows.Forms.Button btnHide;
    }
}

