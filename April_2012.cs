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
    public partial class april_2012_frm : Form
    {
        public april_2012_frm()
        {
            InitializeComponent();
        }

        private void btn_to_march_Click(object sender, EventArgs e)
        {
            march_2012_frm form = new march_2012_frm();
            form.Show();
            this.Hide();

        }

        private void btn_to_may_Click(object sender, EventArgs e)
        {
            may_2012_frm form = new may_2012_frm();
            form.Show();
            this.Hide();
        }

        private void lbl_day_april_01_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_04_01);
            form.Show();
        }

        private void lbl_day_april_02_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_04_02);
            form.Show();
        }

        private void lbl_day_april_05_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_04_05);
            form.Show();
        }

        private void lbl_day_april_06_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_04_06);
            form.Show();
        }

        private void lbl_day_april_13_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_04_13);
            form.Show();
        }

        private void lbl_day_april_18_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_04_18);
            form.Show();
        }

        private void lbl_day_april_14_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_04_14);
            form.Show();
        }
    }
}
