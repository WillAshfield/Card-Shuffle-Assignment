using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public List<Card> deck;
        public Pack()
        {
            deck = new List<Card>();


            for (var suit = 1; suit <= 4; suit++)
            {
                for (var value = 1; value <= 13; value++)
                {
                    deck.Add(new Card { Suit = suit, Value = value });
                }
            }

            deck = (from suit in Enumerable.Range(1, 4)
                    from card in Enumerable.Range(1, 13)
                    select new Card { Suit = suit, Value = card }).ToList();

        }

        public static bool shuffleCardPack(int typeOfShuffle, List<Card> deck)
        {

            List<Card> emptyDeck = new List<Card>();

            Random rnd = new Random();

            //Shuffles the pack based on the type of shuffle
            // If the user picks the number 1, Fisher-Yates Shuffle
            if (typeOfShuffle == 1)
            {
                for (int i = 0; i < 52; i++)
                {
                    int num = rnd.Next(deck.Count);
                    emptyDeck.Add(deck[num]);
                    deck.Remove(deck[num]);
                }
                for (int i = 0; i < emptyDeck.Count; i++)
                {
                    deck.Add(emptyDeck[i]);
                }
                return true;
            }
            // If the user picks the number 2, Riffle Shuffle
            else if (typeOfShuffle == 2)
            {
                for (int i = 0; i < 25; i++)
                {
                    emptyDeck.Add(deck[i]);
                    emptyDeck.Add(deck[i + 26]);
                }
                deck.Clear();
                for (int i = 0; i < emptyDeck.Count; i++)
                {
                    deck.Add(emptyDeck[i]);
                }
                return true;
            }
            // If the user picks the number 3, the deck will not be shuffled and just return
            else if (typeOfShuffle == 3)
            {
                return true;
            }

            return false;
        }
        public static Card deal(List<Card> deck)
        {
            Card dealt = deck[0];

            //Deals one card
            return dealt;
        }
        public static List<Card> dealCards(int amount, List<Card> deck)
        {

            List<Card> dealtCards = new List<Card>();
            //Deals the number of cards specified by 'amount'
            for (int i = 0; i < amount; i++)
            {
                dealtCards.Add(deck[i]);
            }
            return dealtCards;
        }
    }
}
