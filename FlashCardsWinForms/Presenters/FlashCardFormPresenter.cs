using System.Windows.Forms;
using FlashCardsWinForms.Views;
using FlashCardsWinForms.Models;
using FlashCardsWinForms.Forms;

namespace FlashCardsWinForms.Presenters
{
    public class FlashCardFormPresenter
    {
        private readonly IFlashCardFormView View;

        public FlashCardFormPresenter(IFlashCardFormView view)
        {
            View = view;
        }

        public void ShowFirstCard(string currentDeck)
        {
            var spreadsheetConnector = new SpreadsheetConnector();
            var deck = spreadsheetConnector.GetDeck(currentDeck);
            View.ShowCard(deck.CurrentCard.Question, deck.CurrentCard.Answer);
        }

        public string LoadDeck()
        {
            var loadDeck = new LoadDeckForm();
            loadDeck.ShowDialog();
            View.UpdateDeckLabel(loadDeck.DeckToLoad);
            return loadDeck.DeckToLoad;
        }

        public void AddNewDeck()
        {
            var newDeck = new NewDeckForm();
            newDeck.ShowDialog();
            if (newDeck.NewDeckName != null)
            {
                ShowFirstCard(newDeck.NewDeckName);
                View.UpdateDeckLabel(newDeck.NewDeckName);
            }
        }

        public void AddNewCard(string currentDeck)
        {
            if (!DeckLoaded(currentDeck)) return;
            var addCardForm = new AddCardForm(currentDeck);
            addCardForm.ShowDialog();
        }

        public void EditCurrentCard(string currentDeck, string question, string answer)
        {
            if (!DeckLoaded(currentDeck)) return;
            var editCardForm = new EditCardForm(currentDeck, question, answer);
            editCardForm.ShowDialog();
        }


        public void DeleteCurrentCard(string currentDeck, string question, string answer)
        {
            if (!DeckLoaded(currentDeck)) return;
            var spreadsheetConnector = new SpreadsheetConnector();
            if (MessageBox.Show("Delete this card from the deck?", "Delete", MessageBoxButtons.OK) == DialogResult.OK)
            {
                spreadsheetConnector.DeleteCard(currentDeck, question, answer);
                ShowFirstCard(currentDeck);
            }
        }

        public void GetNextCard(string currentDeck, string question, string answer)
        {
            if (!DeckLoaded(currentDeck)) return;
            var spreadsheetConnector = new SpreadsheetConnector();
            var deck = spreadsheetConnector.GetDeck(currentDeck);
            deck.GetNextCard(question, answer);
            View.HideAnswer();
            View.ShowCard(deck.CurrentCard.Question, deck.CurrentCard.Answer);
        }

        public void GetPreviousCard(string currentDeck, string question, string answer)
        {
            if (!DeckLoaded(currentDeck)) return;
            var spreadsheetConnector = new SpreadsheetConnector();
            var deck = spreadsheetConnector.GetDeck(currentDeck);
            deck.GetPreviousCard(question, answer);
            View.HideAnswer();
            View.ShowCard(deck.CurrentCard.Question, deck.CurrentCard.Answer);
        }

        public void DeleteDeck(string currentDeck)
        {
            if (!DeckLoaded(currentDeck)) return;
            if (MessageBox.Show("Delete this deck?", "Delete", MessageBoxButtons.OK) == DialogResult.OK)
            {
                var spreadsheetConnector = new SpreadsheetConnector();
                spreadsheetConnector.DeleteDeck(currentDeck);
                View.Reset();
            }
        }

        public void RevealAnswer(string currentDeck)
        {
            if (!DeckLoaded(currentDeck)) return;
            View.RevealAnswer();
        }

        private bool DeckLoaded(string currentDeck)
        {
            if (currentDeck == null)
            {
                View.AlertUser("Please Load Deck");
                return false;
            }
            return true;
        }
    }
}
