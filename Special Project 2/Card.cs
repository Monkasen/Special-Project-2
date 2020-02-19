﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Project_2 {
    class Card {
        private string Suit; //Diamonds, Club, Hearts, Spades
        private string Number; //A,2,3,4,5,6,7,9,10,J,Q,K
        private string Display; //Unicode card character

        public Card() {
            Suit = "NULL";
            Number = "NULL";
            Display = "NULL";
        }

        public Card(string v1, string v2, string v3) {
            this.Display = v1;
            this.Suit = v2;
            this.Number = v3;
        }

        public void SetSuit(string input) {
            Suit = input;
        }
        public void SetNumber(string input) {
            Number = input;
        }
        public void SetDisplay(string input) {
            Display = input;
        }
        public string GetSuit() {
            return Suit;
        }
        public string GetNumber() {
            return Number;
        }
        public string GetDisplay() {
            return Display;
        }
    }
}
