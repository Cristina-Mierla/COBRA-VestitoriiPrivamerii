using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VestitoriiPrimaverii.povesteMediu;
using VestitoriiPrimaverii.Resources;

namespace VestitoriiPrimaverii
{
    public partial class PovesteMediu : Form
    {

        public PovesteMediu()
        {
            InitializeComponent();

        }

        private void pictureOmZapada_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Constants.pathOmDeZapada);
            PovesteMediuVideo povesteMediuVideo = new PovesteMediuVideo(Constants.pathOmDeZapada);
            povesteMediuVideo.Show();
            pictureFrameOmZapada.Hide();
            checkIfFinished(povesteMediuVideo);
        }

        private void pictureGhiocel_Click(object sender, EventArgs e)
        {
            PovesteMediuVideo povesteMediuVideo = new PovesteMediuVideo(Constants.pathGhiocel);
            povesteMediuVideo.Show();
            pictureFrameGhiocel.Hide();
            checkIfFinished(povesteMediuVideo);
        }

        private void picturePasariCalatoare_Click(object sender, EventArgs e)
        {
            PovesteMediuVideo povesteMediuVideo = new PovesteMediuVideo(Constants.pathPasariCalatoare);
            povesteMediuVideo.Show();
            pictureFramePasariCalatoare.Hide();
            checkIfFinished(povesteMediuVideo);
        }

        private void picturePrimavaraSchimbari_Click(object sender, EventArgs e)
        {
            PovesteMediuVideo povesteMediuVideo = new PovesteMediuVideo(Constants.pathPrmavaraSchimbari);
            povesteMediuVideo.Show();
            pictureFramePrimavaraSchimbari.Hide();
            checkIfFinished(povesteMediuVideo);
        }

        private void checkIfFinished(PovesteMediuVideo povesteMediuVideo)
        {
            if (pictureFrameOmZapada.Visible == false && pictureFrameGhiocel.Visible == false && pictureFramePasariCalatoare.Visible == false && pictureFramePrimavaraSchimbari.Visible == false)
            {
                PovesteTerminata povesteTerminata = new PovesteTerminata();
                povesteTerminata.Show();
                this.Hide();
            }

        }
    }
}
