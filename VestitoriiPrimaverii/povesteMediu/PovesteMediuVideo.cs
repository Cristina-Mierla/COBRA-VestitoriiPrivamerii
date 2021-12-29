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
    public partial class PovesteMediuVideo : Form
    {

        private string path;

        public PovesteMediuVideo(string filePath)
        {
            this.path = filePath;   
            InitializeComponent();
        }
        
        public new void Show()
        {
            base.Show();
            axWindowsMediaPlayer1.URL = path;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
