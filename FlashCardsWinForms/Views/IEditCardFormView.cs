namespace FlashCardsWinForms.Views
{
    public interface IEditCardFormView
    {
        void PopulateForm(string question, string answer);
        void AlertUser(string message);
    }
}
