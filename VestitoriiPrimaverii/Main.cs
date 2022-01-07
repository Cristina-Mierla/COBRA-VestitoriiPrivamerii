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
    public partial class Main : Form
    {
        private bool play = false;
        private bool finished = false;
        public Main()
        {
            InitializeComponent();
            this.label1.Text = "Salutare!\nHaide sa ne jucam si sa invatam impreuna. Apasa una dintre imaginile de mai jos pentru a vedea ce suprize ti - am pregatit eu si prietenii mei.\nCe fericita sunt cand vine primvara!";
        }

        public Main (bool play, bool finished)
        {
            InitializeComponent();
            this.label1.Text = "Salutare!\nHaide sa ne jucam si sa invatam impreuna. Apasa una dintre imaginile de mai jos pentru a vedea ce suprize ti - am pregatit eu si prietenii mei.\nCe fericita sunt cand vine primvara!";
            this.play = play;
            this.finished = finished;
        }

        public Main (bool finished)
        {
            InitializeComponent();
            this.label1.Text = "Salutare!\nHaide sa ne jucam si sa invatam impreuna. Apasa una dintre imaginile de mai jos pentru a vedea ce suprize ti - am pregatit eu si prietenii mei.\nCe fericita sunt cand vine primvara!";
            this.finished = finished;
            if (finished)
            {
                this.pictureBox2.Visible = true;
                this.pictureBox3.Visible = true;
                this.pictureBox4.Visible = true;
                this.pictureBox5.Visible = true;
                this.pictureBox7.Visible = true;
            }
        }

        //mate
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var next = new PovesteMate(this.finished);
            this.Hide();
            next.Show();
        }

        //romana
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var next = new PovesteRo(this.finished);
            this.Hide();
            next.Show();
        }

        //mediu
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var next = new PovesteMediu(this.finished);
            this.Hide();
            next.Show();
        }

        //om si societate
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var next = new PovSocietate(this.finished);
            this.Hide();
            next.Show();
        }

        //tachinare
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var next = new PovTachinare();
            this.Hide();
            next.Show();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            if (this.play)
            {
                axWindowsMediaPlayer1.URL = Constants.pathIntro;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void Main_VisibleChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var next = new JocOmSocietate0();
            this.Hide();
            next.Show();
        }
    }
}
