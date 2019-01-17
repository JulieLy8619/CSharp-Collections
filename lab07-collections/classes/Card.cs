using System;
using System.Collections.Generic;
using System.Text;

namespace lab07_collections.classes
{
    public enum Suits
    {
        Hearts, 
        Spades,
        Diamonds,
        Clubs
    };
    public enum CardsOptions
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    };
    public class Card //so I can test
    {
        public CardsOptions CardNumber { get; set; }
        public Suits CardSuit { get; set; }

        public Card(CardsOptions cardNum, Suits suitNum)
        {
            CardNumber = cardNum;
            CardSuit = suitNum;

        }

    }
}
