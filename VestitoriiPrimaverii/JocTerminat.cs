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
    public partial class JocTerminat : Form
    {
        private Form formJoc;
        private Form nextJoc;
        private bool final = false;
        public JocTerminat(Form fromJoc, Form nextJoc)
        {
            this.formJoc = fromJoc;
            this.nextJoc = nextJoc;
            InitializeComponent();
            if (this.final ==  false)
            {
                this.pictureBox5.Visible = true;
            }
        }

        public JocTerminat(Form fromJoc, bool final)
        {
            this.formJoc = fromJoc;
            this.final = final;
            InitializeComponent();
            if (this.final == false)
            {
                this.pictureBox5.Visible = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formJoc.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!final)
            {
                this.Hide();
                this.nextJoc.Show();
            }
            else
            {
                this.Hide();
                Main main = new Main(false, true);
                main.Show();
            }
        }
    }
}
