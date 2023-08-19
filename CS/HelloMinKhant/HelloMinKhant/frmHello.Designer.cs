namespace HelloMinKhant
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.picRiver = new System.Windows.Forms.PictureBox();
            this.btnHidePhoto = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRiver)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(549, 129);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(188, 73);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Say Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(33, 31);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(51, 20);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "label1";
            // 
            // picRiver
            // 
            this.picRiver.Image = ((System.Drawing.Image)(resources.GetObject("picRiver.Image")));
            this.picRiver.Location = new System.Drawing.Point(37, 68);
            this.picRiver.Name = "picRiver";
            this.picRiver.Size = new System.Drawing.Size(486, 353);
            this.picRiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRiver.TabIndex = 2;
            this.picRiver.TabStop = false;
            this.picRiver.Visible = false;
            // 
            // btnHidePhoto
            // 
            this.btnHidePhoto.Location = new System.Drawing.Point(549, 217);
            this.btnHidePhoto.Name = "btnHidePhoto";
            this.btnHidePhoto.Size = new System.Drawing.Size(188, 73);
            this.btnHidePhoto.TabIndex = 3;
            this.btnHidePhoto.Text = "Hide River";
            this.btnHidePhoto.UseVisualStyleBackColor = true;
            this.btnHidePhoto.Click += new System.EventHandler(this.btnHidePhoto_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(549, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(185, 26);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(554, 65);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // frmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 442);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnHidePhoto);
            this.Controls.Add(this.picRiver);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnHello);
            this.Name = "frmHello";
            this.Text = "Hello MinKhant";
            ((System.ComponentModel.ISupportInitialize)(this.picRiver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picRiver;
        private System.Windows.Forms.Button btnHidePhoto;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
    }
}

