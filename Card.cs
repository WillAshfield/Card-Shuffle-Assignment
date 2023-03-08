using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                if (value >= 1 && value <= 13)
                {
                    _value = value;
                }
                else
                {
                    throw new Exception("Value out of range");
                };
            }
        }

        private int _suit;
        public int Suit
        {
            get { return _suit; }
            set
            {
                if (value >= 1 && value <= 4)
                {
                    _suit = value;
                }
                else
                {
                    throw new Exception("Suit out of range");
                };
            }
        }

        public string Description()
        {
            var suitName = Suit switch
            {
                1 => " Heart",
                2 => " Club",
                3 => " Diamond",
                _ => " Spade"
            };

            var cardName = Value switch
            {
                1 => "A",
                10 => "J",
                11 => "Q",
                12 => "K",
                _ => Value.ToString()
            };

            return cardName + suitName;
        }
    }
}
