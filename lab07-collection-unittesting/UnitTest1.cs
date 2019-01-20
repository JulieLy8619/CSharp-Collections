using lab07_collections;
using lab07_collections.classes;
using System;
using Xunit;

namespace lab07_collection_unittesting
{
    public class UnitTest1
    {
        //add a card to the deck
        [Fact]
        public void TestAddCardToDeck()
        {
            Deck<Card> testDeck = new Deck<Card>();
            Card aHeart = new Card(CardsOptions.Ace, Suits.Hearts);
            testDeck.AddCard(aHeart);
            Assert.Equal(1, testDeck.Counter); //if I added the card then the length would increase to 1
        }

        //getter for card class
        [Fact]
        public void TestCardGetter()
        {
            //Deck<Card> testDeck = new Deck<Card>();
            Card aHeart = new Card(CardsOptions.Ace, Suits.Hearts);
            Suits temp = aHeart.CardSuit;
            string tempString = Convert.ToString(temp);
            //testDeck.AddCard(aHeart);
            Assert.Equal("Hearts", tempString);
        }

        //setter for card class
        [Fact]
        public void TestCardSetter()
        {
            Card aHeart = new Card(CardsOptions.Ace, Suits.Hearts);
            aHeart.CardSuit = Suits.Spades;
            Suits temp = aHeart.CardSuit;
            string tempString = Convert.ToString(temp);
            //testDeck.AddCard(aHeart);
            Assert.Equal("Spades", tempString); //shows I reset the suit
        }

        //remove card from deck
        [Fact]
        public void TestRemoveCard()
        {
            Deck<Card> testDeck = new Deck<Card>();
            Card aHeart = new Card(CardsOptions.Ace, Suits.Hearts);
            testDeck.AddCard(aHeart);
            Program.RemoveSpecificCard(CardsOptions.Ace, Suits.Hearts, testDeck);
            Assert.Equal(0, testDeck.Counter); //if I removed the card then the length would decrease to 0        
        }

        //not remove card from deck that doesn't have that card
        [Fact]
        public void TestAttemptRemoveCardNotInDeck()
        {
            Deck<Card> testDeck = new Deck<Card>();
            Card aHeart = new Card(CardsOptions.Ace, Suits.Hearts);
            testDeck.AddCard(aHeart);
            Program.RemoveSpecificCard(CardsOptions.Ten, Suits.Spades, testDeck);
            Assert.Equal(1, testDeck.Counter); //should still be 1 if I didn't remove a card
        }
    }
}

