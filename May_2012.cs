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
    public partial class may_2012_frm : Form
    {
        public may_2012_frm()
        {
            InitializeComponent();
        }

        private void btn_to_june_Click(object sender, EventArgs e)
        {
            june_2012_frm form = new june_2012_frm();
            form.Show();
            this.Hide();
        }

        private void btn_to_april_Click(object sender, EventArgs e)
        {
            april_2012_frm form = new april_2012_frm();
            form.Show();
            this.Hide();
        }

        private void lbl_day_may_05_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_05_05);
            form.Show();
        }

        private void lbl_day_may_06_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_05_06);
            form.Show();
        }

        private void lbl_day_may_10_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_05_10);
            form.Show();
        }

        private void lbl_day_may_11_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_05_11);
            form.Show();
        }

        private void lbl_day_may_13_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_05_13);
            form.Show();
        }

        private void lbl_day_may_14_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_05_14);
            form.Show();
        }

        private void lbl_day_may_15_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_05_15);
            form.Show();
        }

        private void lbl_day_may_22_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_05_22);
            form.Show();
        }

        private void lbl_day_may_23_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_05_23);
            form.Show();
        }

        private void lbl_day_may_26_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_05_26);
            form.Show();
        }

        private void lbl_day_may_08_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_05_08);
            form.Show();
        }

        private void lbl_day_may_12_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_05_12);
            form.Show();
        }
    }
}
