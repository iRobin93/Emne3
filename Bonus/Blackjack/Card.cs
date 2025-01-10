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
        private string _rankString;


        public Card(SuitEnum suit, RankEnum rank, string rankString)
        {
            _suit = suit;
            _rank = rank;
            _rankString = rankString;
        }


        public RankEnum GetRank()
        {
            return _rank;
        }

        public SuitEnum GetSuit() 
        {
            return _suit;
        }


        public string GetRankString() 
        {
            return _rankString;
        }
    }
}
