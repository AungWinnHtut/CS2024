using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMinKhant
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {            
            string sPassword = txtPassword.Text;
            if(sPassword=="1234")
            {
                lblInfo.Text = "Hello, Green Hackers!"; //String စာသား
                picRiver.Visible = true;
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
         
        }

        private void btnHidePhoto_Click(object sender, EventArgs e)
        {
            picRiver .Visible = false;
        }
    }
}
