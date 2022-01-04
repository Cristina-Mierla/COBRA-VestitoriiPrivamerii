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
        public Main()
        {
            InitializeComponent();
            this.label1.Text = "Salutare!\nHaide sa ne jucam si sa invatam impreuna. Apasa una dintre imaginile de mai jos pentru a vedea ce suprize ti - am pregatit eu si prietenii mei.\nCe fericita sunt cand vine primvara!";
        }

        //mate
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var next = new PovesteMate();
            this.Hide();
            next.Location = this.Location;
            next.StartPosition = FormStartPosition.Manual;
            //next.FormClosing += delegate { this.Show(); };
            next.ShowDialog();
            this.Close();
        }

        //romana
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var next = new PovesteRo();
            this.Hide();
            next.Location = this.Location;
            next.StartPosition = FormStartPosition.Manual;
            //next.FormClosing += delegate { this.Show(); };
            next.ShowDialog();
            this.Close();
        }

        //mediu
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var next = new PovesteMediu();
            this.Hide();
            next.Location = this.Location;
            next.StartPosition = FormStartPosition.Manual;
            //next.FormClosing += delegate { this.Show(); };
            next.ShowDialog();
            this.Close();
        }

        //om si societate
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var next = new PovSocietate();
            this.Hide();
            next.Location = this.Location;
            next.StartPosition = FormStartPosition.Manual;
            //next.FormClosing += delegate { this.Show(); };
            next.ShowDialog();
            this.Close();
        }

        //tachinare
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var next = new Main();
            this.Hide();
            next.Location = this.Location;
            next.StartPosition = FormStartPosition.Manual;
            //next.FormClosing += delegate { this.Show(); };
            next.ShowDialog();
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Constants.pathIntro;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
