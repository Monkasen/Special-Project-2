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
        public List<System.Windows.Forms.Label> communityCardLabels = new List<System.Windows.Forms.Label>();

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

            // Add player 2's card labels to a list
            player2CardLabels.Add(lbl_Player2Card1);
            player2CardLabels.Add(lbl_Player2Card2);

            // Add community card labels to a list
            communityCardLabels.Add(lbl_Comm1);
            communityCardLabels.Add(lbl_Comm2);
            communityCardLabels.Add(lbl_Comm3);
            communityCardLabels.Add(lbl_Comm4);
            communityCardLabels.Add(lbl_Comm5);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            BuildDeck();

            foreach (var item in player1CardLabels)
                item.Text = "";
            foreach (var item in player2CardLabels)
                item.Text = "";
            foreach (var item in communityCardLabels)
                item.Text = "";

            // Reset card/player visiblity
            lbl_Player1Turn.Visible = true;
            lbl_Player2Turn.Visible = true;
            pb_HidePlayer1Cards.Visible = true;
            pb_HidePlayer2Cards.Visible = true;
            lbl_GameTxt.Text = "";
            lbl_Player1Turn.Text = "Player 1";
            lbl_Player2Turn.Text = "Player 2";

            // Reset game butttons
            btn_Fold.Enabled = false;
            btn_Swap.Enabled = false;

            // Countdown to player 1's turn
            round = 1;
            whosTurn = 1;
            timeLeft = 5;
            timer_TurnStart.Start();
        }

        private void timer_TurnStart_Tick(object sender, EventArgs e)
        {
            if (whosTurn == 1) // If player 1's turn...
            {
                lbl_Player1Turn.Text = $"{timeLeft} second(s)..";
                timeLeft--;
            }
            else if (whosTurn == 2) // If player 2's turn...
            {
                lbl_Player2Turn.Text = $"{timeLeft} second(s)..";
                timeLeft--;
            }
            else if (whosTurn == 3) // If dealer's turn...
            {
                lbl_Player1Turn.Text = $"{timeLeft} second(s)..";
                lbl_Player2Turn.Text = $"{timeLeft} second(s)..";
                timeLeft--;
            }

            if (timeLeft == -1 && whosTurn == 1) // If player 1's turn...
            {
                lbl_Player1Turn.Visible = false; // Hide player 1's cards
                pb_HidePlayer1Cards.Visible = false;
                lbl_Player2Turn.Visible = true; // Display player 2's cards
                pb_HidePlayer2Cards.Visible = true;
                lbl_Player1Turn.Text = ""; // Hide countdown text
                ChangeButtonState();
                timer_TurnStart.Stop();
            }
            else if (timeLeft == -1 && whosTurn == 2) // If player 2's turn...
            {
                lbl_Player2Turn.Visible = false; // Hide player 2's cards
                pb_HidePlayer2Cards.Visible = false;
                lbl_Player1Turn.Visible = true; // Display player 1's cards
                pb_HidePlayer1Cards.Visible = true;
                lbl_Player2Turn.Text = ""; // Hide countdown text
                ChangeButtonState();
                timer_TurnStart.Stop();
            }
            else if (timeLeft == -1 && whosTurn == 3) // If dealers's turn...
            {
                lbl_GameTxt.Text = "Dealer's Turn";
                lbl_Player1Turn.Visible = true; // Hide player 1's cards
                pb_HidePlayer1Cards.Visible = true;
                lbl_Player2Turn.Visible = true; // Hide player 2's cards
                pb_HidePlayer2Cards.Visible = true;
                lbl_Player1Turn.Text = "Player 1"; 
                lbl_Player2Turn.Text = "Player 2"; 
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
                btn_Draw.Enabled = false;
                btn_Fold.Enabled = true;
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
                btn_Draw.Enabled = false;
                btn_Fold.Enabled = true;
                btn_Swap.Enabled = true;
            }
            if (round == 1 && whosTurn == 3) { //If first round & dealer's turn...
                random = rand.Next(1, deckSize);
                currCard = Deck.ElementAt(random);
                lbl_Comm1.Text = ($"{currCard.GetDisplay()}");
                Deck.RemoveAt(random);
                --deckSize;
                random = rand.Next(1, deckSize);
                currCard = Deck.ElementAt(random);
                lbl_Comm2.Text = ($"{currCard.GetDisplay()}");
                Deck.RemoveAt(random);
                --deckSize;
                random = rand.Next(1, deckSize);
                currCard = Deck.ElementAt(random);
                lbl_Comm3.Text = ($"{currCard.GetDisplay()}");
                Deck.RemoveAt(random);
                --deckSize;
                btn_Draw.Enabled = false;
                btn_Swap.Enabled = true;
                ++round; //Increase round after dealer draws cards
                return;
            }

            if (round == 2 && whosTurn == 3) { //If second round and dealers's turn...
                random = rand.Next(1, deckSize);
                currCard = Deck.ElementAt(random);
                lbl_Comm4.Text = ($"{currCard.GetDisplay()}");
                Deck.RemoveAt(random);
                --deckSize;
                btn_Draw.Enabled = false;
                btn_Swap.Enabled = true;
                ++round; //Increase round after dealer draws cards
                return;
            }

            if (round == 3 && whosTurn == 3) { //If third round and dealers's turn...
                random = rand.Next(1, deckSize);
                currCard = Deck.ElementAt(random);
                lbl_Comm5.Text = ($"{currCard.GetDisplay()}");
                Deck.RemoveAt(random);
                --deckSize;
                btn_Draw.Enabled = false;
                btn_Swap.Enabled = true;
                ++round; //Increase round after dealer draws cards
                return;
            }
        }

        private void btn_Swap_Click(object sender, EventArgs e) {
            btn_Draw.Enabled = false;
            btn_Fold.Enabled = false;
            btn_Swap.Enabled = false;

            if (whosTurn == 1) { // If player 1's turn...
                whosTurn = 2;
                pb_HidePlayer1Cards.Visible = true;
                lbl_Player1Turn.Text = "Player 1";
                lbl_Player1Turn.Visible = true;
            }
            else if (whosTurn == 2) { // If player 2's turn...
                whosTurn = 3;
                pb_HidePlayer2Cards.Visible = true;
                lbl_Player2Turn.Text = "Player 2";
                lbl_Player2Turn.Visible = true;
            }
            else if (whosTurn == 3) { // If dealer's turn...
                lbl_GameTxt.Text = "";
                whosTurn = 1;
            }

            if (round == 4 && whosTurn == 3) { //Checks for winner at end of game.
                CheckWin();
                return;
            }

            timeLeft = 5;
            timer_TurnStart.Start();
        }

        private void btn_Fold_Click(object sender, EventArgs e) {
            if (whosTurn == 1) 
            {
                lbl_GameTxt.Text = "Player 2 wins!";
            }
            else 
            {
                lbl_GameTxt.Text = "Player 1 wins!";
            }
            btn_Draw.Enabled = false;
            btn_Fold.Enabled = false;
            btn_Swap.Enabled = false;
        }

        public void BuildDeck() { //Creates deck to draw cards from.
            Deck.Add(new Card("\U0001F0A1", "Spades", "Ace"));
            Deck.Add(new Card("\U0001F0A2", "Spades", "2"));
            Deck.Add(new Card("\U0001F0A3", "Spades", "3"));
            Deck.Add(new Card("\U0001F0A4", "Spades", "4"));
            Deck.Add(new Card("\U0001F0A5", "Spades", "5"));
            Deck.Add(new Card("\U0001F0A6", "Spades", "6"));
            Deck.Add(new Card("\U0001F0A7", "Spades", "7"));
            Deck.Add(new Card("\U0001F0A8", "Spades", "8"));
            Deck.Add(new Card("\U0001F0A9", "Spades", "9"));
            Deck.Add(new Card("\U0001F0AA", "Spades", "10"));
            Deck.Add(new Card("\U0001F0AB", "Spades", "Jack"));
            Deck.Add(new Card("\U0001F0AD", "Spades", "Queen"));
            Deck.Add(new Card("\U0001F0AE", "Spades", "King"));
         
            Deck.Add(new Card("\U0001F0B1", "Hearts", "Ace"));
            Deck.Add(new Card("\U0001F0B2", "Hearts", "2"));
            Deck.Add(new Card("\U0001F0B3", "Hearts", "3"));
            Deck.Add(new Card("\U0001F0B4", "Hearts", "4"));
            Deck.Add(new Card("\U0001F0B5", "Hearts", "5"));
            Deck.Add(new Card("\U0001F0B6", "Hearts", "6"));
            Deck.Add(new Card("\U0001F0B7", "Hearts", "7"));
            Deck.Add(new Card("\U0001F0B8", "Hearts", "8"));
            Deck.Add(new Card("\U0001F0B9", "Hearts", "9"));
            Deck.Add(new Card("\U0001F0BA", "Hearts", "10"));
            Deck.Add(new Card("\U0001F0BB", "Hearts", "Jack"));
            Deck.Add(new Card("\U0001F0BD", "Hearts", "Queen"));
            Deck.Add(new Card("\U0001F0BE", "Hearts", "King"));

            Deck.Add(new Card("\U0001F0C1", "Diamonds", "Ace"));
            Deck.Add(new Card("\U0001F0C2", "Diamonds", "2"));
            Deck.Add(new Card("\U0001F0C3", "Diamonds", "3"));
            Deck.Add(new Card("\U0001F0C4", "Diamonds", "4"));
            Deck.Add(new Card("\U0001F0C5", "Diamonds", "5"));
            Deck.Add(new Card("\U0001F0C6", "Diamonds", "6"));
            Deck.Add(new Card("\U0001F0C7", "Diamonds", "7"));
            Deck.Add(new Card("\U0001F0C8", "Diamonds", "8"));
            Deck.Add(new Card("\U0001F0C9", "Diamonds", "9"));
            Deck.Add(new Card("\U0001F0CA", "Diamonds", "10"));
            Deck.Add(new Card("\U0001F0CB", "Diamonds", "Jack"));
            Deck.Add(new Card("\U0001F0CD", "Diamonds", "Queen"));
            Deck.Add(new Card("\U0001F0CE", "Diamonds", "King"));

            Deck.Add(new Card("\U0001F0D1", "Clubs", "Ace"));
            Deck.Add(new Card("\U0001F0D2", "Clubs", "2"));
            Deck.Add(new Card("\U0001F0D3", "Clubs", "3"));
            Deck.Add(new Card("\U0001F0D4", "Clubs", "4"));
            Deck.Add(new Card("\U0001F0D5", "Clubs", "5"));
            Deck.Add(new Card("\U0001F0D6", "Clubs", "6"));
            Deck.Add(new Card("\U0001F0D7", "Clubs", "7"));
            Deck.Add(new Card("\U0001F0D8", "Clubs", "8"));
            Deck.Add(new Card("\U0001F0D9", "Clubs", "9"));
            Deck.Add(new Card("\U0001F0DA", "Clubs", "10"));
            Deck.Add(new Card("\U0001F0DB", "Clubs", "Jack"));
            Deck.Add(new Card("\U0001F0DD", "Clubs", "Queen"));
            Deck.Add(new Card("\U0001F0DE", "Clubs", "King"));
        } 

        public void ChangeButtonState() { // Handles enabling/disabling of button presses (draw,swap,fold) throughout the game.
            if (round == 1) {
                if (whosTurn == 1) {
                    btn_Draw.Enabled = true;
                    btn_Fold.Enabled = false;
                }
                if (whosTurn == 2) {
                    btn_Draw.Enabled = true;
                }
                if (whosTurn == 3) {
                    btn_Draw.Enabled = true;
                    btn_Fold.Enabled = false;
                }
            }
            else if (round == 2 || round == 3 || round == 4) {
                if (whosTurn == 1 || whosTurn == 2) {
                    btn_Draw.Enabled = false;
                    btn_Fold.Enabled = true;
                    btn_Swap.Enabled = true;
                }
                else if (whosTurn == 3) {
                    btn_Draw.Enabled = true;
                    btn_Fold.Enabled = false;
                    btn_Swap.Enabled = false;
                }
            }
            if (round == 4 && whosTurn == 2) { // If it's the last turn before the end of the game, change the Swap button to reveal who won.
                btn_Swap.Text = "Reveal Winner";
            }
        }

        public void CheckWin() {
            lbl_Player1Turn.Visible = false; // Show player 1's cards
            pb_HidePlayer1Cards.Visible = false;
            lbl_Player2Turn.Visible = false; // Show player 2's cards
            pb_HidePlayer2Cards.Visible = false;

            lbl_GameTxt.Text = "GAME OVER"; //Use this label to display if player 1 or 2 wins.
        }
    }
}
