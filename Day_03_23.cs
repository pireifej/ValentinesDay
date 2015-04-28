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
    public partial class Day_03_23 : Form
    {
        public Day_03_23()
        {
            InitializeComponent();
        }

        private void lbl_phone_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = "DJ Okawari - Flower Dance.mp3";
            wplayer.controls.play();
        }
    }
}
