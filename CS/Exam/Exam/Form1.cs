using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(cboChoice.SelectedItem.ToString() ==  "ayeyarwaddy")
            {
                MessageBox.Show("Correct!", "Quiz");
            }
            else
            {
                MessageBox.Show("Wrong!", "Quiz");
            }
        }
    }
}
