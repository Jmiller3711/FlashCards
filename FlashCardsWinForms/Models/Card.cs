using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCardsWinForms.Models
{
    public class Card
    {
        public string DeckName { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public Card(string deckName, string question, string answer)
        {
            DeckName = deckName;
            Question = question;
            Answer = answer;
        }
    }
}
