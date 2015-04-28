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
    public partial class september_2012_frm : Form
    {
        public september_2012_frm()
        {
            InitializeComponent();
        }

        private void btn_to_october_Click(object sender, EventArgs e)
        {
            october_2012_frm form = new october_2012_frm();
            form.Show();
            this.Hide();
        }

        private void btn_to_august_Click(object sender, EventArgs e)
        {
            august_2012_frm form = new august_2012_frm();
            form.Show();
            this.Hide();
        }

        private void lbl_day_september_01_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_09_01);
            form.Show();
        }

        private void lbl_day_september_02_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_09_02);
            form.Show();
        }

        private void lbl_day_september_05_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_09_05);
            form.Show();
        }

        private void lbl_day_september_09_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_09_09);
            form.Show();
        }

        private void lbl_day_september_10_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_09_10);
            form.Show();
        }

        private void lbl_day_september_11_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_09_11);
            form.Show();
        }

        private void lbl_day_september_12_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_09_12);
            form.Show();
        }

        private void lbl_day_september_13_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_09_13);
            form.Show();
        }

        private void lbl_day_september_15_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_09_15);
            form.Show();
        }

        private void lbl_day_september_25_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_09_25);
            form.Show();
        }

        private void lbl_day_september_27_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_09_27);
            form.Show();
        }

        private void lbl_day_september_28_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_09_28);
            form.Show();
        }

        private void lbl_day_september_29_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_09_29);
            form.Show();
        }
    }
}
