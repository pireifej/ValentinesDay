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
    public partial class Day : Form
    {
        public Day(Object image)
        {
            InitializeComponent();
            pbx_event.BackgroundImage = (System.Drawing.Image)image;
        }
    }
}
