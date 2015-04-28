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
    public partial class january_2012_frm : Form
    {
        public january_2012_frm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Day form = new Day(Properties.Resources.day_01_19);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            february_2012_frm form = new february_2012_frm();
            form.Show();
            this.Hide();
        }
    }
}
