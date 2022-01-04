using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VestitoriiPrimaverii.povesteMediu;
using VestitoriiPrimaverii.Resources;

namespace VestitoriiPrimaverii
{
    public partial class PovSocietate : Form
    {
        public PovSocietate()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = Constants.pathPovesteSocietate;
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                this.Hide();
                PovesteTerminata povesteTerminata = new PovesteTerminata(this, new JocOmSocietate());
                povesteTerminata.Show();
            }
        }
    }
}
