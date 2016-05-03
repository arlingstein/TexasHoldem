using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem
{
    public class Card
    {
        private char suit;
        private char rank;
        public char Suit
        {
            get { return char.ToLower(suit); }
            set
            {
                switch (char.ToLower((char)value))
                {
                    case 's': case 'h': case 'd': case 'c': { suit = value; break; }
                    default: throw new Exception("Card Suit Incorrect");
                }

            }
        }
        public char Rank
        {
            get { return char.ToLower(rank); }
            set
            {
                switch (char.ToLower((char)value))
                {
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case 't':
                    case 'j':
                    case 'q':
                    case 'k':
                    case 'a': { rank = value; break; }
                    default:
                        throw new Exception("Card rank not valid");
                }
             }
        }

        public Card(char rank, char Suit)
        {
            this.Rank = rank;
            this.Suit = Suit;
        }
    }
}
