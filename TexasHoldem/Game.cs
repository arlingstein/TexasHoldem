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
        public Game(string Round, char[] CommunityCards, int[] PlayerScores)
        {
            this._Round = Round;
            this._CommunityCards = CommunityCards;
            this._PlayersScores = PlayerScores;
        }
        //I can also do one of these for the round names... but the switch statement would be nice here.  
        public int NumberOfCommunityCards(string round)
        {
            var numberOfCards = 0;
            if (round == "PreFlop")
            {
                return numberOfCards = 2;
            }
            if (round == "Flop")
            {
                return numberOfCards = 3;
            }
            if (round == "Turn")
            {
                return numberOfCards = 4;
            }
            if (round == "River")
            {
                return numberOfCards = 5;
            }
            else return numberOfCards;
        }
    }
}
