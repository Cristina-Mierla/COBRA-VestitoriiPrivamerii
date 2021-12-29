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
    public partial class JocMediuReguli : Form
    {
        public JocMediuReguli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            JocMediu1 f2 = new JocMediu1();
            f2.Show();
        }
    }
}
