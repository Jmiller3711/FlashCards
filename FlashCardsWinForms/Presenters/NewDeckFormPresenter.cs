using FlashCardsWinForms.Models;
using FlashCardsWinForms.Views;
using System.Collections.Generic;

namespace FlashCardsWinForms.Presenters
{
    public class NewDeckFormPresenter
    {
        private INewDeckFormView View;
        public NewDeckFormPresenter(INewDeckFormView view)
        {
            View = view;
        }

        public string AddNewDeck(string newDeckName)
        {
            if (InvalidData(newDeckName)) { return null; }
            var spreadsheetConnector = new SpreadsheetConnector();
            spreadsheetConnector.AppendData(new List<Card> { new Card(newDeckName, "Sample Question: 1+1 = ?", "Sample Answer: 1+1 = 2") });
            return newDeckName;
        }

        private bool InvalidData(string newDeckName)
        {
            if (TextBoxEmpty(newDeckName))
            {
                View.AlertUser("Must provide a valid deck name");
                return true;
            }
            if (DuplicateData(newDeckName))
            {
                View.AlertUser("It appears that there is already a deck with this name, please choose another name");
                return true;
            }
            return false;
        }

        private bool DuplicateData(string newDeckName)
        {
            var spreadsheetConnector = new SpreadsheetConnector();
            var allCards = spreadsheetConnector.GetAllData();
            foreach (var card in allCards)
            {
                if (card.DeckName == newDeckName)
                {
                    return true;
                }
            }
            return false;
        }

        private bool TextBoxEmpty(string text)
        {
            return text == "" ? true : false;
        }
    }
}
