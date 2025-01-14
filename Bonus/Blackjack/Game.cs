using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Game
    {

        private Deck _deck;
        private Player _player;
        private House _house;
        private bool _endRoundBool = false;

        public Game(Deck deck, Player player, House house)
        {
            _deck = deck;
            _player = player;
            _house = house;
        }

        public string GetWriteString(int indexHand)
        {
            string writeString = "Hva vil du gjøre ?: 1 - Trekke et kort. 2 - Stå";
            if (_player.GetNumberOfCardsInHand(indexHand) < 3)
            {
                writeString += " 3 - Doble.";
                if (_player.CheckIfCardsAreSame(indexHand))
                    writeString += " 4 - Split.";
            }
            

            return writeString;
        }

        public void StartRound()
        {
            _endRoundBool = false;
            _player.SetInsurance(false);
            _house.ResetCards();
            _player.ResetCards();
        }

        public void DealCardPlayer(int indexHand, bool writeInfo)
        {

            Card card = _deck.GetAndRemoveCard();
            _player.DealCard(card, indexHand);
            if (writeInfo)
            {
                Console.WriteLine("Du trakk: " + _player.GetStringCardsInHand(indexHand, true));
            }

            if(_player.GetHandValue(indexHand) > 21)
            {
                Console.WriteLine("Du sprakk!");
                _player.HandDone(indexHand);
            }
                
        }

        public void DealCardHouse()
        {
            Card card = _deck.GetAndRemoveCard();
            _house.DealCard(card);
        }

        public void EndRound()
        {
            _endRoundBool = true;
            while (_house.GetHandValue() < 17)
            {
                DealCardHouse();
            }
            Console.WriteLine("Hånden til huset er: " + _house.GetStringCardsInHand(false));
            Console.WriteLine("Huset har: " + _house.GetHandValue().ToString() + "\nDu har: " + _player.GetHandValue(0).ToString());

            for (int i = 0; i < _player.GetNumberOfHands(); i++) 
            {
                if (_player.GetHandValue(i) > 21)
                {
                    Console.WriteLine("Sprukket hånd");
                    _player.RemoveOrAddMoney(false, 1, i);
                }
                else if (_player.GetHandValue(i) == _house.GetHandValue())
                {
                    Console.WriteLine("Det er likt, du beholder potten");
                }
                else if (_player.HasBlackJack(i))
                {
                    Console.WriteLine("Du har blackjack!");
                    _player.RemoveOrAddMoney(true, 1.5, i);
                }

                else if (_player.GetHandValue(i) > _house.GetHandValue() || _house.GetHandValue() > 21)
                {
                    Console.WriteLine("Hånd vunnet");
                    _player.RemoveOrAddMoney(true, 1, i);

                }
                else if(_player.GetHandValue(i) < _house.GetHandValue())
                {
                    Console.WriteLine("Hånden tapte");
                    _player.RemoveOrAddMoney(false, 1, i);
                }

            }

            Console.WriteLine("Du har " + _player.GetMoney() + "kr igjen");
            /*
             * Gjøre opp.
             * 1 For hver hånd som er sprukket, trekke fra spiller.
             * 2. For hver hånd som er tied, ikke noe.
             * 3. For hver hånd som er vunnet, utbetale tilsvarende bet eller hvis hånden har blackjack utbetale 1.5x bet. Er vunnet når spiller har mer enn huset eller huset har sprukket.
             * 4. Hvis huset vinner trekke fra bet og skrive huset vant.
             */
        }


        public bool CheckIfRoundEnded()
        {
            return _endRoundBool;
        }
    }
}
