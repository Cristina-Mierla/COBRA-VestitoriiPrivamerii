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
    public partial class JocMediu3 : Form
    {
        int counter = 0;
        int MAX_BUT = 24;
        Stopwatch stopWatch = new Stopwatch();

        public JocMediu3()
        {
            InitializeComponent();
            stopWatch.Start();
        }

        private void Success()
        {
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            MessageBox.Show("Felicitari!! Esti campion la aducerea primaverii: " + elapsedTime + " secunde. Super tare!");
            this.Close();
            JocTerminat jocTerminat = new JocTerminat(new JocMediuReguli(), new PovesteMate());
            jocTerminat.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Button)sender).Visible = false;
            this.counter++;
            if (this.counter == this.MAX_BUT)
            {
                Success();
            }
        }
    }
}
