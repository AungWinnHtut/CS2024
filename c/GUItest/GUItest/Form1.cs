using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUItest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string uname = txtUname .Text;
            string password = txtPassword .Text;    
            if (uname == "aung" &&  password == "1234")
            {
                MessageBox.Show("Correct");
            }
            else
            {
                MessageBox.Show("Wrong");
            }
        }
    }
}
