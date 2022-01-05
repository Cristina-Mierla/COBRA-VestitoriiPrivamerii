using System;
using System.Windows.Forms;
using VestitoriiPrimaverii.povesteMediu;
using VestitoriiPrimaverii.Resources;

namespace VestitoriiPrimaverii
{
    public partial class PovesteMate : Form
    {
        private bool finished = false;
        public PovesteMate()
        {
            InitializeComponent();
            //axWindowsMediaPlayer1.URL = Constants.pathCantecel;
        }

        public PovesteMate(bool finised)
        {
            InitializeComponent();
            this.finished = finished;
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                this.Hide();
                PovesteTerminata povesteTerminata = new PovesteTerminata(this, new JocMate1(this.finished));
                povesteTerminata.Show();
            }
        }

        private void PovesteMate_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Constants.pathCantecel;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
