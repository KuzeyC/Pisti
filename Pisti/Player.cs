using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisti
{
    class Player
    {
        public string[] Hand;
        public int Score;
        public string[] CollectedCards;
        public int NoOfCards;

        public Player()
        {
            Hand = new string[] { "", "", "", "" };
            Score = 0;
            CollectedCards = new string[52];
            NoOfCards = 0;
        }
    }
}
