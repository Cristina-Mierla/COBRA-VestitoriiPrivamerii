using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using VestitoriiPrimaverii;
using VestitoriiPrimaverii.Resources;

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
                JocTerminat jocTerminat = new JocTerminat(new JocRomana0(), this.finished);
                jocTerminat.Show();
            }
            else
            {
                JocTerminat jocTerminat = new JocTerminat(new JocRomana0(), new PovSocietate());
                jocTerminat.Show();
            }
        }

        private void ReadFairy_Click(object sender, EventArgs e)
        {
            string filename = Constants.pathRandunica;
            SoundPlayer splayer = new SoundPlayer(filename);
            splayer.Play();
        }
    }
}
