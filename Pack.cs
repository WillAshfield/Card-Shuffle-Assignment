using System;
using System.Collections.Generic;
using System.Linq;
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

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            return true;
            //Shuffles the pack based on the type of shuffle

        }
        public static Card deal()
        {
            return new Card();
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            return new List<Card>();

            //Deals the number of cards specified by 'amount'
        }
    }
}
