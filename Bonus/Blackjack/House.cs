using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class House
    {
        private Hand _hand = new Hand();



        public void DealCard(Card card)
        {
            _hand.AddCard(card);
        }

        public string GetStringCardsInHand(bool hideSecondCard)
        {
            return _hand.GetStringCardsInHand(hideSecondCard, false);
        }


        public RankEnum GetValueOfCard(int indexCard)
        {
           return  _hand.GetValueOfCard(indexCard);

        }

        public int GetHandValue()
        {
            return _hand.GetValueOfHand();
        }

        public void ResetCards()
        {
            _hand = new Hand();
        }
    }
}
