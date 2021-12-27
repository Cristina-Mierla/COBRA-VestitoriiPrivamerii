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
    public partial class JocMate1 : Form
    {
        private bool option = false;
        private static void Make_visible(List<Control> widgets)
        {
            foreach (Control obj in widgets)
            {
                obj.Visible = true;
            }
        }

        private static void Make_invisible(List<Control> widgets)
        {
            foreach (Control obj in widgets)
            {
                obj.Visible = false;
            }
        }
        public JocMate1()
        {
            InitializeComponent();
        }

        //8
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            List<Control> widgets = new List<Control>();
            widgets.Add(pictureBox6);
            label2.Text = "BRAVO!! Da click pe mine pentru urmatorul joc!";
            widgets.Add(label2);
            widgets.Add(pictureBox7);
            Make_visible(widgets);

            List<Control> invsWidgets = new List<Control>();
            invsWidgets.Add(pictureBox4);
            invsWidgets.Add(pictureBox3);
            invsWidgets.Add(pictureBox2);
            Make_invisible(invsWidgets);


            option = true;
        }

        //7
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            List<Control> widgets = new List<Control>();
            widgets.Add(pictureBox5);
            label2.Text = "Da click pe mine si hai sa mai incearcam o data!";
            widgets.Add(label2);
            widgets.Add(pictureBox7);
            Make_visible(widgets);

            List<Control> invsWidgets = new List<Control>();
            invsWidgets.Add(pictureBox4);
            invsWidgets.Add(pictureBox3);
            invsWidgets.Add(pictureBox2);
            Make_invisible(invsWidgets);

            option = true;
        }

        //4
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            List<Control> widgets = new List<Control>();
            widgets.Add(pictureBox5);
            label2.Text = "Da click pe mine si hai sa mai incearcam o data!";
            widgets.Add(label2);
            widgets.Add(pictureBox7);
            Make_visible(widgets);

            List<Control> invsWidgets = new List<Control>();
            invsWidgets.Add(pictureBox4);
            invsWidgets.Add(pictureBox3);
            invsWidgets.Add(pictureBox2);
            Make_invisible(invsWidgets);

            option = true;
        }

        //sad flower
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (option == true)
            {
                option = false;
                List<Control> widgets = new List<Control>();
                widgets.Add(label2);
                widgets.Add(pictureBox7);
                widgets.Add(pictureBox5);
                Make_invisible(widgets);

                List<Control> visWidgets = new List<Control>();
                visWidgets.Add(pictureBox4);
                visWidgets.Add(pictureBox3);
                visWidgets.Add(pictureBox2);
                Make_visible(visWidgets);
            }
        }

        //happy flower
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (option == true)
            {
                var next = new JocMate1();
                this.Hide();
                next.Location = this.Location;
                next.StartPosition = FormStartPosition.Manual;
                //next.FormClosing += delegate { this.Show(); };
                next.ShowDialog();
                this.Close();

                option = false;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void JocMate1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
