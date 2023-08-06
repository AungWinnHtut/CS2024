namespace HelloWorld
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
            this.web = new System.Windows.Forms.WebBrowser();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lstAddresses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(457, 103);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(577, 532);
            this.web.TabIndex = 0;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(21, 11);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(42, 20);
            this.lblURL.TabIndex = 1;
            this.lblURL.Text = "URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(69, 5);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(835, 26);
            this.txtURL.TabIndex = 2;
            this.txtURL.Text = "https://";
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(918, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(141, 27);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lstAddresses
            // 
            this.lstAddresses.FormattingEnabled = true;
            this.lstAddresses.ItemHeight = 20;
            this.lstAddresses.Items.AddRange(new object[] {
            "https://www.google.com",
            "https://www.gmail.com",
            "https://www.blogger.com"});
            this.lstAddresses.Location = new System.Drawing.Point(22, 103);
            this.lstAddresses.Name = "lstAddresses";
            this.lstAddresses.Size = new System.Drawing.Size(413, 404);
            this.lstAddresses.TabIndex = 4;
            this.lstAddresses.SelectedIndexChanged += new System.EventHandler(this.lstAddresses_SelectedIndexChanged);
            // 
            // frmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 677);
            this.Controls.Add(this.lstAddresses);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.web);
            this.Name = "frmHello";
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox lstAddresses;
    }
}

