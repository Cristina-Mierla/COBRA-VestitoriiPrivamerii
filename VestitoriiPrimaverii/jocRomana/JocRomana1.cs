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
    public partial class JocRomana1 : Form
    {
        public JocRomana1()
        {
            InitializeComponent();
        }
        private bool finished = false;
        public JocRomana1(bool finished)
        {
            InitializeComponent();
            this.finished = finished;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lalea_Click(object sender, EventArgs e)
        {
            SadLalea.Visible = true;
        }

        private void Ghiocel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var next = new JocRomana2(this.finished);
            next.Location = this.Location;
            next.StartPosition = FormStartPosition.Manual;
            next.ShowDialog();
            this.Close();
        }

        private void Zambila_Click(object sender, EventArgs e)
        {
            SadZambila.Visible = true;
        }

        private void ReadFairy_Click(object sender, EventArgs e)
        {
            string filename = Constants.pathGhiocelul;
            SoundPlayer splayer = new SoundPlayer(filename);
            splayer.Play();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main(3);
            main.Show();
        }
    }
}
