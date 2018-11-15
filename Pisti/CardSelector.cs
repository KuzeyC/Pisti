using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pisti
{
    public partial class CardSelector : Form
    {
        public static string selectedCard = "card design 12";

        public CardSelector()
        {
            InitializeComponent();
            Button[] cards = new Button[12] { bCard1, bCard2, bCard3, bCard4, bCard5, bCard6, bCard7, bCard8, bCard9, bCard10, bCard11, bCard12 };

            for (int i = 0; i <= 11; i++)
            {
                cards[i].Image = Image.FromFile("Pictures/card design " + (i + 1) + ".jpg");
                int index = i;
                cards[i].Click += (sender, args) => bCard_Click(cards[index], index);
            }
        }

        private void bCard_Click(object sender, int e)
        {
            selectedCard = "card design " + (e + 1);
            Close();
        }
    }
}
