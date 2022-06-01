using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SziriuszSzemBG
{
    internal class Card
    {
        private string name;
        private Bitmap image;
        private int hp;
        private int damage;

        public Card(string name, string imagePath, int hp, int damage)
        {
            this.name = name;
            this.image = new Bitmap(imagePath);
            this.hp = hp;
            this.damage = damage;
        }


    }
}
