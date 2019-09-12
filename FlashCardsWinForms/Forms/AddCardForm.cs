using FlashCardsWinForms.Presenters;
using FlashCardsWinForms.Views;
using System;
using System.Windows.Forms;

namespace FlashCardsWinForms
{
    public partial class AddCardForm : Form, IAddCardFormView
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
        private void button1_Click(object sender, EventArgs e) //Add
        {
            AddCardFormPresenter.AddCardToDeck(CurrentDeck, richTextBox1.Text, richTextBox2.Text);
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
