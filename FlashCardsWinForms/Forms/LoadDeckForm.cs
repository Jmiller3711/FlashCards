using FlashCardsWinForms.Presenters;
using FlashCardsWinForms.Views;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlashCardsWinForms
{
    public partial class LoadDeckForm : MaterialForm, ILoadDeckFormView
    {
        private LoadDeckFormPresenter LoadDeckFormPresenter { get; set; }
        public string DeckToLoad { get; set; }

        //Events
        public LoadDeckForm()
        {
            InitializeComponent();
            LoadDeckFormPresenter = new LoadDeckFormPresenter(this);
        }

        private void LoadDeck_Load(object sender, EventArgs e)
        {
            LoadDeckFormPresenter.PresentComboBox();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            DeckToLoad = comboBox1.Text;
            Close();
        }

        //ILoadDeckFormView
        public void LoadComboBox(List<string> deckNames)
        {
            comboBox1.DataSource = deckNames;
        }
    }
}
