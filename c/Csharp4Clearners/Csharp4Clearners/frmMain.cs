using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp4Clearners
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            username = txtUname.Text;
            password = txtPass.Text;
            if(username =="aung"&&password=="1234")
            {
                frmSecretMsg msg = new frmSecretMsg();
                msg.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }
    }
}
