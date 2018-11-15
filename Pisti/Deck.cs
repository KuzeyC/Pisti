using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pisti
{
    class Deck
    {
        public Card[] deck;
        private Random random;
        
        public Deck()
        {
            string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] suits = { " Hearts", " Clubs", " Diamonds", " Spades" };
            deck = new Card[52];
            for (int count = 0; count < deck.Length; count++)
            {
                deck[count] = new Card(ranks[count % 13], suits[count / 13]);
            }
        }
        
        public void Shuffle()
        {
            random = new Random();
            for (int first = 0; first < deck.Length; first++)
            {
                int second = random.Next(52);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }
        
        public class Card
        {
            public string rank;
            public string suit;
            
            public Card(string cardRank, string cardSuit)
            {
                rank = cardRank;
                suit = cardSuit;
            }
            
            public override string ToString()
            {
                return rank + suit;
            }
        }
    }
}
