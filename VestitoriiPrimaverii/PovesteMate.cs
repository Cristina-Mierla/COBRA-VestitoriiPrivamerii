using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VestitoriiPrimaverii.Resources;

namespace VestitoriiPrimaverii
{
    public partial class PovesteMate : Form
    {
        public PovesteMate()
        {
            InitializeComponent();
           
        }



        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                var next = new JocMate1();
                this.Hide();
                next.Location = this.Location;
                next.StartPosition = FormStartPosition.Manual;
                next.ShowDialog();
                this.Close();
            }
        }


        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Constants.pathCantecel;
            axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);
        }

        private void PovesteMate_Load(object sender, EventArgs e)
        {

        }
    }
}
