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
    public partial class JocOmSocietate : Form
    {
        bool allowClick = false;
        PictureBox firstGuess;
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        int time = 60;
        Timer timer = new Timer { Interval = 1000 };

        public JocOmSocietate()
        {
            InitializeComponent();
        }
        private bool finished = false;
        public JocOmSocietate(bool finished)
        {
            InitializeComponent();
            this.finished = finished;
        }

        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }
        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.conservam_apa,
                    Properties.Resources.energie_verde,
                    Properties.Resources.mai_putina_hartie,
                    Properties.Resources.mancam_legume,
                    Properties.Resources.mijloace_transport_verzi,
                    Properties.Resources.planteaza_copaci,
                    Properties.Resources.strange_gunoaiele,
                    Properties.Resources.uda_florile
                };
            }
        }

        private void startGameTimer()
        {
            timer.Start();
            timer.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    timer.Stop();
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Timpul a expirat. Vrei sa incerci din nou?", "Timpul a expirat", buttons);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        JocOmSocietate jocOmSocietate = new JocOmSocietate();
                        jocOmSocietate.Show();
                    }
                    else
                    {
                        this.Hide();
                        Main main = new Main();  
                        main.Show();
                    }
                }
                var ssTime = TimeSpan.FromSeconds(time);
                lblTime.Text = "00: " + time.ToString();
            };
        }
      
        private void HideImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.question;
            }
        }
        private PictureBox getFreeSlot()
        {
            int num;
            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];
        }
        private void setRandomImages()
        {
            foreach (var image in images)
            {
            getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }
        }
        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            HideImages();
            allowClick = true;
            clickTimer.Stop();
        }

        private void clickImage(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;
            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;
            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;
                }
                HideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();
            }
            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            timer.Stop();
            this.Hide();
            if (this.finished)
            {
                JocTerminat jocTerminat = new JocTerminat(new JocOmSocietate(), this.finished);
                jocTerminat.Show();
            }
            else 
            {
                JocTerminat jocTerminat = new JocTerminat(new JocOmSocietate(), new PovTachinare());
                jocTerminat.Show();
            }
        }

        private void startGame(object sender, EventArgs e)
        {
            allowClick = true;
            setRandomImages();
            HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;
            button1.Enabled = false;
        }

        //private void pictureBox17_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Main main = new Main();
        //    main.Show();
        //}
    }
}
