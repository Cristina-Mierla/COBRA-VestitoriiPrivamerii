﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VestitoriiPrimaverii
{
    public partial class PovesteMediuVideo : Form
    {

        private string path;
        private PovesteMediu povesteMediu;

        public PovesteMediuVideo(PovesteMediu povesteMediu, string filePath)
        {
            this.povesteMediu = povesteMediu;
            this.path = filePath;   
            InitializeComponent();
        }
        
        public new void Show()
        {
            base.Show();
            axWindowsMediaPlayer1.URL = path;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void PovesteMediuVideo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.povesteMediu.checkIfFinished(); 
        }
    }
}