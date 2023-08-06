using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGoodBye_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Uri my_url = new Uri(txtURL .Text);
            web.Url = my_url;
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBrowse_Click (sender, e);
            }
        }

        private void lstAddresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Uri my_uri = new Uri(lstAddresses .SelectedItem.ToString());
            web.Url=my_uri;
        }
    }
}
