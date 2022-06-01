using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SziriuszSzemBG
{
    public partial class BasicGame : Form
    {
        private FormWindowState winState;
        private FormBorderStyle brdStyle;
        private bool topMost;
        private Rectangle bounds;

        private Size cardSizeOriginal;
        private Size cardSizeMax;
        private float enlargeMultiplier = 1.4f;
        private int cardXPosOffset;
        private int cardYPosOffset;
        private bool early = true;

        private List<Card> cards;
        private List<Card> captains;
        private Bitmap cardBack;
        private Bitmap hpBar;
        

        private void LoadCaptains()
        {
            captains = new List<Card>()
            {
                new Card("Bertalan", @"Capitains\berci.png", 65, 0),
                new Card("Dzsínó", @"Capitains\dzsino.png", 50, 0),
                new Card("Rugós Beke", @"Capitains\beke.png", 35, 0)
            };
        }

        private void LoadCards()
        {
            cards = new List<Card>()
            {
                new Card("Asztronauta", @"Cards\astronauta_1.png", 5, 2),
                new Card("Robotpilóta", @"Cards\robotpilota_1.png", 8, 4),
                new Card("Űrkalóz", @"Cards\urkaloz_1.png", 13, 6),
                new Card("Műhold", @"Cards\muhold_1.png", 10, 1)
            };
        }

        private void LoadData()
        {
            LoadCaptains();
            LoadCards();
            cardBack = new Bitmap("Cards/flippedcards.png");
            hpBar = new Bitmap("Cards/hp_bar.png");
        }



        public BasicGame()
        {
            InitializeComponent();
            this.TopMost = true; // this will set it on top of everything, including the taskbar
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.FormBorderStyle = FormBorderStyle.None; // remove the title bar
            this.WindowState = FormWindowState.Maximized; // maximize it to fill the entire screen.

            cardSizeOriginal = pictureBox5.Size;
            int width = (int)(cardSizeOriginal.Width * enlargeMultiplier);
            int height = (int)(cardSizeOriginal.Height * enlargeMultiplier);
            cardSizeMax = new Size(width, height);
            cardXPosOffset = (cardSizeMax.Width - cardSizeOriginal.Width) / 2;
            cardYPosOffset = cardSizeMax.Height - cardSizeOriginal.Height;
            //MessageBox.Show(pictureBox5.Size.Width + " " + pictureBox5.Size.Height);

            //LoadData();

            //MessageBox.Show((ParentForm as SziriuszSzemMenu.Menu).level);
        }

        private void CardEnlarge_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show(pictureBox5.Size.Width + " " + pictureBox5.Size.Height);
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.Size = cardSizeMax;
            pictureBox.Left -= cardXPosOffset;
            pictureBox.Top -= cardYPosOffset;
            Thread.Sleep(10);
            early = false;
        }

        private void CardMinimize_MouseLeave(object sender, EventArgs e)
        {
            if (!early)
            {
                PictureBox pictureBox = sender as PictureBox;
                pictureBox.Top += cardYPosOffset;
                pictureBox.Left += cardXPosOffset;
                pictureBox.Size = cardSizeOriginal;
                early = true;
            }
        }
    }
}
