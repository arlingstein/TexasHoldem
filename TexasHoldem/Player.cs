using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//game hs 4 rounds: pre-flop (2 comm cards), flop(3 cards) , turn(4 cards),  river(5 cards) 
//hand(2 cards)
//player(points, money)

namespace TexasHoldem
{
    public class Player
    {
        private char[] _PlayersHand;
        private int _PlayersAvailableMoneyToBet;
        private int _Bet;
        public Player(char[] PlayersHand, int AvailableMoneyToBet, int Bet)
        {
            this._PlayersHand = PlayersHand;
            this._PlayersAvailableMoneyToBet = AvailableMoneyToBet;
            this._Bet = Bet;
        }
        //checks that the player has enough money to place their bet
        public bool CheckBetValidity()
        {
            var Player1 = new Player(_PlayersHand, _PlayersAvailableMoneyToBet, _Bet);
            if (Player1._PlayersAvailableMoneyToBet >=  Player1._Bet)
            {
                return true;
            }
            else return false;
        }
        //returns the player's available money after a bet
        public int PlayerPlaceBet()
        {
            if (CheckBetValidity() == true)
            {
                _PlayersAvailableMoneyToBet = _Bet - _PlayersAvailableMoneyToBet;
                return _PlayersAvailableMoneyToBet;
            }
            else return 0; 
        }
    }
}

