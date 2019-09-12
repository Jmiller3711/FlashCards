using FlashCardsWinForms.Presenters;
using System;
using FlashCardsWinForms.Views;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace FlashCardsWinForms
{
    public partial class FlashCardForm : MaterialForm, IFlashCardFormView
    {
        private FlashCardFormPresenter FlashCardFormPresenter { get; set; }
        public string CurrentDeck { get; set; }

        public FlashCardForm()
        {
            InitializeComponent();
            FlashCardFormPresenter = new FlashCardFormPresenter(this);
        }

        //Events
        private void loadDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentDeck = FlashCardFormPresenter.LoadDeck();
            FlashCardFormPresenter.ShowFirstCard(CurrentDeck);
        }

        private void newDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlashCardFormPresenter.AddNewDeck();
        }

        private void deleteDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlashCardFormPresenter.DeleteDeck(CurrentDeck);
        }

        private void addCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlashCardFormPresenter.AddNewCard(CurrentDeck);
        }

        private void editCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlashCardFormPresenter.EditCurrentCard(CurrentDeck, richTextBox1.Text, richTextBox2.Text);
        }

        private void deleteCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlashCardFormPresenter.DeleteCurrentCard(CurrentDeck, richTextBox1.Text, richTextBox2.Text);
        }

        private void nextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FlashCardFormPresenter.GetNextCard(CurrentDeck, richTextBox1.Text, richTextBox2.Text);
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FlashCardFormPresenter.RevealAnswer(CurrentDeck);
        }

        private void backToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FlashCardFormPresenter.GetPreviousCard(CurrentDeck, richTextBox1.Text, richTextBox2.Text);
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            FlashCardFormPresenter.RevealAnswer(CurrentDeck);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)  //<
        {
            FlashCardFormPresenter.GetPreviousCard(CurrentDeck, richTextBox1.Text, richTextBox2.Text);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e) //>
        {
            FlashCardFormPresenter.GetNextCard(CurrentDeck, richTextBox1.Text, richTextBox2.Text);
        }

        private void FlashCardForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                materialRaisedButton1_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.Left)
            {
                materialRaisedButton2_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                materialRaisedButton3_Click(sender, new EventArgs());
            }
        }

        //IFlashCardFormView
        public void UpdateDeckLabel(string deckName)
        {
            label1.Text = "Deck: " + deckName;
        }

        public void ShowCard(string question, string answer)
        {
            richTextBox1.Text = question;
            richTextBox2.Text = answer;
        }

        public void RevealAnswer()
        {
            richTextBox2.Visible = true;
            materialDivider1.Visible = false;
        }

        public void HideAnswer()
        {
            richTextBox2.Visible = false;
            materialDivider1.Visible = true;
        }

        public void AlertUser(string message)
        {
            MessageBox.Show(message);
        }

        public void Reset()
        {
            label1.Text = "Deck: No Deck Loaded";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            CurrentDeck = null;
        }
    }
}
