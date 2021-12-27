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
using System.Threading;

namespace COBRA_VestotoriiPrivamerii
{

    public partial class Form1 : Form
    {
        int counter = 0;
        int MAX_BUT = 17;
        Stopwatch stopWatch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            stopWatch.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void Success()
        {
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            MessageBox.Show("Bravo: " + elapsedTime + " super!");
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            ((System.Windows.Forms.Button)sender).Visible = false;
            this.counter++;
            if (this.counter == this.MAX_BUT){
                Success();
            }
        }
    }
}
