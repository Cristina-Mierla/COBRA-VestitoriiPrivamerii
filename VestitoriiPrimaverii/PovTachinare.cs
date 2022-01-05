using System;
using System.Windows.Forms;
using VestitoriiPrimaverii.povesteMediu;
using VestitoriiPrimaverii.Resources;

namespace VestitoriiPrimaverii
{
    public partial class PovTachinare : Form
    {
        public PovTachinare()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = Constants.pathTachinare;
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                this.Hide();
                JocTerminat jocTerminat = new JocTerminat(this);
                jocTerminat.Show();
            }
        }
    }
}
