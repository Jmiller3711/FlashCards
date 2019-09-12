using FlashCardsWinForms.Presenters;
using FlashCardsWinForms.Views;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace FlashCardsWinForms
{
    public partial class NewDeckForm : MaterialForm, INewDeckFormView
    {
        private NewDeckFormPresenter NewDeckFormPresenter { get; set; }
        public string NewDeckName { get; set; }

        public NewDeckForm()
        {
            InitializeComponent();
            NewDeckFormPresenter = new NewDeckFormPresenter(this);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
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
