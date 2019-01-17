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
            Card threeSpades = new Card(CardsOptions.Three, Suits.Spades);
            Card fourHearts = new Card(CardsOptions.Four, Suits.Hearts);
            myDeck.AddCard(aHeart);
            myDeck.AddCard(jDiamonds);
            myDeck.AddCard(twoSpades);
            myDeck.AddCard(threeSpades);
            //myDeck.AddCard(fourHearts); //so have even number for tests
            int numOfCardsInDeck = myDeck.Counter;
            Console.WriteLine("numOfCardsInDeck " + numOfCardsInDeck);
            int numForPlayers = numOfCardsInDeck / 2;
            Console.WriteLine("numForPlayers " + numForPlayers);
            Card[] Player1 = new Card[numForPlayers];
            Card[] Player2 = new Card[numForPlayers];
            int dealerHand = numOfCardsInDeck % 2;
            Card[] Dealer = new Card[dealerHand];

            //just to see all in the deck
            Console.WriteLine("All the cards");
            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.CardNumber} of {card.CardSuit} ");
            }
            Console.WriteLine();

            Console.WriteLine("Player One's Hand");
            for (int i = 0; i < numForPlayers; i++)
            {
                Player1[i] = myDeck.items[i];
            }
            foreach (Card card in Player1)
            {
                Console.WriteLine($"{card.CardNumber} of {card.CardSuit} ");
            }
            Console.WriteLine();

            Console.WriteLine("Player Two's Hand");
            int indexP2 = 0;
            for (int j = 0; j < numForPlayers; j++)
            {
                //Console.WriteLine("numForPlayers in J LOOP " + numForPlayers);
                //Console.WriteLine("numForPlayers + j " + numForPlayers + j);
                indexP2 = numForPlayers + j;
                Player2[j] = myDeck.items[indexP2]; //because I already took the first half for player 1
            }
            foreach (Card card in Player2)
            {
                Console.WriteLine($"{card.CardNumber} of {card.CardSuit} ");
            }
            Console.WriteLine();

            Console.WriteLine("Dealers's Hand");
            int indexDealer = 0;
            for (int p = 0; p < dealerHand; p++)
            {
                indexDealer = (numForPlayers * 2) + p;
                Dealer[p] = myDeck.items[indexDealer]; //because I already took the first half for player 1
            }
            foreach (Card card in Dealer)
            {
                Console.WriteLine($"{card.CardNumber} of {card.CardSuit} ");
            }
            Console.WriteLine();
            Console.ReadLine(); //to stop it from suto closing
        } 
    }
}
