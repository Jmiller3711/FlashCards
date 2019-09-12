using FlashCardsWinForms.Models;
using FlashCardsWinForms.Views;
using System.Collections.Generic;

namespace FlashCardsWinForms.Presenters
{
    public class EditCardFormPresenter
    {
        private IEditCardFormView View;

        public EditCardFormPresenter(IEditCardFormView view)
        {
            View = view;
        }

        public void PopulateForm(string question, string answer)
        {
            View.PopulateForm(question, answer);
        }

        public void UpdateEditedCard(string deckName, string question, string answer, string newQuestion, string newAnswer)
        {
            if (InvalidData(deckName, newQuestion, newAnswer)) return;
            var spreadsheetConnector = new SpreadsheetConnector();
            spreadsheetConnector.DeleteCard(deckName, question, answer);
            spreadsheetConnector.AppendData(new List<Card>() { new Card(deckName, newQuestion, newAnswer) });
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
