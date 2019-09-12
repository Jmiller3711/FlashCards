using FlashCardsWinForms.Presenters;
using FlashCardsWinForms.Views;
using System;
using System.Windows.Forms;

namespace FlashCardsWinForms
{
    public partial class NewDeckForm : Form, INewDeckFormView
    {
        private NewDeckFormPresenter NewDeckFormPresenter { get; set; }
        public string NewDeckName { get; set; }

        public NewDeckForm()
        {
            InitializeComponent();
            NewDeckFormPresenter = new NewDeckFormPresenter(this);
        }

        private void button1_Click(object sender, EventArgs e) //add
        {
            NewDeckName = NewDeckFormPresenter.AddNewDeck(textBox1.Text);
            if (NewDeckName != null)
            {
                Close();
            }
        }

        //INewDeckFormView
        public void AlertUser(string message)
        {
            MessageBox.Show(message);
        }
    }
}
