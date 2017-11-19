using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace Quiz_answer.UC
{
    public partial class ucExercise : UserControl
    {
        public ucExercise()
        {
            InitializeComponent();
        }
       
        private void btnpresent_Click(object sender, EventArgs e)
        {
            groupControl1.Enabled = true;
          //  this.lblpresent.Text = sb.ToString();
           // label1.Text = "Try" + "<br/>" + "this";
        }
        private void ucExercise_Load(object sender, EventArgs e)
        {
        }

        private void btncontinous_Click(object sender, EventArgs e)
        {
            btnthi1.Text = "Present Continous";
            btnthi2.Text = "Past Continous";
            btnthi3.Text = "Future Continous";
        }

        private void btnsimple_Click(object sender, EventArgs e)
        {
            Simple();
           
        }
        public void Simple()
        {
             btnthi1.Text = ". Simple Pressent";
             btnthi2.Text = ". Simple past";
             btnthi3.Text = ".Simple Future";
        }
        private void btnthi1_Click(object sender, EventArgs e)
        {
            if (btnthi1.Text == ". Simple Pressent")
            {
                pictureBox1.Image = Properties.Resources.HTD;
            }
            else if (btnthi1.Text == "Present Perfect")
            {
                pictureBox1.Image = Properties.Resources.HTHT;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.HTTD;
            }
        }

        private void btnthi2_Click(object sender, EventArgs e)
        {
            if (btnthi2.Text == ". Simple past")
            {
                pictureBox1.Image = Properties.Resources.QKD;
            }
            else if (btnthi2.Text == "Present Perfect Continouns")
            {
                pictureBox1.Image = Properties.Resources.HTHTTD;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.QKTD;
            }
        }

        private void btnthi3_Click(object sender, EventArgs e)
        {
            if (btnthi3.Text == ".Simple Future")
            {
                pictureBox1.Image = Properties.Resources.TLD;
            }
            else if (btnthi3.Text== "Past Perfect")
            {
                pictureBox1.Image = Properties.Resources.QKHT;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.TLTD;
            }
        }

        private void btnperfect_Click(object sender, EventArgs e)
        {
            btnthi1.Text = "Present Perfect";
            btnthi2.Text = "Present Perfect Continouns";
            btnthi3.Text = "Past Perfect";
            btnthi4.Text = "Past Perfect Continous";
            btnthi5.Text = "Future Perfect";
            btnthi6.Text = "Future Perfect Continous";
        }

        private void btnthi4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.QKHTTD;
        }

        private void btnthi5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.TLHT;
        }

        private void btnthi6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.TLHTTD;
        }
    }
}
