using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VestitoriiPrimaverii
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
            var next = new JocOmSocietate();
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
    }
}
