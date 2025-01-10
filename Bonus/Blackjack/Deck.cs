using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Deck
    {
        private List<Card> _cards = new List<Card>();
        private List<Card> _shuffledCards = new List<Card>();

        public Deck()
        {
            CreateDeck();
        }


        private void CreateDeck()
        {
            _cards.Clear();
            string rankString = " ";
            foreach (SuitEnum suit in Enum.GetValues(typeof(SuitEnum)))
            {

                for (int i = 2; i < 15; i++)
                {
                    RankEnum rank;
                    if (i <= 10)
                    {
                        rank = (RankEnum)i;
                        rankString = Enum.GetName(typeof(RankEnum), rank);
                    }

                    else
                    {
                        rank = (RankEnum)10;
                        switch (i)
                        {
                            case 11:
                                rankString = "Jack";
                                break;
                            case 12:
                                rankString = "Queen";
                                break;
                            case 13:
                                rankString = "King";
                                break;
                            case 14:
                                rank = RankEnum.Ace; rankString = "Ace";
                                break;
                        }
                    }

                    _cards.Add(new Card(suit, rank, rankString));
                }
            }
        }
        public void ShuffleCards()
        {
            _shuffledCards.Clear();
            Random random = new Random();

            for (int i = 0; i < 52; i++)
            {
            var RandomNr = random.Next(0, _cards.Count);
            _shuffledCards.Add(_cards[RandomNr]);
            _cards.Remove(_cards[RandomNr]);
            }
        }

        public void ReShuffle()
        {
            CreateDeck();
            ShuffleCards();
        }

        public Card GetAndRemoveCard()
        {
            Card card;
            if (_cards.Count <= 10)
                ReShuffle();
            card = _shuffledCards[0];
            _shuffledCards.RemoveAt(0);
            return card;


            
        }



        public void WriteAllCards()
        {
            foreach (var card in _shuffledCards)
            {
                Console.Write(card.GetRank() + " ");
                Console.Write(card.GetRankString() + " ");
                Console.WriteLine(card.GetSuit());

            }
        }
    }
}
