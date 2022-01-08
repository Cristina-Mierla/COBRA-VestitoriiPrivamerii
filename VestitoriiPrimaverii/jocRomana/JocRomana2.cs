using System;
using System.Media;
using System.Windows.Forms;
using VestitoriiPrimaverii;
using VestitoriiPrimaverii.Resources;
using System.Threading;

namespace COBRA_VestotoriiPrivamerii
{
    public partial class JocRomana2 : Form
    {
        public JocRomana2()
        {
            InitializeComponent();
        }
        private bool finished = false;
        public JocRomana2(bool finished)
        {
            InitializeComponent();
            this.finished = finished;
        }

        private void Barza_Click(object sender, EventArgs e)
        {
            SadBarza.Visible = true;
        }

        private void Vrabie_Click(object sender, EventArgs e)
        {
            SadVrabie.Visible = true;
        }

        private void Randunica_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (finished)
            {
                JocTerminat jocTerminat = new JocTerminat(new JocRomana0(), this.finished, 4);
                jocTerminat.Show();
            }
            else
            {
                JocTerminat jocTerminat = new JocTerminat(new JocRomana0(), new PovSocietate(), 4);
                jocTerminat.Show();
            }
        }

        private void ReadFairy_Click(object sender, EventArgs e)
        {
            string filename = Constants.pathRandunica;
            SoundPlayer splayer = new SoundPlayer(filename);
            splayer.Play();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main(3);
            main.Show();
        }

        private void SadVrabie_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
