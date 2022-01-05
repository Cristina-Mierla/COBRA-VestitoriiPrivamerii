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
    public partial class JocTerminat : Form
    {
        private Form formJoc;
        private Form nextJoc;
        private bool notfinal = true;
        private bool finished = false;
        public JocTerminat(Form fromJoc, Form nextJoc)
        {
            this.formJoc = fromJoc;
            this.nextJoc = nextJoc;
            InitializeComponent();
            if (this.notfinal == true)
            {
                this.button3.Visible = true;
            }
            else
            {
                this.finished = true;
            }
        }

        public JocTerminat(Form fromJoc, bool final)
        {
            this.formJoc = fromJoc;
            this.notfinal = final;
            InitializeComponent();
            if (this.notfinal == true)
            {
                this.button3.Visible = true;
            }
            else
            {
                this.finished = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            this.Hide();
            Main main = new Main(this.finished);
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formJoc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.nextJoc.Show();
        }
    }
}
