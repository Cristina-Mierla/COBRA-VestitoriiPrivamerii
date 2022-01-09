﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VestitoriiPrimaverii
{
    public partial class JocOmSocietate0 : Form
    {
        bool allowClick = false;
        PictureBox firstGuess;
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        int time = 20;
        Timer timer = new Timer { Interval = 1000 };
        bool stopMessage = false;
        bool firstTime = true;

        public JocOmSocietate0()
        {
            InitializeComponent();
        }

        public JocOmSocietate0(bool finished)
        {
            InitializeComponent();
            this.finished = finished;
        }
        private bool finished = false;
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
                };
            }
        }

        private void startGameTimer()
        {
            timer.Start();
            timer.Tick += delegate
            {
                time--;
                if (time < 0 && stopMessage == false)
                {
                    timer.Stop();
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Timpul a expirat. Vrei sa incerci din nou?", "Timpul a expirat", buttons);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        JocOmSocietate0 jocOmSocietate = new JocOmSocietate0();
                        jocOmSocietate.Show();
                    }
                    else
                    {
                        this.Hide();
                        Main main = new Main(4);
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
                if (pic != pictureBox5)
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
            while (pictureBoxes[num].Tag != null || pictureBoxes[num] == pictureBox5);
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
            if (firstTime == true)
            {
                startGameTimer();
                firstTime = false;
            }
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
            if (pictureBoxes.Any(p => p.Visible && p != pictureBox5)) return;
            timer.Stop();

            pictureBox5.Visible = true;
            stopMessage = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            JocOmSocietate1 main = new JocOmSocietate1();
            main.Show();
        }

        private void JocOmSocietate0_Load(object sender, EventArgs e)
        {
            allowClick = true;
            setRandomImages();
            HideImages();
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main(4);
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Hide();
            Main main = new Main(4);
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Hide();
            JocOmSocietate0 joc = new JocOmSocietate0();
            joc.Show();
        }
    }

}