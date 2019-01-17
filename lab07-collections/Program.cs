using lab07_collections.classes;
using System;

namespace lab07_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Deal();

        }

        public static void Deal()
        {
            Deck<Card> myDeck = new Deck<Card>();
            Card aHeart = new Card(CardsOptions.Ace, Suits.Hearts);
            Card jDiamonds = new Card(CardsOptions.Jack, Suits.Diamonds);
            Card twoSpades = new Card(CardsOptions.Two, Suits.Spades);
            myDeck.AddCard(aHeart);
            myDeck.AddCard(jDiamonds);
            myDeck.AddCard(twoSpades);
            int numOfCardsInDeck = myDeck.Counter;
            int numForPlayers = numOfCardsInDeck / 2;
            Card[] Player1 = new Card[numForPlayers];
            Card[] Player2 = new Card[numForPlayers];
            int dealerHand = numOfCardsInDeck % 2;
            Card[] Dealer = new Card[dealerHand];

            Console.WriteLine("Player One's Hand");
            for (int i = 0; i < numForPlayers; i++)
            {
                Player1[i] = myDeck[i];
            }
            foreach (Card card in Player1)
            {
                Console.WriteLine($"{card.CardNumber} of {card.CardSuit} ");
            }
            Console.WriteLine();

            Console.WriteLine("Player Two's Hand");
            foreach (Card card in Player2)
            {
                Console.WriteLine($"{card.CardNumber} of {card.CardSuit} ");
            }
            Console.WriteLine();

            Console.WriteLine("Dealers's Hand");
            foreach (Card card in Dealer)
            {
                Console.WriteLine($"{card.CardNumber} of {card.CardSuit} ");
            }
            Console.WriteLine();
            Console.ReadLine(); //to stop it from suto closing
        } 
    }
}
