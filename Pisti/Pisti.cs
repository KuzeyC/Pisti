using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Pisti
{
    public partial class Pisti : Form
    {
        private Game MainGame = new Game();
        private string ImagePath = "Pictures/";
        public static string achievementList = File.ReadAllText("Achievements.txt");

        public Pisti()
        {
            if (MainGame.AllHandsEmpty())
            {
                MainGame.DealFromDeck();
            }
            InitializeComponent();
            pbPlayerCollectedCards.Image = Image.FromFile(ImagePath + CardSelector.selectedCard + ".jpg");
            pbComputerCollectedCards.Image = Image.FromFile(ImagePath + CardSelector.selectedCard + ".jpg");
            pbRemainingCards.Image = Image.FromFile(ImagePath + CardSelector.selectedCard + ".jpg");
            UpdateGame();
        }

        private void PlayerCard1_Click(object sender, EventArgs e)
        {
            if (bPlayerCard1.Image != null)
            {
                bPlayerCard1.Image = null;
                AdvanceGame(0);
            }
        }

        private void PlayerCard2_Click(object sender, EventArgs e)
        {
            if (bPlayerCard2.Image != null)
            {
                bPlayerCard2.Image = null;
                AdvanceGame(1);
            }
        }

        private void PlayerCard3_Click(object sender, EventArgs e)
        {
            if (bPlayerCard3.Image != null)
            {
                bPlayerCard3.Image = null;
                AdvanceGame(2);
            }
        }

        private void PlayerCard4_Click(object sender, EventArgs e)
        {
            if (bPlayerCard4.Image != null)
            {
                bPlayerCard4.Image = null;
                AdvanceGame(3);
            }

        }

        private void AdvanceGame(int a)
        {
            string topCard = MainGame.TopCard();
            string playedCard = MainGame.MakeMove(0, a);
            UpdateGame();
            MainGame.IsPlayRelevant(playedCard, topCard, 0);

            topCard = MainGame.TopCard();
            playedCard = MainGame.MakeMove(1, MainGame.ComputerPlay());
            UpdateGame();
            MainGame.IsPlayRelevant(playedCard, topCard, 1);
            UpdateGame();

            if (MainGame.GameOver())
            {
                UpdateGame();
                MessageBox.Show(MainGame.CalculateWinner());
                MainGame.UnlockAchievement();
                InputName InputName = new InputName();
                InputName.ShowDialog();
                Close();
            }
            else if (MainGame.AllHandsEmpty() && !MainGame.GameOver())
            {
                MainGame.DealFromDeck();
                UpdateGame();
            }
        }

        private void UpdateGame()
        {
            Button[] playerCards = new Button[4] { bPlayerCard1, bPlayerCard2, bPlayerCard3, bPlayerCard4 };
            PictureBox[] computerCards = new PictureBox[4] { pbComputerCard1, pbComputerCard2, pbComputerCard3, pbComputerCard4 };
            string card;

            for (int i = 0; i <= 3; i++)
            {
                card = MainGame.CheckHand(0, i);
                if (card == "")
                    playerCards[i].Image = null;
                else
                    playerCards[i].Image = Image.FromFile(ImagePath + card + ".jpg");

                card = MainGame.CheckHand(1, i);
                if (card == "")
                    computerCards[i].Image = null;
                else
                    computerCards[i].Image = Image.FromFile(ImagePath + CardSelector.selectedCard + ".jpg");
            }

            if (MainGame.TopCard() == "NOTHING")
                pbCentreCards.Image = null;
            else
                pbCentreCards.Image = Image.FromFile(ImagePath + MainGame.TopCard() + ".jpg");

            tbComputerCollectedNum.Text = MainGame.Players[1].NoOfCards.ToString();
            tbPlayerCollectedNum.Text = MainGame.Players[0].NoOfCards.ToString();

            tbRemainingCardsNum.Text = Game.Deck.Count.ToString();

            tbCentreCardsNum.Text = Game.CentreCards.Count.ToString();
        }
    }
}
