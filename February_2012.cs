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
    public partial class february_2012_frm : Form
    {
        public february_2012_frm()
        {
            InitializeComponent();
        }

        private void lbl_day_feb_24_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_02_24);
            form.Show();
        }

        private void btn_to_march_Click(object sender, EventArgs e)
        {
            march_2012_frm form = new march_2012_frm();
            form.Show();
            this.Hide();
        }

        private void btn_to_february_Click(object sender, EventArgs e)
        {
            january_2012_frm form = new january_2012_frm();
            form.Show();
            this.Hide();
        }
    }
}
