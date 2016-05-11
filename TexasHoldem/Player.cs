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

        public enum playerType
        {
            dealer      = 1,
            small_blind = 2,
            big_blind   = 3,
            regular     = 4
        };


        //Member Variables
        private List<Card> _PlayersHand;
        private int _PlayersAvailableMoneyToBet;
        private int _Bet;
        private playerType type;


        
        
        public Player(List<Card> PlayersHand, int AvailableMoneyToBet, int Bet)
        { 
            this._PlayersHand = PlayersHand;
            this._PlayersAvailableMoneyToBet = AvailableMoneyToBet;
            this._Bet = Bet;
            
        }
        //checks that the player has enough money to place their bet
        public bool CheckBetValidity()
        {
            var Player1 = new Player(_PlayersHand, _PlayersAvailableMoneyToBet, _Bet);

            return (Player1._PlayersAvailableMoneyToBet >= Player1._Bet);
            //if (Player1._PlayersAvailableMoneyToBet >=  Player1._Bet)
            //{
            //    return true;
            //}
            //else return false;
        }
        //returns the player's available money after a bet //change to place bet when we have placebet logic
        public int getAvailableMoney()
        {
            //if(BetPlace): Update Money: Else return what I have
            if (CheckBetValidity() == true)
            { return 0; }
            else return 0; 
        }
    }
}