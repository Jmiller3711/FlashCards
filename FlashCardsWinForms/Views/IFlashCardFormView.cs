namespace FlashCardsWinForms.Views
{
    public interface IFlashCardFormView
    {
        void UpdateDeckLabel(string deckName);
        void ShowCard(string question, string answer);
        void AlertUser(string message);
        void RevealAnswer();
        void HideAnswer();
        void Reset();
    }
}
