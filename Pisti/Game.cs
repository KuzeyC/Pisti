using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pisti
{
    class Game
    {

        public Player[] Players;
        public static Stack CentreCards;
        public static Stack Deck;
        private static Deck SetOfCards;
        private int lastCollected = 0;
        private string topcard;
        public static int difficulty;
        public static int finalScore;
        public static Dictionary<char, int> dict = new Dictionary<char, int>()
        {
            {'A', 0 }, {'1', 0},  {'2', 0 }, {'3', 0}, {'4', 0}, {'5', 0}, {'6', 0}, {'7', 0}, {'8', 0}, {'9', 0}, {'J', 0}, {'Q', 0}, {'K', 0}
        };
        
        public Game()
        {
            CentreCards = new Stack();
            Deck = new Stack();
            SetOfCards = new Deck();
            Players = new Player[2];
            Players[0] = new Player();
            Players[1] = new Player();
            SetOfCards.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Deck.Push(SetOfCards.deck[i]);
            }
            DealToCentre();
            topcard = CentreCards.Peek().ToString();
            while (topcard[0] == 'J')
            {
                SetOfCards.Shuffle();
                Deck = new Stack();
                CentreCards = new Stack();
                for (int i = 0; i < 52; i++)
                {
                    Deck.Push(SetOfCards.deck[i]);
                }
                DealToCentre();
                topcard = CentreCards.Peek().ToString();
            }
        }

        private void DealToCentre()
        {
            for (int i = 0; i <= 3; i++)
            {
                CentreCards.Push(Deck.Pop());
            }
        }

        public string TopCard()
        {
            if (CentreCards.Count != 0)
            {
                return CentreCards.Peek().ToString();
            }
            else
            {
                return "NOTHING";
            }
        }

        public void DealFromDeck()
        {
            for (int i = 0; i <= 3; i++)
            {
                Players[0].Hand[i] = Deck.Pop().ToString();
                Players[1].Hand[i] = Deck.Pop().ToString();
                if (difficulty == 4)
                {
                    dict[Players[1].Hand[i][0]]++;
                }
            }
        }

        public string CheckHand(int player, int slotNum)
        {
            return Players[player].Hand[slotNum];
        }

        private int CardsInHand()
        {
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                if (Players[1].Hand[i] != "")
                    count++;
            }
            return count;
        }

        public int ComputerPlay()
        {
            string playingcard;
            Random rand = new Random();
            int randNum = rand.Next(0, 4);
            if (difficulty == 1)
            {
                while (Players[1].Hand[randNum] == "")
                {
                    rand = new Random();
                    randNum = rand.Next(0, 4);
                }
                return randNum;
            }
            else if (difficulty == 2)
            {
                topcard = TopCard();
                for (int i = 0; i <= 3; i++)
                {
                    playingcard = Players[1].Hand[i];
                    if (playingcard != "" && topcard != "")
                    {
                        if (topcard[0] == playingcard[0])
                        {
                            return i;
                        }
                    }
                }
                while (Players[1].Hand[randNum] == "")
                {
                    rand = new Random();
                    randNum = rand.Next(0, 4);
                }
                return randNum;
            }
            else if (difficulty == 3)
            {
                topcard = TopCard();
                for (int i = 0; i <= 3; i++)
                {
                    playingcard = Players[1].Hand[i];
                    if (playingcard != "" && topcard != "")
                    {
                        if (topcard[0] == playingcard[0])
                        {
                            return i;
                        }
                        else if (playingcard[0] == 'J' && CentreCards.Count > 5)
                        {
                            return i;
                        }
                    }
                }

                string check = "";
                while (check == "")
                {
                    rand = new Random();
                    randNum = rand.Next(0, 4);
                    check = Players[1].Hand[randNum];
                    if (check != "")
                    {
                        if (check[0] == 'J' && CardsInHand() > 1)
                        {
                            check = "";
                        }
                    }
                }
                return randNum;
            }
            else if (difficulty == 4)
            {
                string topcard = TopCard();
                for (int i = 0; i <= 3; i++)
                {
                    playingcard = Players[1].Hand[i];
                    if (playingcard != "" && topcard != "")
                    {
                        if (topcard[0] == playingcard[0])
                        {
                            return i;
                        }
                        else if (playingcard[0] == 'J' && CentreCards.Count > 5)
                        {
                            return i;
                        }
                    }
                }

                for (int i = 4; i > 0; i--)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        playingcard = Players[1].Hand[j];
                        if (playingcard != "")
                        {
                            if (CardsInHand() == 1 || (dict[playingcard[0]] == i && playingcard[0] != 'J'))
                            {
                                return j;
                            }
                        }
                    }
                }
            }
            return 0;
        }

        public string MakeMove(int player, int slotNum)
        {
            string slot = Players[player].Hand[slotNum];
            Players[player].Hand[slotNum] = "";
            topcard = TopCard();
            if (difficulty == 4 && player == 0)
            {
                dict[slot[0]]++;
            }
            CentreCards.Push(slot);
            return slot;
        }

        public void IsPlayRelevant(string playedCard, string middleCard, int player)
        {
            if (playedCard[0] == middleCard[0] && CentreCards.Count == 2)
            {
                MessageBox.Show("Pisti");
                Players[player].Score += 10;
                CollectCards(player);
            }
            else if (playedCard[0] == middleCard[0] || playedCard[0] == 'J')
            {
                CollectCards(player);
            }
        }

        public void CollectCards(int player)
        {
            string collectedCards = "";
            while (CentreCards.Count > 0)
            {
                collectedCards += ", " + CentreCards.Peek().ToString();
                Players[player].CollectedCards[Players[player].NoOfCards] = CentreCards.Pop().ToString();
                Players[player].NoOfCards++;
            }
            if (player == 1)
            {
                MessageBox.Show("Computer collected the centre pile.");
            }
            else
            {
                MessageBox.Show("You collected" + collectedCards + ".");
            }
            lastCollected = player;
        }

        public bool AllHandsEmpty()
        {
            for (int i = 0; i <= 1; i++)
            {
                for (int b = 0; b <= 3; b++)
                {
                    if (Players[i].Hand[b] != "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool GameOver()
        {
            if (Deck.Count == 0 && AllHandsEmpty())
            {
                return true;
            }
            return false;
        }

        public string CalculateWinner()
        {
            CollectCards(lastCollected);
            for (int a = 0; a <= 1; a++)
            {
                for (int b = 0; b <= Players[a].NoOfCards - 1; b++)
                {
                    string temp = Players[a].CollectedCards[b];
                    if (temp[0] == 'A' || temp[0] == 'J')
                    {
                        Players[a].Score += 1;
                    }
                    else if (temp == "2 Clubs")
                    {
                        Players[a].Score += 2;
                    }
                    else if (temp == "10 Diamonds")
                    {
                        Players[a].Score += 3;
                    }
                }
            }
            if (Players[0].NoOfCards > Players[1].NoOfCards)
            {
                Players[0].Score += 3;
            }
            else if (Players[1].NoOfCards > Players[0].NoOfCards)
            {
                Players[1].Score += 3;
            }
            finalScore = Players[0].Score;
            if (Players[0].Score > Players[1].Score)
            {
                return "You win with " + Players[0].Score + " points. Computer collected " + Players[1].Score + " points.";
            }
            else if (Players[1].Score > Players[0].Score)
            {
                return "Computer wins with " + Players[1].Score + " points. You collected " + Players[0].Score + " points.";
            }
            else
            {
                return "The game is a tie. Computer collected " + Players[1].Score + " points. You collected " + Players[0].Score + " points.";
            }
        }

        public void UnlockAchievement()
        {
            StreamReader sr = new StreamReader("Achievements.txt");
            string currentAchievements = sr.ReadToEnd();
            sr.Close();
            StreamWriter sw = new StreamWriter("Achievements.txt", true);
            if (Players[0].Score > Players[1].Score && difficulty == 1 && !currentAchievements.Contains("a1"))
            {
                MessageBox.Show("Achievement Unlocked: You have beaten the computer on Easy Difficulty.");
                sw.WriteLine("a1");
            }
            if (Players[1].Score > Players[0].Score && difficulty == 1 && !currentAchievements.Contains("a2"))
            {
                MessageBox.Show("Achievement Unlocked: You lost on Easy Difficulty.");
                sw.WriteLine("a2");
            }
            if (Players[0].Score > Players[1].Score && difficulty == 2 && !currentAchievements.Contains("a3"))
            {
                MessageBox.Show("Achievement Unlocked: You have beaten the computer on Medium Difficulty.");
                sw.WriteLine("a3");
            }
            if (Players[1].Score > Players[0].Score && difficulty == 2 && !currentAchievements.Contains("a4"))
            {
                MessageBox.Show("Achievement Unlocked: You lost on Medium Difficulty.");
                sw.WriteLine("a4");
            }
            if (Players[0].Score > Players[1].Score && difficulty == 3 && !currentAchievements.Contains("a5"))
            {
                MessageBox.Show("Achievement Unlocked: You have beaten the computer on Hard Difficulty.");
                sw.WriteLine("a5");
            }
            if (Players[1].Score > Players[0].Score && difficulty == 3 && !currentAchievements.Contains("a6"))
            {
                MessageBox.Show("Achievement Unlocked: You lost on Hard Difficulty.");
                sw.WriteLine("a6");
            }
            if (Players[0].Score > Players[1].Score && difficulty == 4 && !currentAchievements.Contains("a7"))
            {
                MessageBox.Show("Achievement Unlocked: You have beaten the computer on Extreme Difficulty.");
                sw.WriteLine("a7");
            }
            if (Players[1].Score > Players[0].Score && difficulty == 4 && !currentAchievements.Contains("a8"))
            {
                MessageBox.Show("Achievement Unlocked: You lost on Extreme Difficulty.");
                sw.WriteLine("a8");
            }
            if (Players[0].Score == Players[1].Score && !currentAchievements.Contains("a9"))
            {
                MessageBox.Show("Achievement Unlocked: You tied with the Computer.");
                sw.WriteLine("a9");
            }
            if (Players[0].Score == 0 && !currentAchievements.Contains("a10"))
            {
                MessageBox.Show("Achievement Unlocked: You got 0 points.");
                sw.WriteLine("a10");
            }
            if (Players[1].Score == 0 && !currentAchievements.Contains("a11"))
            {
                MessageBox.Show("Achievement Unlocked: Computer got 0 points.");
                sw.WriteLine("a11");
            }
            sw.Close();
        }
    }
}
