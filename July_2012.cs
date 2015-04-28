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
    public partial class july_2012_frm : Form
    {
        public july_2012_frm()
        {
            InitializeComponent();
        }

        private void btn_to_august_Click(object sender, EventArgs e)
        {
            august_2012_frm form = new august_2012_frm();
            form.Show();
            this.Hide();
        }

        private void btn_to_june_Click(object sender, EventArgs e)
        {
            june_2012_frm form = new june_2012_frm();
            form.Show();
            this.Hide();
        }

        private void lbl_day_july_07_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_07_07);
            form.Show();
        }

        private void lbl_day_july_08_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_07_08);
            form.Show();
        }

        private void lbl_day_july_16_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_07_16);
            form.Show();
        }

        private void lbl_day_july_21_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_07_21);
            form.Show();
        }

        private void lbl_day_july_24_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_07_24);
            form.Show();
        }

        private void lbl_day_july_29_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_07_29);
            form.Show();
        }

        private void lbl_day_july_31_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_07_31);
            form.Show();
        }
    }
}
