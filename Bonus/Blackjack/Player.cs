using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Player
    {
        private double _money;
        private bool _insurance = false;
        private List<Hand> _hands = new List<Hand>();

        public Player(int startingmoney)
        {
            _hands.Add(new Hand());
            _money = startingmoney;
        }

        public void SplitHand(int indexHand)
        {
            var hand = new Hand();
            _hands.Add(hand);
            _hands[indexHand].SplitHand(hand);
        }

        public void HandDone(int indexHand)
        {
            _hands[indexHand].HandDone();
        }

        public int GetNumberOfHands()
        {
            return _hands.Count;
        }

        public bool CheckIfHandDone(int indexHand)
        {
            return _hands[indexHand].IsDone();
        }

        public int GetNumberOfCardsInHand(int indexHand)
        {
            return _hands[indexHand].GetNumberOfCardsInHand();
        }

        public bool CheckIfCardsAreSame(int indexHand)
        {
            return _hands[indexHand].CheckIfCardsAreSame();
        }

        public bool AllHandsDone()
        {
            
            foreach (Hand hand in _hands)
            {
                if (!hand.IsDone())
                    return false; 
            }
            return true;
        }

       

        public void DealCard(Card card, int indexHand)
        {
            if (_hands.Count <= indexHand)
            {               
                _hands.Add(new Hand());
            }
            _hands[indexHand].AddCard(card);
        }

        public void SetBet(int bet, int indexHand)
        {
            _hands[(indexHand)].SetBet(bet);
        }

        public void DoubleBet(int indexHand)
        {
            _hands[indexHand].DoubleBet();
        }

        public double GetMoney()
        {
            return _money;
        }

        public bool HasBlackJack(int indexHand)
        {
            return _hands[indexHand].HasBlackJack();
        }

        public void RemoveOrAddMoney(bool increase, double multiplier, int indexHand)
        {
            if (increase)
            {
                _money += _hands[indexHand].GetBet() * multiplier;
                Console.WriteLine("Du har tjent: " + _hands[indexHand].GetBet() * multiplier + " kroner");
            }
            else
            {
                _money -= _hands[indexHand].GetBet() * multiplier;
                Console.WriteLine("Du tapte: " + _hands[indexHand].GetBet() * multiplier + " kroner");
            }

        }

        public void RemoveInsuranceMoney()
        {
            if (_insurance)
            {
                _money -= _hands[0].GetBet() / 2;
                Console.WriteLine("Vi trakk " + _hands[0].GetBet() / 2+ " kroner");
            }
                
            
        }

        public string GetStringCardsInHand(int indexHand, bool lastCardOnly)
        {
            return _hands[indexHand].GetStringCardsInHand(false, lastCardOnly);
        }

        public void SetInsurance(bool insurance)
        {
            _insurance = insurance;
        }

        public bool HasInsurance()
        {
            return _insurance;
        }

        public int GetHandValue(int indexHand)
        {
            return _hands[indexHand].GetValueOfHand();
        }

        public void ResetCards()
        {
            _hands.Clear();
            _hands.Add(new Hand());
        }

    }
}
