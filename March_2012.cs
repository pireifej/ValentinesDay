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
    public partial class march_2012_frm : Form
    {
        public march_2012_frm()
        {
            InitializeComponent();
        }

        private void btn_to_april_Click(object sender, EventArgs e)
        {
            april_2012_frm form = new april_2012_frm();
            form.Show();
            this.Hide();
        }

        private void btn_to_february_Click(object sender, EventArgs e)
        {
            february_2012_frm form = new february_2012_frm();
            form.Show();
            this.Hide();
        }

        private void march_2012_frm_Load(object sender, EventArgs e)
        {

        }

        private void lbl_day_mar_03_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_03_03);
            form.Show();
        }

        private void lbl_day_mar_04_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_03_04);
            form.Show();
        }

        private void lbl_day_mar_09_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_03_09);
            form.Show();
        }

        private void lbl_day_mar_10_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_03_10);
            form.Show();
        }

        private void lbl_day_mar_11_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_03_11);
            form.Show();
        }

        private void lbl_day_mar_14_Click(object sender, EventArgs e)
        {
            Day_03_14 form = new Day_03_14();
            form.Show();
        }

        private void lbl_day_mar_15_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_03_15);
            form.Show();
        }

        private void lbl_day_mar_18_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_03_18);
            form.Show();
        }

        private void lbl_day_mar_21_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_03_21);
            form.Show();
        }

        private void lbl_day_mar_22_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_03_22);
            form.Show();
        }

        private void lbl_day_mar_23_Click(object sender, EventArgs e)
        {
            Day_03_23 form = new Day_03_23();
            form.Show();
        }

        private void lbl_day_mar_24_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_03_24);
            form.Show();
        }

        private void lbl_day_mar_25_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_03_25);
            form.Show();
        }

        private void lbl_day_mar_26_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_03_26);
            form.Show();
        }

        private void lbl_day_mar_27_Click(object sender, EventArgs e)
        {
            Day form_1 = new Day(Properties.Resources.day_03_27_1);
            Day form_2 = new Day(Properties.Resources.day_03_27_2);
            form_1.Show();
            form_2.Show();
        }

        private void lbl_day_mar_28_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_03_28);
            form.Show();
        }

        private void lbl_day_mar_30_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_03_30);
            form.Show();
        }
    }
}
