using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Player
    {
        private int _money;
        private int _bet;
        private bool _insurance = false;
        private List<Hand> _hands = new List<Hand>();

        public Player(int startingmoney)
        {

            _money = startingmoney;
            //_hands.Add();
        }


        

        public void DealCard(Card card, int indexHand)
        {
            if (_hands.Count <= indexHand)
            {               
                _hands.Add(new Hand());
            }
            _hands[indexHand].AddCard(card);
        }

        public void SetBet(int bet)
        {
            _bet = bet;
        }

        public void DoubleBet()
        {
            _bet = _bet * 2;
        }

        public int GetMoney()
        {
            return _money;
        }

        public bool HasBlackJack()
        {
            return _hands[0].HasBlackJack();
        }

        public void RemoveOrAddMoney(bool increase, double multiplier)
        {
            if (increase)
            {
                _money += _bet;
                Console.WriteLine("Du har tjent: " + _bet);
            }
            else _money -= _bet;
        }

        public void RemoveInsuranceMoney()
        {
            if (_insurance)
                _money -= _bet / 2;
        }

        public string GetStringCardsInHand(int indexHand)
        {
            return _hands[indexHand].GetStringCardsInHand(false);
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

    }
}
