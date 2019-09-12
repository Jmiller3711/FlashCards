using System.Collections.Generic;

namespace FlashCardsWinForms.Views
{
    public interface ILoadDeckFormView
    {
        void LoadComboBox(List<string> deckNames);
    }
}
