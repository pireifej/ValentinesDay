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
    public partial class august_2012_frm : Form
    {
        public august_2012_frm()
        {
            InitializeComponent();
        }

        private void btn_to_september_Click(object sender, EventArgs e)
        {
            september_2012_frm form = new september_2012_frm();
            form.Show();
            this.Hide();
        }

        private void btn_to_august_Click(object sender, EventArgs e)
        {
            july_2012_frm form = new july_2012_frm();
            form.Show();
            this.Hide();
        }

        private void lbl_day_august_02_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_08_02);
            form.Show();
        }

        private void lbl_day_august_03_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_08_03);
            form.Show();
        }

        private void lbl_day_august_06_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_08_06);
            form.Show();
        }

        private void lbl_day_august_09_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_08_09);
            form.Show();
        }

        private void lbl_day_august_11_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_08_11);
            form.Show();
        }

        private void lbl_day_august_12_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_08_12);
            form.Show();
        }

        private void lbl_day_august_15_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_08_15);
            form.Show();
        }

        private void lbl_day_august_16_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_08_16);
            form.Show();
        }

        private void lbl_day_august_18_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_08_18);
            form.Show();
        }

        private void lbl_day_august_22_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_08_22);
            form.Show();
        }

        private void lbl_day_august_25_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_08_25);
            form.Show();
        }

        private void lbl_day_august_26_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_08_26);
            form.Show();
        }

        private void lbl_day_august_27_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_08_27);
            form.Show();
        }

        private void lbl_day_august_28_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_08_28);
            form.Show();
        }

        private void lbl_day_august_30_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_08_30);
            form.Show();
        }

        private void lbl_day_august_31_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_08_31);
            form.Show();
        }
    }
}
