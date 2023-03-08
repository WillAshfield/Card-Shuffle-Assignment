using System;
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
            try //First asks the user which kind of shuffle they would like to use, Then reads the line the user writes and stores it as a variable for later use
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

            try //After shuffling, the user can either deal one card or deal multiple cards, reads the line the user writes and stores it as a variable for later use
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
                int amount = 100
                Console.WriteLine("How many cards would you like to deal");
                while (amount > 52) //This catches an error of if the user inputs a number greater than the total number of cards in the deck
                {
                    amount = int.Parse(Console.ReadLine());
                }
                List<Card> dealtCards = Pack.dealCards(amount, pack.deck);
                Console.WriteLine("Your cards are: ");
                for (int i = 0; i < dealtCards.Count; i++) //Goes through all the cards that were dealt and displays them in the console.
                {
                    Console.WriteLine(dealtCards[i].Description());
                }
            }
        }
    }
}
