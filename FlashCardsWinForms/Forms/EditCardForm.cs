using FlashCardsWinForms.Presenters;
using FlashCardsWinForms.Views;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCardsWinForms.Forms
{
    public partial class EditCardForm : MaterialForm, IEditCardFormView
    {
        private EditCardFormPresenter EditCardFormPresenter { get; set; }
        private string DeckName { get; set; }
        private string Question { get; set; }
        private string Answer { get; set; }

        public EditCardForm(string deckName, string question, string answer)
        {
            InitializeComponent();
            EditCardFormPresenter = new EditCardFormPresenter(this);
            DeckName = deckName;
            Question = question;
            Answer = answer;
        }

        private void EditCardForm_Load(object sender, EventArgs e)
        {
            EditCardFormPresenter.PopulateForm(Question, Answer);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            EditCardFormPresenter.UpdateEditedCard(DeckName, Question, Answer, richTextBox1.Text, richTextBox2.Text);
            Close();
        }

        //IEditCardFormView
        public void PopulateForm(string question, string answer)
        {
            richTextBox1.Text = question;
            richTextBox2.Text = answer;
        }

        public void AlertUser(string message)
        {
            MessageBox.Show(message);
        }
    }
}
