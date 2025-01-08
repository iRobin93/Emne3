using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Card
    {
        private SuitEnum _suit;
        private RankEnum _rank;


        public Card(SuitEnum suit, RankEnum rank)
        {
            _suit = suit;
            _rank = rank;
        }


        public RankEnum GetRank()
        {
            return _rank;
        }

    }
}
