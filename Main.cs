using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valentine_s_Day
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            january_2012_frm form = new january_2012_frm();
            form.Show();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            frm_Message form = new frm_Message();
            form.Show();
        }

        private void btn_january_Click(object sender, EventArgs e)
        {
            january_2012_frm form = new january_2012_frm();
            form.Show();
        }

        private void btn_february_Click(object sender, EventArgs e)
        {
            february_2012_frm form = new february_2012_frm();
            form.Show();
        }

        private void btn_march_Click(object sender, EventArgs e)
        {
            march_2012_frm form = new march_2012_frm();
            form.Show();
        }

        private void btn_april_Click(object sender, EventArgs e)
        {
            april_2012_frm form = new april_2012_frm();
            form.Show();
        }

        private void btn_may_Click(object sender, EventArgs e)
        {
            may_2012_frm form = new may_2012_frm();
            form.Show();
        }

        private void btn_june_Click(object sender, EventArgs e)
        {
            june_2012_frm form = new june_2012_frm();
            form.Show();
        }

        private void btn_july_Click(object sender, EventArgs e)
        {
            july_2012_frm form = new july_2012_frm();
            form.Show();
        }

        private void btn_august_Click(object sender, EventArgs e)
        {
            august_2012_frm form = new august_2012_frm();
            form.Show();
        }

        private void btn_september_Click(object sender, EventArgs e)
        {
            september_2012_frm form = new september_2012_frm();
            form.Show();
        }

        private void btn_october_Click(object sender, EventArgs e)
        {
            october_2012_frm form = new october_2012_frm();
            form.Show();
        }

        private void lbl_message_Click(object sender, EventArgs e)
        {
            frm_Message form = new frm_Message();
            form.Show();
        }
    }
}
