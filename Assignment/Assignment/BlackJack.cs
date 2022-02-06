using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class BlackJack : Form
    {

        List<card> cardList = new List<card>()
        {
            new card() { Value  = 0, Name = "null", Image = "null" }
        };

        List<card> dcardList = new List<card>()
        {
            new card() { Value  = 0, Name = "null", Image = "null" }
        };

        int bet;
        int money;
        int cardsum = 0;
        int dcardsum = 0;
        bool stand = false;
        int turn = 3;
        Random rnd = new Random();
        List<int> usedCards = new List<int>();

        #region Deck

        List<card> deck = new List<card>()
        {
            #region spades

            new card() { Value = 2, Name = "Two Spades", Image = @"assets/bj/2S.png" },
            new card() { Value = 3, Name = "Three Spades", Image = @"assets/bj/3S.png" },
            new card() { Value = 4, Name = "Four Spades", Image = @"assets/bj/4S.png" },
            new card() { Value = 5, Name = "Five Spades", Image = @"assets/bj/5S.png" },
            new card() { Value = 6, Name = "Six Spades", Image = @"assets/bj/6S.png" },
            new card() { Value = 7, Name = "Seven Spades", Image = @"assets/bj/7S.png" },
            new card() { Value = 8, Name = "Eight Spades", Image = @"assets/bj/8S.png" },
            new card() { Value = 9, Name = "Nine Spades", Image = @"assets/bj/9S.png" },
            new card() { Value = 10, Name = "Ten Spades", Image = @"assets/bj/10S.png" },
            new card() { Value = 10, Name = "Jack Spades", Image = @"assets/bj/JS.png" },
            new card() { Value = 10, Name = "Queen Spades", Image = @"assets/bj/QS.png" },
            new card() { Value = 10, Name = "King Spades", Image = @"assets/bj/KS.png" },
            new card() { Value = 11, Name = "Ace Spades", Image = @"assets/bj/AS.png" },


            #endregion

            #region heart

            new card() { Value = 2, Name = "Two Hearts", Image = @"assets/bj/2H.png" },
            new card() { Value = 3, Name = "Three Hearts", Image = @"assets/bj/3H.png" },
            new card() { Value = 4, Name = "Four Hearts", Image = @"assets/bj/4H.png" },
            new card() { Value = 5, Name = "Five Hearts", Image = @"assets/bj/5H.png" },
            new card() { Value = 6, Name = "Six Hearts", Image = @"assets/bj/6H.png" },
            new card() { Value = 7, Name = "Seven Hearts", Image = @"assets/bj/7H.png" },
            new card() { Value = 8, Name = "Eight Hearts", Image = @"assets/bj/8H.png" },
            new card() { Value = 9, Name = "Nine Hearts", Image = @"assets/bj/9H.png" },
            new card() { Value = 10, Name = "Ten Hearts", Image = @"assets/bj/10H.png" },
            new card() { Value = 10, Name = "Jack Hearts", Image = @"assets/bj/JH.png" },
            new card() { Value = 10, Name = "Queen Hearts", Image = @"assets/bj/QH.png" },
            new card() { Value = 10, Name = "King Hearts", Image = @"assets/bj/KH.png" },
            new card() { Value = 11, Name = "Ace Hearts", Image = @"assets/bj/AH.png" },

            #endregion

            #region diamonds

            new card() { Value = 2, Name = "Two Diamonds", Image = @"assets/bj/2D.png" },
            new card() { Value = 3, Name = "Three Diamonds", Image = @"assets/bj/3D.png" },
            new card() { Value = 4, Name = "Four Diamonds", Image = @"assets/bj/4D.png" },
            new card() { Value = 5, Name = "Five Diamonds", Image = @"assets/bj/5D.png" },
            new card() { Value = 6, Name = "Six Diamonds", Image = @"assets/bj/6D.png" },
            new card() { Value = 7, Name = "Seven Diamonds", Image = @"assets/bj/7D.png" },
            new card() { Value = 8, Name = "Eight Diamonds", Image = @"assets/bj/8D.png" },
            new card() { Value = 9, Name = "Nine Diamonds", Image = @"assets/bj/9D.png" },
            new card() { Value = 10, Name = "Ten Diamonds", Image = @"assets/bj/10D.png" },
            new card() { Value = 10, Name = "Jack Diamonds", Image = @"assets/bj/JD.png" },
            new card() { Value = 10, Name = "Queen Diamonds", Image = @"assets/bj/QD.png" },
            new card() { Value = 10, Name = "King Diamonds", Image = @"assets/bj/KD.png" },
            new card() { Value = 11, Name = "Ace Diamonds", Image = @"assets/bj/AD.png" },

            #endregion

            #region clubs

            new card() { Value = 2, Name = "Two Clubs", Image = @"assets/bj/2C.png" },
            new card() { Value = 3, Name = "Three Clubs", Image = @"assets/bj/3C.png" },
            new card() { Value = 4, Name = "Four Clubs", Image = @"assets/bj/4C.png" },
            new card() { Value = 5, Name = "Five Clubs", Image = @"assets/bj/5C.png" },
            new card() { Value = 6, Name = "Six Clubs", Image = @"assets/bj/6C.png" },
            new card() { Value = 7, Name = "Seven Clubs", Image = @"assets/bj/7C.png" },
            new card() { Value = 8, Name = "Eight Clubs", Image = @"assets/bj/8C.png" },
            new card() { Value = 9, Name = "Nine Clubs", Image = @"assets/bj/9C.png" },
            new card() { Value = 10, Name = "Ten Clubs", Image = @"assets/bj/10C.png" },
            new card() { Value = 10, Name = "Jack Clubs", Image = @"assets/bj/JC.png" },
            new card() { Value = 10, Name = "Queen Clubs", Image = @"assets/bj/QC.png" },
            new card() { Value = 10, Name = "King Clubs", Image = @"assets/bj/KC.png" },
            new card() { Value = 11, Name = "Ace Clubs", Image = @"assets/bj/AC.png" },


            #endregion
        };

        #endregion

        public BlackJack()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.pagat.com/banking/blackjack.html");
            }
            catch (Exception)
            {
            }
        }


        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGame();
            money = 100;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Main.staticVar.Show();
            this.Close();
        }

        private void displayCardBack(PictureBox picturebox)
        {
            picturebox.ImageLocation = @"assets/bj/b1fv.png";
            picturebox.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void resetGame()
        {
            lbl_act.Text = null;

            displayCardBack(pictureBox1);
            displayCardBack(pictureBox2);
            displayCardBack(pictureBox3);
            displayCardBack(pictureBox4);

            cardsum = 0;
            cardList.Clear();
            usedCards.Clear();

            btn_dd.Enabled = false;
            btn_hit.Enabled = false;
            btn_surrender.Enabled = false;
            btn_stand.Enabled = false;
            btn_deal.Enabled = true;

            lbl_act.Text = "Click Deal when ready";
        }

        private void BlackJack_Load(object sender, EventArgs e)
        {
            resetGame();
            money = int.Parse(lbl_money.Text);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Form_Main.staticVar.Show();
        }

        private int selectRandomCard()
        {
            int randomCard;
            randomCard = rnd.Next(0, deck.Count);
            return randomCard;
        }

        private void wincheck()
        {
            cardsum = 0;
            dcardsum = 0;
            sumcards();
            dsumcards();
            if (cardsum > 21)
            {
                MessageBox.Show(String.Format("The sum of the cards is: {0}, you lose!", cardsum));
                tbx_bet.Text = "0";
                money -= bet;
                lbl_money.Text = money.ToString();
            }

            else if (cardsum == 21)
            {
                MessageBox.Show(String.Format("The sum of the cards is: {0}, you win!", cardsum));
                tbx_bet.Text = "0";
                money += bet;
                lbl_money.Text = money.ToString();
            }
            else if (cardsum > dcardsum && stand == true)
            {
                MessageBox.Show(String.Format("The sum of your cards is: {0}, The sum of the Dealers cards were: {1}, You Win!", cardsum, dcardsum));
                tbx_bet.Text = "0";
                money += bet;
                lbl_money.Text = money.ToString();
            }
            else if (cardsum < dcardsum && stand == true)
            {
                MessageBox.Show(String.Format("The sum of your cards is: {0}, The sum of the Dealers cards were: {1}, You Lose!", cardsum, dcardsum));
                tbx_bet.Text = "0";
                money -= bet;
                lbl_money.Text = money.ToString();
            }
            else
                lbl_act.Text = String.Format("The sum of the cards is: {0}", cardsum);
        }

        private int sumcards()
        {
            for (int i = 0; i < cardList.Count; i++)
            {
                cardsum += cardList[i].Value;
            }
            return cardsum;
        }

        private int dsumcards()
        {
            for (int i = 0; i < dcardList.Count; i++)
            {
                dcardsum += dcardList[i].Value;
            }
            return dcardsum;
        }

        private void btn_deal_Click(object sender, EventArgs e)
        {
            if (cardsum > 0)
            {
                lbl_act.Text = String.Format("Click Reset");
                return;
            }
            else
            {
                btn_dd.Enabled = true;
                btn_hit.Enabled = true;
                btn_surrender.Enabled = true;
                btn_stand.Enabled = true;
                btn_deal.Enabled = false;

                try
                {
                    bet = int.Parse(tbx_bet.Text);
                }
                catch (FormatException ex)
                {
                    lbl_act.Text = "Please enter a valid amount of money";
                    resetGame();
                    return;
                }

                int randomCard1 = selectRandomCard();
                card card1 = deck[randomCard1];
                usedCards.Add(randomCard1);
                int randomCard2 = selectRandomCard();

                if (randomCard1 == randomCard2)
                {
                    randomCard2 = selectRandomCard();
                }
                else
                {
                    randomCard2 = 1 * randomCard2;
                }

                card card2 = deck[randomCard2];
                usedCards.Add(randomCard2);

                cardList.Add(card1);
                cardList.Add(card2);

                pictureBox1.ImageLocation = card1.Image;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

                pictureBox2.ImageLocation = card2.Image;
                pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;

                wincheck();
                dealer();
            }
        }

        private void btn_hit_Click(object sender, EventArgs e)
        {
            if (cardsum == 0)
            {
                lbl_act.Text = String.Format("To Start the game Hit the Deal Button");
                displayCardBack(pictureBox3);
                displayCardBack(pictureBox4);
            }
            else
            {
                if (cardsum > 100)
                {
                    resetGame();
                    lbl_act.Text = "Resetting Game... Click deal when Ready";
                }
                else
                {
                    btn_surrender.Enabled = false;

                    cardsum = 0;
                    int randomcard = selectRandomCard();
                    card Card = deck[randomcard];

                    if (usedCards.Contains(randomcard)) randomcard = selectRandomCard();
                    else
                    {
                        randomcard = 1 * randomcard;
                        usedCards.Add(randomcard);
                    }

                    if (turn == 3)
                    {
                        pictureBox3.ImageLocation = Card.Image;
                        pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
                        cardList.Add(Card);
                        turn++;
                    }
                    else if (turn == 4)
                    {
                        pictureBox4.ImageLocation = Card.Image;
                        pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
                        cardList.Add(Card);
                        turn++;
                    }

                    wincheck();
                    resetGame();

                }
            }
        }

        private void btn_surrender_Click(object sender, EventArgs e)
        {
            if (usedCards.Count > 2)
            {
                money -= bet / 2;
                lbl_money.Text = money.ToString();
                lbl_act.Text = "Your Surrendered!!";
                resetGame();
            }
            else
            {
                btn_surrender.Enabled = false;
            }
        }

        private void btn_dd_Click(object sender, EventArgs e)
        {
            bet = bet * 2;

            cardsum = 0;
            int randomcard = selectRandomCard();
            card Card = deck[randomcard];

            if (usedCards.Contains(randomcard)) randomcard = selectRandomCard();
            else
            {
                randomcard = 1 * randomcard;
                usedCards.Add(randomcard);
            }

            if (usedCards.Count == 3)
            {
                pictureBox3.ImageLocation = Card.Image;
                pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
                cardList.Add(Card);
            }
            else if (usedCards.Count == 4)
            {
                pictureBox4.ImageLocation = Card.Image;
                pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
                cardList.Add(Card);
            }

            stand = true;
            btn_dd.Enabled = false;
            btn_hit.Enabled = false;
            btn_surrender.Enabled = false;

            sumcards();
            wincheck();
            resetGame();
        }

        private void dealer()
        {
            int randomCard1 = selectRandomCard();
            card card1 = deck[randomCard1];
            usedCards.Add(randomCard1);
            int randomCard2 = selectRandomCard();

            if (randomCard1 == randomCard2)
            {
                randomCard2 = selectRandomCard();
            }
            else
            {
                randomCard2 = 1 * randomCard2;
            }

            card card2 = deck[randomCard2];
            usedCards.Add(randomCard2);
            dcardList.Add(card1);
            dcardList.Add(card2);

            dcardsum = 0;
            dsumcards();

            if (dcardsum < 17)
            {
                int randomCard3 = selectRandomCard();
                card card3 = deck[randomCard3];

                if (usedCards.Contains(randomCard3)) randomCard3 = selectRandomCard();
                else
                {
                    randomCard3 = 1 * randomCard3;
                    usedCards.Add(randomCard3);
                    dcardList.Add(card3);
                }
            }

            dcardsum = 0;
            dsumcards();

        }

        private void btn_stand_Click(object sender, EventArgs e)
        {
            stand = true;
            btn_dd.Enabled = false;
            btn_hit.Enabled = false;
            btn_surrender.Enabled = false;

            wincheck();
            resetGame();
        }
    }
}
