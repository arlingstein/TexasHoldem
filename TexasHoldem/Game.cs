using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexasHoldem
{
    public interface IGame
    {
        Player CalculateWinner();
        List<Player> players { get; set; }
        int pot { get; set; }
    }


    public class Game : IGame
    {
        public enum Round
        {
            preflop = 1,
            flop = 2,
            turn = 3,
            river = 4
        };


        //Member Variables : What a game has
        private Round round;
        private List<Card> CommunityCards;
        private List<Card> Deck;
        private Dictionary<Player, int> playerScore;
        public int Pot;
        

        //protected abstract Player CalculateWinner(Rules rules);
        private Game()
        {
            //Steps: 
               //1) Shuffle Deck
               //2) Deal Cards
            this.round = Round.preflop;
            this.DealCards();
            Deck = getDeck();
        }


        private void DealCards()
        {
            
            //throw new NotImplementedException();
        }

        public List<Card> getDeck()
        {
            //Need to get the Cartesian Product of the possible combinations
            var rankPossibilities = new List<char>(){'1','2','3','4','5','6','7','8','9','a','k','q','j' };
            var suitPossibilities = new List<char>(){'s','h','d','c'};

            var deck = suitPossibilities.SelectMany(x => rankPossibilities, (x, y) => new Card(y, x)).ToList();
            return Shuffle(deck);
        }

        public List<Card> Shuffle(List<Card> deck)
        {
            return deck.OrderBy(item => new Random().Next()).ToList();
        }

        public static Game start(List<Player> players)
        {
            //Check that we have players before we start a new game
            if (!players.Any() || players.Count > 9)
                return null;
            var game = new Game();
            return game;

        }

        public Player CalculateWinner()
        {
            throw new NotImplementedException();
        }

        public int pot
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<Player> players
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}