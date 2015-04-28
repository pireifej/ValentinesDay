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
    public partial class october_2012_frm : Form
    {
        public october_2012_frm()
        {
            InitializeComponent();
        }

        private void btn_to_september_Click(object sender, EventArgs e)
        {
            september_2012_frm form = new september_2012_frm();
            form.Show();
            this.Hide();
        }

        private void lbl_day_october_04_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_10_04);
            form.Show();
        }

        private void lbl_day_october_19_Click(object sender, EventArgs e)
        {
            Day form_1 = new Day(Properties.Resources.day_10_19_1);
            Day form_2 = new Day(Properties.Resources.day_10_19_2);
            form_1.Show();
            form_2.Show();
        }

        private void lbl_day_october_20_Click(object sender, EventArgs e)
        {
            Day form_1 = new Day(Properties.Resources.day_10_20_1);
            Day form_2 = new Day(Properties.Resources.day_10_20_2);
            form_1.Show();
            form_2.Show();
        }

        private void lbl_day_october_05_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_10_05);
            form.Show();
        }

        private void lbl_day_october_09_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_10_09);
            form.Show();
        }

        private void lbl_day_october_13_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_10_13);
            form.Show();
        }
    }
}
