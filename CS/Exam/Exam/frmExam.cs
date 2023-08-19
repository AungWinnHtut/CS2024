using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class frmExam : Form
    {
        //global variables
        //external variables
        string q;
        string m1;
        string m2;
        string m3;
        string CA;
        string m1pic;
        string m2pic;
        string m3pic;
        string[] questions;
        int current_question_number = 0;
        int question_count = 0;
        int marks = 0;
        public frmExam() //constructor
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            if(cboChoice.SelectedIndex +1==int.Parse(CA))
            {
                MessageBox.Show("Correct!", "Quiz");
                marks = marks + 5; 
            }
            else
            {
                MessageBox.Show("Wrong!", "Quiz");
            }
            if(current_question_number<question_count) //more question?
            {               
                    btnNext.Enabled = true;                          
            }
            else
            {
                MessageBox.Show("All questions are finished!");
            }
            txtMarks.Text = marks.ToString();
            btnCheck.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                string fname = "question.txt";
                questions = File.ReadAllLines(fname);
                question_count = questions.Length;                
                String [] QandA = questions[current_question_number].Split('#');
                current_question_number = current_question_number + 1;
                q = QandA[0];
                m1 = QandA[1];
                m1pic = QandA[2];
                m2 = QandA[3];
                m2pic = QandA[4];
                m3 = QandA[5];
                m3pic = QandA[6];
                CA = QandA[7];
                lblQuestion.Text = q;
                cboChoice.Items.Add(m1);
                cboChoice.Items.Add(m2);
                cboChoice.Items.Add(m3);
                cboChoice.Text = m1;
                string pfname = m1pic; 
                picQuiz.Image = Image.FromFile(pfname);
                picQuiz.SizeMode = PictureBoxSizeMode.StretchImage;
                btnNext .Enabled = false;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void cboChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cboChoice.SelectedIndex)
            {
                case 0: picQuiz.Image = Image.FromFile(m1pic); break;
                case 1: picQuiz.Image = Image.FromFile(m2pic); break;
                case 2: picQuiz.Image = Image.FromFile(m3pic); break;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picQuiz_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnCheck.Enabled = true;
            cboChoice.Items.Clear();
            String[] QandA = questions[current_question_number].Split('#');
            current_question_number = current_question_number + 1;
            q = QandA[0];
            m1 = QandA[1];
            m1pic = QandA[2];
            m2 = QandA[3];
            m2pic = QandA[4];
            m3 = QandA[5];
            m3pic = QandA[6];
            CA = QandA[7];
            lblQuestion.Text = q;
            cboChoice.Items.Add(m1);
            cboChoice.Items.Add(m2);
            cboChoice.Items.Add(m3);
            cboChoice.Text = m1;
            string pfname = m1pic;
            picQuiz.Image = Image.FromFile(pfname);
            picQuiz.SizeMode = PictureBoxSizeMode.StretchImage;
            btnNext.Enabled = false;
        }
    }
}
