using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pisti
{
    public partial class Menu : Form
    {
        private Pisti pistiGame;

        public Menu()
        {
            InitializeComponent();
        }

        private void bEasyMode_Click(object sender, EventArgs e)
        {
            Game.difficulty = 1;
            pistiGame = new Pisti();
            pistiGame.ShowDialog();
        }

        private void bMediumMode_Click(object sender, EventArgs e)
        {
            Game.difficulty = 2;
            pistiGame = new Pisti();
            pistiGame.ShowDialog();
        }

        private void bHardMode_Click(object sender, EventArgs e)
        {
            Game.difficulty = 3;
            pistiGame = new Pisti();
            pistiGame.ShowDialog();
        }

        private void bExtreme_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Achievements.txt");
            string currentAchievements = sr.ReadToEnd();
            sr.Close();
            if (currentAchievements.Contains("a5"))
            {
                Game.difficulty = 4;
                pistiGame = new Pisti();
                pistiGame.ShowDialog();
            }
            else
            {
                MessageBox.Show("Beat the computer in hard difficulty to unlock extreme.");
            }
        }

        private void bHowToPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A turn consists of playing one card from your hand on top of the discard pile.\nIf the rank of the played card matches the rank of the played card on the pile, the playing player collects the whole pile.\nThe collected cards are stored next to the player that collected the pile.\nThe next player will then start a new discard pile by playing a card on to the empty board. Playing a jack also captures the whole pile, no matter what card is on top of the pile.\nIf the played card is not a jack nor the rank is not equal to the previous top card of the pile, the played card is simply added to the top of the pile.\nThe player which makes the first capture also gets the cards which were dealt to the centre of the table.\n\nWhen both the players have played their four cards, the game will deal another batch of four cards to each player from the stock(but no more to the centre of the table) and game continues.\nWhen these cards are played, the game deals a further batch of four cards each.\nWhen everyone has played their last four cards, any cards remaining in the discard pile are given to the last player that made a capture.\nThe game is now over, and the players score for the cards they have captured.\n\nEach Jack = 1 points\nEach Ace = 1 points\n2 of Clubs = 2 points\n10 of Diamonds = 3 points\nMajority of cards = 3 points\nEach Pişti = 10 points");
        }

        private void bLeaderboard_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard();
            leaderboard.ShowDialog();
        }

        private void bAchievements_Click(object sender, EventArgs e)
        {
            Achievements achievements = new Achievements();
            achievements.ShowDialog();
        }

        private void bCardDesign_Click(object sender, EventArgs e)
        {
            CardSelector selectCard = new CardSelector();
            selectCard.ShowDialog();
        }
    }
}
