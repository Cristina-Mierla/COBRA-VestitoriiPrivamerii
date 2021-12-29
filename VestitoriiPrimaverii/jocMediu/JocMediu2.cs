using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace VestitoriiPrimaverii
{
    public partial class JocMediu2 : Form
    {
        int counter = 0;
        int MAX_BUT = 17;
        Stopwatch stopWatch = new Stopwatch();

        public JocMediu2()
        {
            InitializeComponent();
            stopWatch.Start();
        }

        private void JocMediu2_Load(object sender, EventArgs e)
        {

        }

        private void Success()
        {
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
                ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            MessageBox.Show("Wow! Devii din ce in ce mai bun, doar " + elapsedTime + " secunde. Haide sa vedem urmatoarea provocare de fulgi!");
            this.Hide();
            JocMediu3 f2 = new JocMediu3();
            f2.Show();
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
