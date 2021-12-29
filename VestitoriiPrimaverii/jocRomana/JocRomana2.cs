using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace COBRA_VestotoriiPrivamerii
{
    public partial class JocRomana2 : Form
    {
        public JocRomana2()
        {
            InitializeComponent();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

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
            this.Close();
        }

        private void ReadFairy_Click(object sender, EventArgs e)
        {
            string filename = AppDomain.CurrentDomain.BaseDirectory + "Randunica.wav";
            SoundPlayer splayer = new SoundPlayer(filename);
            splayer.Play();
        }
    }
}
