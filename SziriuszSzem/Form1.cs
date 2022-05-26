using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SziriuszSzem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true; // this will set it on top of everything, including the taskbar
            this.FormBorderStyle = FormBorderStyle.None; // remove the title bar
            this.WindowState = FormWindowState.Maximized; // maximize it to fill the entire screen.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox6.Height = Screen.PrimaryScreen.Bounds.Height / 7;
            pictureBox6.Width = Screen.PrimaryScreen.Bounds.Width / 2;
            pictureBox6.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 4, Screen.PrimaryScreen.Bounds.Height / 14);
            pictureBox2.Height = Screen.PrimaryScreen.Bounds.Height / 12;
            pictureBox2.Width = Screen.PrimaryScreen.Bounds.Width / 4;
            pictureBox2.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 4 + Screen.PrimaryScreen.Bounds.Width / 8, (Screen.PrimaryScreen.Bounds.Height / 12) * 2 + Screen.PrimaryScreen.Bounds.Height / 7);
            pictureBox3.Height = Screen.PrimaryScreen.Bounds.Height / 12;
            pictureBox3.Width = Screen.PrimaryScreen.Bounds.Width / 4;
            pictureBox3.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 4 + Screen.PrimaryScreen.Bounds.Width / 8, (Screen.PrimaryScreen.Bounds.Height / 12) * 4 + Screen.PrimaryScreen.Bounds.Height / 7);
            pictureBox1.Height = Screen.PrimaryScreen.Bounds.Height / 12;
            pictureBox1.Width = Screen.PrimaryScreen.Bounds.Width / 4;
            pictureBox1.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 4 + Screen.PrimaryScreen.Bounds.Width / 8, (Screen.PrimaryScreen.Bounds.Height / 12) * 6 + Screen.PrimaryScreen.Bounds.Height / 7);
            pictureBox4.Height = Screen.PrimaryScreen.Bounds.Height / 12;
            pictureBox4.Width = Screen.PrimaryScreen.Bounds.Width / 4;
            pictureBox4.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 4 + Screen.PrimaryScreen.Bounds.Width / 8, (Screen.PrimaryScreen.Bounds.Height / 12) * 8 + Screen.PrimaryScreen.Bounds.Height / 7);
            pictureBox5.Height = Screen.PrimaryScreen.Bounds.Height / 24;
            pictureBox5.Width = Screen.PrimaryScreen.Bounds.Width / 10;
        }
    }
}
