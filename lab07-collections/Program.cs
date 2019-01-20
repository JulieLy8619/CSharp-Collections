using lab07_collections.classes;
using System;

namespace lab07_collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Deal();
            Console.ReadLine(); //to stop it from auto closing

        }

        /// <summary>
        /// this is the whole game. Making a deck, adding and removing from it, dividing it among the hands (player1 player2 and dealer), and printing it to the screen
        /// </summary>
        public static void Deal()
        {
            Deck<Card> myDeck = new Deck<Card>();
            Card aHeart = new Card(CardsOptions.Ace, Suits.Hearts);
            Card jDiamonds = new Card(CardsOptions.Jack, Suits.Diamonds);
            Card twoSpades = new Card(CardsOptions.Two, Suits.Spades);
            Card threeSpades = new Card(CardsOptions.Three, Suits.Spades);
            Card fourHearts = new Card(CardsOptions.Four, Suits.Hearts);
            Card fiveHearts = new Card(CardsOptions.Five, Suits.Hearts);
            Card qDiamonds = new Card(CardsOptions.Queen, Suits.Diamonds);
            Card qHearts = new Card(CardsOptions.Queen, Suits.Hearts);
            Card eightDiamonds = new Card(CardsOptions.Eight, Suits.Diamonds);
            Card nineClubs = new Card(CardsOptions.Nine, Suits.Clubs);
            Card sixSpades = new Card(CardsOptions.Six, Suits.Spades);
            myDeck.AddCard(aHeart);
            myDeck.AddCard(jDiamonds);
            myDeck.AddCard(twoSpades);
            myDeck.AddCard(threeSpades);
            myDeck.AddCard(fourHearts);
            myDeck.AddCard(fiveHearts);
            myDeck.AddCard(qDiamonds);
            myDeck.AddCard(qHearts);
            myDeck.AddCard(eightDiamonds);
            myDeck.AddCard(nineClubs);
            myDeck.AddCard(sixSpades);

            Console.WriteLine("The cards in the deck: ");
            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.CardNumber} of {card.CardSuit}, ");
            }
            Console.WriteLine();

            Console.WriteLine("Removing Two of Spades");
            RemoveSpecificCard(CardsOptions.Two, Suits.Spades, myDeck);
            Console.WriteLine();
            Console.WriteLine($"The cards remaining in the deck: ({myDeck.Counter})");
            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.CardNumber} of {card.CardSuit} ");
            }
            Console.WriteLine();

            Console.WriteLine("Start of game: ");
            Console.WriteLine("Player One's Hand: Empty");
            Console.WriteLine("Player Two's Hand: Empty");
            Console.WriteLine($"Dealers's Hand: {myDeck.Counter}");
            foreach (Card card in myDeck)
            {
                Console.WriteLine($"{card.CardNumber} of {card.CardSuit}, ");
            }
            Console.WriteLine();

            int numForPlayers = myDeck.Counter / 2;
            Card[] Player1 = new Card[numForPlayers];
            Card[] Player2 = new Card[numForPlayers];
            int dealerHand = myDeck.Counter % 2;
            Card[] Dealer = new Card[dealerHand];
            int cardHandCounter = 0;
            int p1HandCounter = 0;
            int p2HandCounter = 0;

            if (dealerHand == 0)
            {
                do
                {
                    Player1[p1HandCounter] = myDeck.items[cardHandCounter];
                    cardHandCounter++;
                    p1HandCounter++;
                    Player2[p2HandCounter] = myDeck.items[cardHandCounter];
                    cardHandCounter++;
                    p2HandCounter++;
                } while (cardHandCounter < myDeck.Counter);
            }
            else
            {
                do
                {
                    Player1[p1HandCounter] = myDeck.items[cardHandCounter];
                    cardHandCounter++;
                    p1HandCounter++;
                    Player2[p2HandCounter] = myDeck.items[cardHandCounter];
                    cardHandCounter++;
                    p2HandCounter++;
                } while (cardHandCounter < myDeck.Counter-1);
                Dealer[0] = myDeck.items[cardHandCounter]; //because dealers hand will only be 0 or 1 currently
            }


            Console.WriteLine("Player One's Hand");
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
        }

        /// <summary>
        /// removes a specific card from the deck
        /// </summary>
        /// <param name="cardOpt">number of the card (like ace, 1, jack, king, etc)</param>
        /// <param name="suit">suit of the card, like spades, diamonds, etc</param>
        /// <param name="deck">the deck we are removing the card from</param>
        public static void RemoveSpecificCard(CardsOptions cardOpt, Suits suit, Deck<Card> deck )
        {
            Card remove = null;
            foreach (Card card in deck)
                {
                if (deck == null)
                {
                    Console.WriteLine("The deck is empty");
                }
                else if (card.CardNumber == cardOpt && card.CardSuit == suit)
                {
                    remove = card;
                    deck.Remove(remove);
                }
                else
                {
                    Console.WriteLine($"Card {cardOpt} of {suit} isn't in the deck");
                }
            }
        }
    }
}
