using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Quiz_answer
{
    public partial class FomLogin : DevExpress.XtraEditors.XtraForm
    {
        public FomLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            txtname.Focus();
            if (txtname.Text == "admin" && txtpass.Text == "2001")
            {
                this.Hide();
                Form1 ht = new Form1();
                ht.Show();
            }
            else
                MessageBox.Show("You did not login successful. Let's to try again.","Error",MessageBoxButtons.OK,MessageBoxIcon.Asterisk );
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtpass.Clear();
            txtname.Focus();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(" Are you sure cancel to login", "Lock out", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand)) 
            {
                Application.Exit();
            }
         }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}