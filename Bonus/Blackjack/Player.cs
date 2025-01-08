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

        public Player(int startingmoney)
        {
            _money = startingmoney;
        }

        public void SetBet(int bet)
        {
            _bet = bet;
        }

        public void RemoveOrAddMoney(bool increase)
        {
            if (increase)
            {
                _money += _bet;
            }
            else _money -= _bet;
        }
    }
}
