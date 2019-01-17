using lab07_collections.classes;
using System;

namespace lab07_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck<Card> myDeck = new Deck<Card>();
            Card a1 = new Card(CardOption Ace, SuitesHearts);
            Card j2 = new Card();

            foreach(Card card in myDeck)
            {
                Console.WriteLine(card);
            }
        }

        public static void Deal()
        {

        }
    }
}
