using FlashCardsWinForms.Presenters;
using FlashCardsWinForms.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlashCardsWinForms
{
    public partial class LoadDeckForm : Form, ILoadDeckFormView
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

        private void button1_Click(object sender, EventArgs e) //load
        {
            DeckToLoad = comboBox1.Text;
            Close();
            //TODO if user presses red X then DeckToLoad can be null
        }

        //ILoadDeckFormView
        public void LoadComboBox(List<string> deckNames)
        {
            comboBox1.DataSource = deckNames;
        }
    }
}
