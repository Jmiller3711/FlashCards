using FlashCardsWinForms.Models;
using FlashCardsWinForms.Views;
using System.Collections.Generic;

namespace FlashCardsWinForms.Presenters
{
    public class AddCardFormPresenter
    {
        private IAddCardFormView View;
        public AddCardFormPresenter(IAddCardFormView view)
        {
            View = view;
        }

        public void AddCardToDeck(string currentDeck, string question, string answer)
        {
            if (InvalidData(currentDeck, question, answer)) return;
            var spreadsheetConnector = new SpreadsheetConnector();
            spreadsheetConnector.AppendData(new List<Card>() { new Card(currentDeck, question, answer) });
            View.ClearAddCardContents();
        }

        private bool InvalidData(string currentDeck, string question, string answer)
        {
            if (RichTextBoxEmpty(question) || RichTextBoxEmpty(answer))
            {
                View.AlertUser("Question and Answer must contain data to create a card");
                return true;
            }
            if (DuplicateData(currentDeck, question, answer))
            {
                View.AlertUser("It appears that the card you are trying to create is a duplicate");
                return true;
            }
            return false;
        }

        private bool DuplicateData(string currentDeck, string question, string answer)
        {
            var spreadsheetConnector = new SpreadsheetConnector();
            var deck = spreadsheetConnector.GetDeck(currentDeck);
            foreach (var card in deck.Cards)
            {
                if (card.Question == question && card.Answer == answer)
                {
                    return true;
                }
            }
            return false;
        }

        private bool RichTextBoxEmpty(string text)
        {
            return text == "" ? true : false;
        }
    }
}
