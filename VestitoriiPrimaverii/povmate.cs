using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using System.IO;

namespace VestitoriiPrimaverii
{
    public partial class povmate : Form
    {
        public povmate()
        {
            InitializeComponent();
            string filename = AppDomain.CurrentDomain.BaseDirectory + "cantecel.wmv";
            axWindowsMediaPlayer1.URL = filename;
            axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8) {
                MessageBox.Show("vIDEO ENDED"); // aici vine fereastra joc mate1
            }
        }

        private void povmate_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
