using FlashCardsWinForms.Presenters;
using FlashCardsWinForms.Views;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace FlashCardsWinForms
{
    public partial class AddCardForm : MaterialForm, IAddCardFormView
    {
        private AddCardFormPresenter AddCardFormPresenter { get; set; }
        private string CurrentDeck { get; set; }

        public AddCardForm(string currentDeck)
        {
            InitializeComponent();
            AddCardFormPresenter = new AddCardFormPresenter(this);
            CurrentDeck = currentDeck;
        }

        //Events
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            AddCardFormPresenter.AddCardToDeck(CurrentDeck, richTextBox1.Text, richTextBox2.Text);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        //IAddCardFormView
        public void AlertUser(string message)
        {
            MessageBox.Show(message);
        }

        public void ClearAddCardContents()
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }
    }
}
