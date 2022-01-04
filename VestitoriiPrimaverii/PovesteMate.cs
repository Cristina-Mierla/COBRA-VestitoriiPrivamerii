using System;
using System.Windows.Forms;
using VestitoriiPrimaverii.povesteMediu;
using VestitoriiPrimaverii.Resources;

namespace VestitoriiPrimaverii
{
    public partial class PovesteMate : Form
    {
        public PovesteMate()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = Constants.pathCantecel;
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                this.Hide();
                PovesteTerminata povesteTerminata = new PovesteTerminata(this, new JocMate1());
                povesteTerminata.Show();
            }
        }
    }
}
