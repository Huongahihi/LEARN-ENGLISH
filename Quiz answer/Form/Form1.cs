using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quiz_answer
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            uc1();
        }
        public void uc1()
        {
            UC.ucTheotly uc = new UC.ucTheotly(); //gắn uc vào form.
            UC.ucExercise uc1 = new UC.ucExercise();
            uc.Dock = DockStyle.Fill;
            txttab1.Controls.Add(uc);
            txttab2.Controls.Add(uc1);
        }

        private void btnlogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void btncancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sura cancel ?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }

        private void btnthe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txttab2.Show();
        }

        private void btnex_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txttab1.Show();
        }
    }
}
