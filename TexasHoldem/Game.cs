using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem
{
    public class Game
    {
        public enum Round
        {
            preflop = 1,
            flop    = 2,
            turn    = 3,
            river   = 4
        };


        //Member Variables : What a game has
        private Round   _round;
        private Card[]  _CommunityCards;
        private Dictionary<Player, int> _playerScore;
        public int      _Pot; 


        
        //public Game(string Round, char[] CommunityCards, int[] PlayerScores)
        //{
        //    this._Round = Round;
        //    this._CommunityCards = CommunityCards;
        //    this._PlayersScores = PlayerScores;
        //}
        //I do not like this object. Sloppy.  
        public Func<int, int> NumberOfCommunityCards = (round) =>
        {
            var numberOfCards = 0;
            if (round == 1)//these numbers are here for ease, not for permanent
                return numberOfCards = 2;
            if (round == 2)
                return numberOfCards = 3;
            if (round == 3)
                return numberOfCards = 4;
            if (round == 4)
                return numberOfCards = 5;
            else return numberOfCards;
        };
    }
}
