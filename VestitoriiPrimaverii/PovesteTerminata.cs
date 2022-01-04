using System;
using System.Windows.Forms;

namespace VestitoriiPrimaverii.povesteMediu
{
    public partial class PovesteTerminata : Form
    {

        private Form formPoveste;
        private Form formJoc;

        public PovesteTerminata(Form formPoveste, Form formJoc)
        {
            this.formPoveste = formPoveste;
            this.formJoc = formJoc;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formJoc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formPoveste.Show();    
        }
    }
}
