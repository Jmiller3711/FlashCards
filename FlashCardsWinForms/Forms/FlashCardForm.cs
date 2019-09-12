using FlashCardsWinForms.Presenters;
using System;
using FlashCardsWinForms.Views;
using System.Windows.Forms;

namespace FlashCardsWinForms
{
    public partial class FlashCardForm : Form, IFlashCardFormView
    {
        //PROJECT TODO LIST:
        //Max/Min Form Dimensions
        //Color Coding?
        //Upload to GitHub Account

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

        private void button3_Click_1(object sender, EventArgs e) //SHOW ANSWER
        {
            FlashCardFormPresenter.RevealAnswer(CurrentDeck);
        }

        private void button2_Click(object sender, EventArgs e) //<
        {
            FlashCardFormPresenter.GetPreviousCard(CurrentDeck, richTextBox1.Text, richTextBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e) //>
        {
            FlashCardFormPresenter.GetNextCard(CurrentDeck, richTextBox1.Text, richTextBox2.Text);
        }

        private void FlashCardForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                button1_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.Left)
            {
                button2_Click(sender, new EventArgs());
            }
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                button3_Click_1(sender, new EventArgs());
            }
        }

        //IFlashCardFormView
        public void UpdateDeckLabel(string deckName)
        {
            label1.Text = deckName;
        }

        public void ShowCard(string question, string answer)
        {
            richTextBox1.Text = question;
            richTextBox2.Text = answer;
        }

        public void RevealAnswer()
        {
            richTextBox2.Visible = true;
        }

        public void HideAnswer()
        {
            richTextBox2.Visible = false;
        }

        public void AlertUser(string message)
        {
            MessageBox.Show(message);
        }

        public void Reset()
        {
            label1.Text = "No Deck Loaded";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            CurrentDeck = null;
        }
    }
}
