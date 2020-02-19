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

namespace Special_Project_2
{
    public partial class Form1 : Form
    {
        // Lists that contain objects useful for editing en masse
        public List<System.Windows.Forms.Label> player1CardLabels = new List<System.Windows.Forms.Label>();
        public List<System.Windows.Forms.Label> player2CardLabels = new List<System.Windows.Forms.Label>();

        public int timeLeft = 5;
        public int whosTurn = 1;
        public int round = 1;
        int random = 1;
        int deckSize = 52;
        Random rand = new Random();
        List<Card> Deck = new List<Card>();
        Card currCard = new Card();

        public Form1()
        {
            InitializeComponent();

            // Add player 1's card labels to a list
            player1CardLabels.Add(lbl_Player1Card1);
            player1CardLabels.Add(lbl_Player1Card2);
            player1CardLabels.Add(lbl_Player1Card3);
            player1CardLabels.Add(lbl_Player1Card4);
            player1CardLabels.Add(lbl_Player1Card5);

            // Add player 2's card labels to a list
            player2CardLabels.Add(lbl_Player2Card1);
            player2CardLabels.Add(lbl_Player2Card2);
            player2CardLabels.Add(lbl_Player2Card3);
            player2CardLabels.Add(lbl_Player2Card4);
            player2CardLabels.Add(lbl_Player2Card5);

            BuildDeck();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            foreach (var item in player1CardLabels)
                item.Text = "";
            foreach (var item in player2CardLabels)
                item.Text = "";

            // Hide cards/game text from sight
            lbl_Player1Turn.Visible = true;
            lbl_Player2Turn.Visible = true;
            pb_HidePlayer1Cards.Visible = true;
            pb_HidePlayer2Cards.Visible = true;
            lbl_GameTxt.Text = "";

            // Countdown to player 1's turn
            whosTurn = 1;
            timeLeft = 5;
            timer_TurnStart.Start();
        }

        private void timer_TurnStart_Tick(object sender, EventArgs e)
        {
            if (whosTurn == 1) // If player 1's turn...
            {
                lbl_Player1Turn.Text = $"{timeLeft} second(s)...";
                timeLeft--;
            }
            else if (whosTurn == 2) // If player 2's turn...
            {
                lbl_Player2Turn.Text = $"{timeLeft} second(s)";
                timeLeft--;
            }

            if (timeLeft == -1 && whosTurn == 1) // If player 1's turn...
            {
                lbl_Player1Turn.Visible = false; //Hide player 1's cards
                pb_HidePlayer1Cards.Visible = false;
                lbl_Player2Turn.Visible = true; //Display player 2's cards
                pb_HidePlayer2Cards.Visible = true;
                lbl_Player1Turn.Text = ""; //Hide countdown text
                ChangeButtonState();
                timer_TurnStart.Stop();
            }
            else if (timeLeft == -1 && whosTurn == 2) // If player 2's turn...
            {
                lbl_Player2Turn.Visible = false; //Hide player 2's cards
                pb_HidePlayer2Cards.Visible = false;
                lbl_Player1Turn.Visible = true; //Display player 1's cards
                pb_HidePlayer1Cards.Visible = true;
                lbl_Player2Turn.Text = ""; //Hide countdown text
                ChangeButtonState();
                timer_TurnStart.Stop();
            }
        }

        private void btn_Draw_Click(object sender, EventArgs e) {
            if (round == 1 && whosTurn == 1) { //If first round & player 1's turn...
                random = rand.Next(1, deckSize);
                currCard = Deck.ElementAt(random); //Pick a random card from the deck.
                lbl_Player1Card1.Text = ($"{currCard.GetDisplay()}"); //Display the card.
                Deck.RemoveAt(random); //Remove the card from the deck.
                --deckSize; //Decrease deck size to accomodate removed card.
                random = rand.Next(1, deckSize);
                currCard = Deck.ElementAt(random);
                lbl_Player1Card2.Text = ($"{currCard.GetDisplay()}");
                Deck.RemoveAt(random);
                --deckSize;
                ChangeButtonState();
                btn_Swap.Enabled = true;
            }
            if (round == 1 && whosTurn == 2) { //If first round & player 2's turn...
                random = rand.Next(1, deckSize);
                currCard = Deck.ElementAt(random);
                lbl_Player2Card1.Text = ($"{currCard.GetDisplay()}");
                Deck.RemoveAt(random);
                --deckSize;
                random = rand.Next(1, deckSize);
                currCard = Deck.ElementAt(random);
                lbl_Player2Card2.Text = ($"{currCard.GetDisplay()}");
                Deck.RemoveAt(random);
                --deckSize;
                ChangeButtonState();
                btn_Swap.Enabled = true;
            }
        }

        private void btn_Check_Click(object sender, EventArgs e) { //NOTE: ADD FUNCTIONALITY TO ONLY ALLOW PLAYER TO CHECK ONCE, FORCE DRAW ON NEXT TURN
            if (whosTurn == 1) { //Not yet properly implemented.
                whosTurn = 2;
            }
            else if (whosTurn == 2) {
                whosTurn = 1;
            }
            timeLeft = 5;
            timer_TurnStart.Start();
            //round++;
        }

        private void btn_Swap_Click(object sender, EventArgs e) {
            btn_Swap.Enabled = false;
            if (whosTurn == 1) { 
                whosTurn = 2;
                pb_HidePlayer1Cards.Visible = true;
                lbl_Player1Turn.Text = "Player 1";
                lbl_Player1Turn.Visible = true;
            }
            else if (whosTurn == 2) {
                whosTurn = 1;
                pb_HidePlayer2Cards.Visible = true;
                lbl_Player2Turn.Text = "Player 2";
                lbl_Player2Turn.Visible = true;
            }
            timeLeft = 5;
            timer_TurnStart.Start();
            //round++;
        }

        private void btn_Fold_Click(object sender, EventArgs e) {
            ChangeButtonState();
            if (whosTurn == 1) 
            {
                lbl_GameTxt.Text = "Player 2 wins!";
            }
            else 
            {
                lbl_GameTxt.Text = "Player 1 wins!";
            }
        }

        public void BuildDeck() { //Creates deck to draw cards from.
            Card c1 = new Card("\U0001F0A1", "Spades", "Ace");
            Card c2 = new Card("\U0001F0A2", "Spades", "2");
            Card c3 = new Card("\U0001F0A3", "Spades", "3");
            Card c4 = new Card("\U0001F0A4", "Spades", "4");
            Card c5 = new Card("\U0001F0A5", "Spades", "5");
            Card c6 = new Card("\U0001F0A6", "Spades", "6");
            Card c7 = new Card("\U0001F0A7", "Spades", "7");
            Card c8 = new Card("\U0001F0A8", "Spades", "8");
            Card c9 = new Card("\U0001F0A9", "Spades", "9");
            Card c10 = new Card("\U0001F0AA", "Spades", "10");
            Card c11 = new Card("\U0001F0AB", "Spades", "Jack");
            Card c12 = new Card("\U0001F0AD", "Spades", "Queen");
            Card c13 = new Card("\U0001F0AE", "Spades", "King");

            Card c14 = new Card("\U0001F0B1", "Hearts", "Ace");
            Card c15 = new Card("\U0001F0B2", "Hearts", "2");
            Card c16 = new Card("\U0001F0B3", "Hearts", "3");
            Card c17 = new Card("\U0001F0B4", "Hearts", "4");
            Card c18 = new Card("\U0001F0B5", "Hearts", "5");
            Card c19 = new Card("\U0001F0B6", "Hearts", "6");
            Card c20 = new Card("\U0001F0B7", "Hearts", "7");
            Card c21 = new Card("\U0001F0B8", "Hearts", "8");
            Card c22 = new Card("\U0001F0B9", "Hearts", "9");
            Card c23 = new Card("\U0001F0BA", "Hearts", "10");
            Card c24 = new Card("\U0001F0BB", "Hearts", "Jack");
            Card c25 = new Card("\U0001F0BD", "Hearts", "Queen");
            Card c26 = new Card("\U0001F0BE", "Hearts", "King");

            Card c27 = new Card("\U0001F0C1", "Diamonds", "Ace");
            Card c28 = new Card("\U0001F0C2", "Diamonds", "2");
            Card c29 = new Card("\U0001F0C3", "Diamonds", "3");
            Card c30 = new Card("\U0001F0C4", "Diamonds", "4");
            Card c31 = new Card("\U0001F0C5", "Diamonds", "5");
            Card c32 = new Card("\U0001F0C6", "Diamonds", "6");
            Card c33 = new Card("\U0001F0C7", "Diamonds", "7");
            Card c34 = new Card("\U0001F0C8", "Diamonds", "8");
            Card c35 = new Card("\U0001F0C9", "Diamonds", "9");
            Card c36 = new Card("\U0001F0CA", "Diamonds", "10");
            Card c37 = new Card("\U0001F0CB", "Diamonds", "Jack");
            Card c38 = new Card("\U0001F0CD", "Diamonds", "Queen");
            Card c39 = new Card("\U0001F0CE", "Diamonds", "King");

            Card c40 = new Card("\U0001F0D1", "Clubs", "Ace");
            Card c41 = new Card("\U0001F0D2", "Clubs", "2");
            Card c42 = new Card("\U0001F0D3", "Clubs", "3");
            Card c43 = new Card("\U0001F0D4", "Clubs", "4");
            Card c44 = new Card("\U0001F0D5", "Clubs", "5");
            Card c45 = new Card("\U0001F0D6", "Clubs", "6");
            Card c46 = new Card("\U0001F0D7", "Clubs", "7");
            Card c47 = new Card("\U0001F0D8", "Clubs", "8");
            Card c48 = new Card("\U0001F0D9", "Clubs", "9");
            Card c49 = new Card("\U0001F0DA", "Clubs", "10");
            Card c50 = new Card("\U0001F0DB", "Clubs", "Jack");
            Card c51 = new Card("\U0001F0DD", "Clubs", "Queen");
            Card c52 = new Card("\U0001F0DE", "Clubs", "King");

            Deck.Add(c1);
            Deck.Add(c2);
            Deck.Add(c3);
            Deck.Add(c4);
            Deck.Add(c5);
            Deck.Add(c6);
            Deck.Add(c7);
            Deck.Add(c8);
            Deck.Add(c9);
            Deck.Add(c10);
            Deck.Add(c11);
            Deck.Add(c12);
            Deck.Add(c13);

            Deck.Add(c14);
            Deck.Add(c15);
            Deck.Add(c16);
            Deck.Add(c17);
            Deck.Add(c18);
            Deck.Add(c19);
            Deck.Add(c20);
            Deck.Add(c21);
            Deck.Add(c22);
            Deck.Add(c23);
            Deck.Add(c24);
            Deck.Add(c25);
            Deck.Add(c26);

            Deck.Add(c27);
            Deck.Add(c28);
            Deck.Add(c29);
            Deck.Add(c30);
            Deck.Add(c31);
            Deck.Add(c32);
            Deck.Add(c33);
            Deck.Add(c34);
            Deck.Add(c35);
            Deck.Add(c36);
            Deck.Add(c37);
            Deck.Add(c38);
            Deck.Add(c39);

            Deck.Add(c40);
            Deck.Add(c41);
            Deck.Add(c42);
            Deck.Add(c43);
            Deck.Add(c44);
            Deck.Add(c45);
            Deck.Add(c46);
            Deck.Add(c47);
            Deck.Add(c48);
            Deck.Add(c49);
            Deck.Add(c50);
            Deck.Add(c51);
            Deck.Add(c52);
        } 
        public void ChangeButtonState() { //Enables button pressing if disabled, disables button pressing if enabled.
            if (btn_Fold.Enabled == true) {
                btn_Draw.Enabled = false;
                btn_Check.Enabled = false;
                btn_Fold.Enabled = false;
            }
            else if (btn_Fold.Enabled == false) {
                btn_Draw.Enabled = true;
                btn_Check.Enabled = true;
                btn_Fold.Enabled = true;
            }
        } 
    }
}
