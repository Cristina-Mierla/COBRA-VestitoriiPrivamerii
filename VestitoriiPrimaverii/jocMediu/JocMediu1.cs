using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace VestitoriiPrimaverii
{
    public partial class JocMediu1 : Form
    {
        int counter = 0;
        int MAX_BUT = 9;
        Stopwatch stopWatch = new Stopwatch();

        public JocMediu1()
        {
            InitializeComponent();
            stopWatch.Start();
        }
        private bool finished = false;
        public JocMediu1(bool finished)
        {
            InitializeComponent();
            this.finished = finished;
            stopWatch.Start();
        }

        private void JocMediu1_Load(object sender, EventArgs e)
        {

        }
        private void Success()
        {
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            MessageBox.Show("Bravo! Ai reusit sa cureti fulgii de zapada in " + elapsedTime + " secunde. Super!");
            this.Hide();
            JocMediu2 f2 = new JocMediu2(this.finished);
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ((Button)sender).Visible = false;
            this.counter++;
            if (this.counter == this.MAX_BUT)
            {
                Success();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main(1);
            main.Show();
        }
    }
}
