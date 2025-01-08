using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Deck
    {
        private List<Card> _cards = new List<Card>();
        private List<Card> _shuffledCards;

        public Deck()
        {
            foreach (SuitEnum suit in Enum.GetValues(typeof(SuitEnum)))
            {
                foreach (RankEnum rank in Enum.GetValues(typeof(RankEnum)))
                {
                    _cards.Add(new Card(suit, rank));
                }
            }
        }

        public void ShuffleCards()
        {
            foreach (Card card in _cards)
            {

            }
        }
    }

}
