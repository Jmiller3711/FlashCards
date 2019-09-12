using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCardsWinForms.Models
{
    public class Deck
    {
        public List<Card> Cards { get; set; }
        public string DeckName { get; set; }
        public Card CurrentCard { get; set; }

        public Deck(List<Card> cards)
        {
            Cards = cards;
            DeckName = cards.FirstOrDefault()?.DeckName;
            CurrentCard = cards.FirstOrDefault();
        }

        public void GetNextCard(string currentCardQuestion, string currentCardAnswer)
        {
            var cardIndex = 0;
            foreach (var card in Cards)
            {
                if (card.Question == currentCardQuestion && card.Answer == currentCardAnswer)
                {
                    if (cardIndex + 1 < Cards.Count)
                    {
                        CurrentCard = Cards[cardIndex + 1];
                        return;
                    }
                    else
                    {
                        CurrentCard = Cards[0];
                        return;
                    }
                }
                cardIndex++;
            }
        }

        public void GetPreviousCard(string currentCardQuestion, string currentCardAnswer)
        {
            var cardIndex = 0;
            foreach (var card in Cards)
            {
                if (card.Question == currentCardQuestion && card.Answer == currentCardAnswer)
                {
                    if (cardIndex - 1 >= 0)
                    {
                        CurrentCard = Cards[cardIndex - 1];
                        return;
                    }
                    else
                    {
                        CurrentCard = Cards.LastOrDefault();
                        return;
                    }
                }
                cardIndex++;
            }
        }
    }
}
