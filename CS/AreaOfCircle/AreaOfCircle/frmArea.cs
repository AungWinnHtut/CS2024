using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaOfCircle
{
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                float fRadius = float.Parse(txtRadius.Text);
                float fArea = 3.14F * fRadius * fRadius;
                if (fArea<1000)
                {
                    picFace.Image = Image.FromFile("E:\\CS2024\\pictures\\sad.png");
                }
                else
                {
                    picFace.Image = Image.FromFile("E:\\CS2024\\pictures\\smile.png");
                }
                txtArea.Text = fArea.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Input format error!, Please enter float value only!", "Format Error!",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
                txtRadius .Clear();
                // txtRadius.Text = "";
                txtRadius .Focus();
            }
          
        }
    }
}
