namespace AreaOfCircle
{
    partial class frmArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArea));
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.picFace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(31, 22);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(59, 20);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(123, 22);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(155, 26);
            this.txtRadius.TabIndex = 1;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(123, 54);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(155, 26);
            this.txtArea.TabIndex = 3;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(31, 54);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(43, 20);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(38, 92);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(239, 49);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // picFace
            // 
            this.picFace.Image = ((System.Drawing.Image)(resources.GetObject("picFace.Image")));
            this.picFace.Location = new System.Drawing.Point(297, 21);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(151, 119);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFace.TabIndex = 5;
            this.picFace.TabStop = false;
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 166);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblRadius);
            this.Name = "frmArea";
            this.Text = "Area of Circle";
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox picFace;
    }
}

