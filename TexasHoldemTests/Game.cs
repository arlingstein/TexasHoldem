using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldemTests
{//the game has 4 rounds, which should all be able to be set up with a constructor... just have the community cards be an arry and add a card to the array for each Round... the rounds could be new constructors as long as they take what is already in another constructor; having different constructors would be easier to test. Would you be able to say instead of this.CommunityCards = the constructors community cards that this.PreFlopCommunityCards = the Flop's CommunityCards?  
    //what does each round have?
    class Game
    {
        //what is in each round? :
        private char[] _CommunityCards;
        private int _MoneyInThePot;
        private int _SmallBlindBet;
        private int _BigBlindBet;
        private int[,] _PlayersBets; //[playerNames, PlayerBets]
        private int[,] _PlayersScores; //[playerNames, PlayerScores]
        //would it be better to have another array for the names and only have single dimension arrays? 
        public Game(char[] CommunityCards, int MoneyInPot, int SmallBlindBet, int BigBlindBet, int [,]PlayersBets, int[,] PlayersScores)
        {
            this._CommunityCards = CommunityCards;
            this._MoneyInThePot = MoneyInPot;
            this._SmallBlindBet = SmallBlindBet;
            this._BigBlindBet = BigBlindBet;
            this._PlayersBets = PlayersBets;
            this._PlayersScores = PlayersBets; 
        }

    }
} 