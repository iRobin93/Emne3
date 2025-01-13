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
        private bool _isDone = false;
        private int _bet;


        public void AddCard(Card card)
        {
            _cardsInHand.Add(card);
            if(GetValueOfHand() > 21)
                _isDone = true;
        }

        public void HandDone()
        {
            _isDone = true;
        }

        public bool IsDone()
        {
            return _isDone;
        }

        public string GetStringCardsInHand(bool hideSecondCard, bool cardStringLastCard)
        {
            string cardString = "";
            cardString += "\n";
            foreach (var card in _cardsInHand)
            {
                if (hideSecondCard && card == _cardsInHand[1])
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
                if (cardStringLastCard)
                {
                    cardString = "\n";
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
            /*
             *1. Telle sammen alle kortene som ikke er ace.
             * 2. Hvis ace == 11 går over 21, tell ace som 1
             * 3. For hvert ekstra ace gå til 2.
             * 
             */
            
            int value = 0;
            List<Card> listOfAces = new List<Card>();
            foreach (var card in _cardsInHand)
            {
                if (card.GetRank() != RankEnum.Ace)
                    value += (int)card.GetRank();
                else listOfAces.Add(card);
            }

            foreach (var ace in listOfAces)
            {
                if (value + (int)ace.GetRank() > 21)
                    value += 1;
                else value += 11;
            }

            return value;
        }

        public void SetBet(int bet)
        {
            _bet = bet;
        }

        public void DoubleBet()
        {
            _bet = _bet * 2;
        }

        public int GetBet()
        {
            return _bet;
        }

    }
}
