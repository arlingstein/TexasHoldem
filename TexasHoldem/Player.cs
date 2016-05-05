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
    class Player
    {
        private int[] _PlayersHand;
        private int _PlayersBet;
        //with this players bet, it may get repetitive with the game object... should have a better way of keep this. 
        private int _PlayersAvailableMoney; 
        public Player(int[] PlayersHand, int PlayersBet, int AvailableMoney)
        {
            this._PlayersHand = PlayersHand[];
            this._PlayersBet = PlayersBet;
            this._PlayersAvailableMoney = AvailableMoney; 
        }
    }
}
