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
    public partial class Day_03_14 : Form
    {
        public Day_03_14()
        {
            InitializeComponent();
        }

        private void lbl_phone_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = "08th MS Team - 3.MP3";
            wplayer.controls.play();
        }

        private void lbl_phone_music_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            //wplayer.URL = Properties.Resources.song;
            //wplayer.URL = "ms-resource:///song";
            //wplayer.URL = "08th MS Team - 3.MP3";
            string path;
            path = System.IO.Directory.GetCurrentDirectory();
            MessageBox.Show(path + "08th MS Team - 3.MP3");
            //wplayer.controls.play();
        }
    }
}
