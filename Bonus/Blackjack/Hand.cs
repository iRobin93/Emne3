using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Hand
    {
        private List<Card> _cardsInHand = new List<Card>();
        


        public void AddCard(Card card)
        {
            _cardsInHand.Add(card);
        }

        public string GetStringCardsInHand(bool house)
        {
            string cardString = "";
            cardString += "\n";
            foreach (var card in _cardsInHand)
            {
                if (house && card == _cardsInHand[1])
                {
                    cardString += " ?? ";
                    cardString += "\n";
                }
                else
                {
                cardString += card.GetRankString();
                cardString += " of ";
                cardString += card.GetSuit();
                cardString += "\n";
                }
         
            }
            return cardString;
        }

        public RankEnum GetValueOfCard(int indexCard)
        {
            return _cardsInHand[indexCard].GetRank();

        }

        public bool HasBlackJack()
        {
            if ((_cardsInHand[0].GetRank() == RankEnum.Ace || _cardsInHand[1].GetRank() == RankEnum.Ace) && (_cardsInHand[0].GetRank() == RankEnum.Ten || _cardsInHand[1].GetRank() == RankEnum.Ten))
                return true;
            return false;
        }

        public int GetValueOfHand()
        {
            //Todo - Ace 1 or 11?
            int value = 0;

            foreach (var card in _cardsInHand)
            {
                value += (int)card.GetRank();
            }

            return value;
        }


    }
}
