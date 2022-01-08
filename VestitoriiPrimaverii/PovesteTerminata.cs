using System;
using System.Windows.Forms;

namespace VestitoriiPrimaverii.povesteMediu
{
    public partial class PovesteTerminata : Form
    {
        private int step;
        private Form formPoveste;
        private Form formJoc;

        public PovesteTerminata(Form formPoveste, Form formJoc, int step)
        {
            this.formPoveste = formPoveste;
            this.formJoc = formJoc;
            this.step = step;
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formJoc.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main(step);
            main.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formPoveste.Show();
        }
    }
}
