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
        public JocTerminat(Form fromJoc)
        {
            this.formJoc = fromJoc;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formJoc.Show();
        }
    }
}
