using FlashCardsWinForms.Views;
using System.Collections.Generic;
using FlashCardsWinForms.Models;

namespace FlashCardsWinForms.Presenters
{
    public class LoadDeckFormPresenter
    {
        private ILoadDeckFormView View { get; }

        public LoadDeckFormPresenter(ILoadDeckFormView view)
        {
            View = view;
        }

        public void PresentComboBox()
        {
            var spreadsheetConnector = new SpreadsheetConnector();
            var data = spreadsheetConnector.GetAllData();

            var deckNames = new List<string>();
            foreach (var card in data)
            {
                if (deckNames.Contains(card.DeckName)) continue;
                deckNames.Add(card.DeckName);
            }

            View.LoadComboBox(deckNames);
        }

    }
}
