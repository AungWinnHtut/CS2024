using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeginnerSpecial
{
    public partial class frmRockie : Form
    {
        public frmRockie()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string sPass;
            sPass = txtPass.Text;
            if(sPass == "1234")
            {
                this.Text = "Password Correct!";
                picRiver.Visible = true;
            }
           

        }

        private void frmRockie_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtPass;
            btnHide.Text = "Show";
                            
        }

     

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSayHello_Click((object)sender, e);
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if(picRiver .Visible==true)
            {
                picRiver.Visible = false;
                btnHide.Text = "Show";

            }
            else
            {
                picRiver.Visible = true;
                btnHide.Text = "Hide";
            }
        }

      
    }
}
