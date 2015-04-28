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
    public partial class june_2012_frm : Form
    {
        public june_2012_frm()
        {
            InitializeComponent();
        }

        private void btn_to_august_Click(object sender, EventArgs e)
        {
            july_2012_frm form = new july_2012_frm();
            form.Show();
            this.Hide();
        }

        private void btn_to_july_Click(object sender, EventArgs e)
        {
            may_2012_frm form = new may_2012_frm();
            form.Show();
            this.Hide();
        }

        private void lbl_day_june_09_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_06_09);
            form.Show();
        }

        private void lbl_day_june_01_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_06_01);
            form.Show();
        }

        private void lbl_day_june_05_Click(object sender, EventArgs e)
        {
            Day_06_05 form = new Day_06_05();
            form.Show();
        }

        private void lbl_day_june_06_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_06_06);
            form.Show();
        }

        private void lbl_day_june_11_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_06_11);
            form.Show();
        }

        private void lbl_day_june_16_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_06_16);
            form.Show();
        }

        private void lbl_day_june_19_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_06_19);
            form.Show();
        }

        private void lbl_day_june_30_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_06_30);
            form.Show();
        }
    }
}
