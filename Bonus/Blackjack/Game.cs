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

        public Game(Deck deck, Player player, House house)
        {
            _deck = deck;
            _player = player;
            _house = house;
        }

        public void DealCardPlayer(int indexHand)
        {
            Card card = _deck.GetAndRemoveCard();
            _player.DealCard(card, indexHand);
        }

        public void DealCardHouse()
        {
            Card card = _deck.GetAndRemoveCard();
            _house.DealCard(card);
        }

        public void EndRound()
        {
            while (_house.GetHandValue() < 17)
            {
                DealCardHouse();
            }

            Console.WriteLine("Huset har: " + _house.GetHandValue().ToString() + "\nDu har: " + _player.GetHandValue(0).ToString());
        }
    }
}
