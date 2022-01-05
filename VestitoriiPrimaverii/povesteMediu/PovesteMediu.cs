using System;
using System.Windows.Forms;
using VestitoriiPrimaverii.Resources;

namespace VestitoriiPrimaverii
{
    public partial class PovesteMediu : Form
    {

        public PovesteMediu()
        {
            InitializeComponent();
        }
        public bool finished = false;
        public PovesteMediu(bool finished)
        {
            InitializeComponent();
            this.finished = finished;
        }

        private void pictureOmZapada_Click(object sender, EventArgs e)
        {
            PovesteMediuVideo povesteMediuVideo = new PovesteMediuVideo(this, Constants.pathOmDeZapada);
            povesteMediuVideo.Show();
            pictureFrameOmZapada.Hide();
        }

        private void pictureGhiocel_Click(object sender, EventArgs e)
        {
            PovesteMediuVideo povesteMediuVideo = new PovesteMediuVideo(this, Constants.pathGhiocel);
            povesteMediuVideo.Show();
            pictureFrameGhiocel.Hide();
        }

        private void picturePasariCalatoare_Click(object sender, EventArgs e)
        {
            PovesteMediuVideo povesteMediuVideo = new PovesteMediuVideo(this, Constants.pathPasariCalatoare);
            povesteMediuVideo.Show();
            pictureFramePasariCalatoare.Hide();
        }

        private void picturePrimavaraSchimbari_Click(object sender, EventArgs e)
        {
            PovesteMediuVideo povesteMediuVideo = new PovesteMediuVideo(this, Constants.pathPrmavaraSchimbari);
            povesteMediuVideo.Show();
            pictureFramePrimavaraSchimbari.Hide();
        }

        public bool checkIfFinished()
        {
            if (pictureFrameOmZapada.Visible == false && pictureFrameGhiocel.Visible == false && pictureFramePasariCalatoare.Visible == false && pictureFramePrimavaraSchimbari.Visible == false)
            {
                return true;
            }
            return false;
        }
    }
}
