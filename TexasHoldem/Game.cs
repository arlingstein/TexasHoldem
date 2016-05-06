using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem
{
    public class Game
    {
        private string _Round;
        private char[] _CommunityCards;
        private int[] _PlayersScores;
        //public Game(string Round, char[] CommunityCards, int[] PlayerScores)
        //{
        //    this._Round = Round;
        //    this._CommunityCards = CommunityCards;
        //    this._PlayersScores = PlayerScores;
        //}
        //I do not like this object. Sloppy.  
        public int NumberOfCommunityCards(int round)
        {
            var numberOfCards = 0;
            if (round == 1)//these numbers are here for ease, not for permanent
            {
                return numberOfCards = 2;
            }
            if (round == 2)
            {
                return numberOfCards = 3;
            }
            if (round == 3)
            {
                return numberOfCards = 4;
            }
            if (round == 4)
            {
                return numberOfCards = 5;
            }
            else return numberOfCards;
        }
    }
}
