using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloBoston
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Boston!", "Greeting", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            picRiver.Visible = false;
        }

        private void btnHide_MouseHover(object sender, EventArgs e)
        {
            this.Text = "This Button is used to hide river";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string sPass = txtPass .Text;
            if(sPass =="1234")
            {
                picRiver.Visible = true;
            }
            else
            {
                MessageBox.Show("Wrong Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnShow_MouseHover(object sender, EventArgs e)
        {
            this.Text = "This Button is used to show river";
        }

        private void frmHello_MouseHover(object sender, EventArgs e)
        {
            this.Text = "This is Form!";
        }

        private void btnHello_MouseHover(object sender, EventArgs e)
        {
            this.Text = "This Button is used to greet you!";
        }

        private void picRiver_MouseHover(object sender, EventArgs e)
        {
            this.Text = "This is river";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string sA;
            sA = txtA .Text;
            string sB;
            sB = txtB .Text;
            string sSum;
            sSum = txtSum .Text;

            int iA;
            iA = int.Parse(sA); //string -> int
            int iB;
            iB = int.Parse(sB);
            int  iC = int.Parse(sSum);

            int iAns = 0; //camel case
            if(cboSigns .SelectedItem.ToString()=="+")
            {
                iAns = iA + iB;
            }
            else if(cboSigns.SelectedItem.ToString()=="-")
            {
                iAns = iA - iB;
            }
            else if (cboSigns.SelectedItem.ToString() == "*")
            {
                iAns = iA * iB;
            }
            else if (cboSigns.SelectedItem.ToString() == "/")
            {
                iAns = iA / iB;
            }


            if (iAns==iC)
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Wrong!");
            }

            
        }

        private void lblSum_Click(object sender, EventArgs e)
        {

        }
    }
}
