using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_answer.UC
{
    public partial class ucTheotly : UserControl
    {
        public ucTheotly()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //  this.lblpresent.Text = sb.ToString();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1. My parent normally ____ breakfast at 7:00 a.m ?");
            sb.AppendLine("A. Eat");
            sb.AppendLine("B. Eats");
            sb.AppendLine("C. Are aeting");
            this.lblcontent.Text = sb.ToString();
           // DialogResult answer = MessageBox.Show("I get up at 6:00 am in the morning", "Question 1", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           // if(answer==DialogResult.Yes)
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("2. This week Barbara is away on business so Tom____ dinner for himself ?");
            sb.AppendLine("A. Cook");
            sb.AppendLine("B. Cooks");
            sb.AppendLine("C. Are Cooking");
            this.lblcontent.Text = sb.ToString();
           
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("3. Jeff ___ a book right now, he ___ a story to Linda ?");
            sb.AppendLine("A. Hold-read");
            sb.AppendLine("B.Is holding-is reading");
            sb.AppendLine("C. Hold-read");
            this.lblcontent.Text = sb.ToString();
           
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("4. Mary ____ (rest) in the garden all day because she ___ (be) ill ?");
            sb.AppendLine("A. Has been resting-has been");
            sb.AppendLine("B. Has rest-has been being");
            sb.AppendLine("C. Has rested-has been");
            this.lblcontent.Text = sb.ToString();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "Question 1")
            {
                if (txtanwer.Text == "A")
                {
                    MessageBox.Show("Correct 100%", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Image = Properties.Resources.appointment_256;
                }
                else
                {
                    MessageBox.Show("Wrong", "Let's make again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btn2.Text=="Question 2")
            {
                if (txtanwer.Text == "B")
                {
                    MessageBox.Show("Correct 100%", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Image = Properties.Resources.appointment_256;
                }
                else
                {
                    MessageBox.Show("Wrong", "Let's make again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(btn3.Text=="Question 3")
            {
                if (txtanwer.Text == "B")
                {
                    MessageBox.Show("Correct 100%", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Image = Properties.Resources.appointment_256;
                }
                else
                {
                    MessageBox.Show("Wrong", "Let's make again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btn4.Text=="Question 4")
            {
                if (txtanwer.Text == "A")
                {
                    MessageBox.Show("Correct 100%", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Image = Properties.Resources.appointment_256;
                }
                else
                {
                    MessageBox.Show("Wrong", "Let's make again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (txtanwer.Text == "B")
                {
                    MessageBox.Show("Correct 100%", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Image = Properties.Resources.appointment_256;
                }
                else
                {
                    MessageBox.Show("Wrong", "Let's make again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("5. Up to the present, we__ (write) almost every lesson in the book ?");
            sb.AppendLine("A. Has written");
            sb.AppendLine("B. Have written");
            sb.AppendLine("C. Has been writting");
            this.lblcontent.Text = sb.ToString();
        }
    }
}
