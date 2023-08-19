namespace CardGame
{
    partial class frmCardGame
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
            this.picDealer1 = new System.Windows.Forms.PictureBox();
            this.btnShowCard = new System.Windows.Forms.Button();
            this.picDealer2 = new System.Windows.Forms.PictureBox();
            this.picUser1 = new System.Windows.Forms.PictureBox();
            this.picUser2 = new System.Windows.Forms.PictureBox();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.picDealer3 = new System.Windows.Forms.PictureBox();
            this.picUser3 = new System.Windows.Forms.PictureBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDealerMarks = new System.Windows.Forms.Label();
            this.lblUserMarks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser3)).BeginInit();
            this.SuspendLayout();
            // 
            // picDealer1
            // 
            this.picDealer1.Location = new System.Drawing.Point(39, 48);
            this.picDealer1.Name = "picDealer1";
            this.picDealer1.Size = new System.Drawing.Size(175, 236);
            this.picDealer1.TabIndex = 0;
            this.picDealer1.TabStop = false;
            // 
            // btnShowCard
            // 
            this.btnShowCard.Location = new System.Drawing.Point(846, 58);
            this.btnShowCard.Name = "btnShowCard";
            this.btnShowCard.Size = new System.Drawing.Size(180, 78);
            this.btnShowCard.TabIndex = 1;
            this.btnShowCard.Text = "Show Card";
            this.btnShowCard.UseVisualStyleBackColor = true;
            this.btnShowCard.Click += new System.EventHandler(this.btnShowCard_Click);
            // 
            // picDealer2
            // 
            this.picDealer2.Location = new System.Drawing.Point(247, 48);
            this.picDealer2.Name = "picDealer2";
            this.picDealer2.Size = new System.Drawing.Size(175, 236);
            this.picDealer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealer2.TabIndex = 2;
            this.picDealer2.TabStop = false;
            // 
            // picUser1
            // 
            this.picUser1.Location = new System.Drawing.Point(39, 358);
            this.picUser1.Name = "picUser1";
            this.picUser1.Size = new System.Drawing.Size(175, 236);
            this.picUser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser1.TabIndex = 3;
            this.picUser1.TabStop = false;
            // 
            // picUser2
            // 
            this.picUser2.Location = new System.Drawing.Point(247, 358);
            this.picUser2.Name = "picUser2";
            this.picUser2.Size = new System.Drawing.Size(175, 236);
            this.picUser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser2.TabIndex = 4;
            this.picUser2.TabStop = false;
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Location = new System.Drawing.Point(42, 18);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(56, 20);
            this.lblDealer.TabIndex = 5;
            this.lblDealer.Text = "Dealer";
            this.lblDealer.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(39, 330);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 20);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User";
            // 
            // picDealer3
            // 
            this.picDealer3.Location = new System.Drawing.Point(454, 48);
            this.picDealer3.Name = "picDealer3";
            this.picDealer3.Size = new System.Drawing.Size(175, 236);
            this.picDealer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealer3.TabIndex = 7;
            this.picDealer3.TabStop = false;
            // 
            // picUser3
            // 
            this.picUser3.Location = new System.Drawing.Point(454, 358);
            this.picUser3.Name = "picUser3";
            this.picUser3.Size = new System.Drawing.Size(175, 236);
            this.picUser3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser3.TabIndex = 8;
            this.picUser3.TabStop = false;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(761, 212);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(59, 20);
            this.lblWinner.TabIndex = 9;
            this.lblWinner.Text = "Winner";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(761, 255);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(29, 20);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "     ";
            // 
            // lblDealerMarks
            // 
            this.lblDealerMarks.AutoSize = true;
            this.lblDealerMarks.Location = new System.Drawing.Point(653, 57);
            this.lblDealerMarks.Name = "lblDealerMarks";
            this.lblDealerMarks.Size = new System.Drawing.Size(103, 20);
            this.lblDealerMarks.TabIndex = 11;
            this.lblDealerMarks.Text = "Dealer Marks";
            // 
            // lblUserMarks
            // 
            this.lblUserMarks.AutoSize = true;
            this.lblUserMarks.Location = new System.Drawing.Point(664, 358);
            this.lblUserMarks.Name = "lblUserMarks";
            this.lblUserMarks.Size = new System.Drawing.Size(90, 20);
            this.lblUserMarks.TabIndex = 12;
            this.lblUserMarks.Text = "User Marks";
            // 
            // frmCardGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 809);
            this.Controls.Add(this.lblUserMarks);
            this.Controls.Add(this.lblDealerMarks);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.picUser3);
            this.Controls.Add(this.picDealer3);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.picUser2);
            this.Controls.Add(this.picUser1);
            this.Controls.Add(this.picDealer2);
            this.Controls.Add(this.btnShowCard);
            this.Controls.Add(this.picDealer1);
            this.Name = "frmCardGame";
            this.Text = "Card Game";
            this.Load += new System.EventHandler(this.frmCardGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDealer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDealer1;
        private System.Windows.Forms.Button btnShowCard;
        private System.Windows.Forms.PictureBox picDealer2;
        private System.Windows.Forms.PictureBox picUser1;
        private System.Windows.Forms.PictureBox picUser2;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox picDealer3;
        private System.Windows.Forms.PictureBox picUser3;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDealerMarks;
        private System.Windows.Forms.Label lblUserMarks;
    }
}

