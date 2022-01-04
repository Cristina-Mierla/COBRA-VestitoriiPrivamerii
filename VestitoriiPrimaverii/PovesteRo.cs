using COBRA_VestotoriiPrivamerii;
using System.Windows.Forms;
using VestitoriiPrimaverii.povesteMediu;
using VestitoriiPrimaverii.Resources;

namespace VestitoriiPrimaverii
{
    public partial class PovesteRo : Form
    {
        public PovesteRo()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = Constants.pathCantecVinePrimavara;
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                this.Hide();
                PovesteTerminata povesteTerminata = new PovesteTerminata(this, new JocRomana0());
                povesteTerminata.Show();    
            }
        }
    }
}
