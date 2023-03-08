using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        static void Main(string[] args)
        {
            var pack = new Pack();
            int numShuffle = 0;
            int numDeal = 0;
            try
            {
                Console.WriteLine("Which shuffle would you like to do? (1) Fisher-Yates // (2) Riffle  // (3) No Shuffle ");
                numShuffle = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("That is not one of the options!");
                Console.WriteLine("Which shuffle would you like to do? (1) Fisher-Yates // (2) Riffle  // (3) No Shuffle ");
                numShuffle = int.Parse(Console.ReadLine());
            }
            bool shuffled = Pack.shuffleCardPack(numShuffle, pack.deck);

            try
            {
                Console.WriteLine("Would you like to (1) Deal one card or (2) Deal multiple cards");
                numDeal = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("That isnt one of the options!");
                Console.WriteLine("Would you like to (1) Deal one card or (2) Deal multiple cards");
                numDeal = int.Parse(Console.ReadLine());
            }
            if (numDeal == 1)
            {
                Card dealtCard = Pack.deal(pack.deck);
                Console.WriteLine("Your card is " + dealtCard.Description());
            }
            else if (numDeal == 2)
            {
                Console.WriteLine("How many cards would you like to deal");
                int amount = int.Parse(Console.ReadLine());
                List<Card> dealtCards = Pack.dealCards(amount, pack.deck);
                Console.WriteLine("Your cards are: ");
                for (int i = 0; i < dealtCards.Count; i++)
                {
                    Console.WriteLine(dealtCards[i].Description());
                }
            }
        }
    }
}