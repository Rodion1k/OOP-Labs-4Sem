using System;
using System.Collections.ObjectModel;
using System.Windows;
using GameStore.UndoRedo;
using Microsoft.Win32;

namespace GameStore
{
    public partial class AddGameWindow : Window
    {
        public Game Game { get; set; }

        public AddGameWindow()
        {
            InitializeComponent();
            Game = new Game();
        }

        private void AddGameButton_OnClick(object sender, RoutedEventArgs e)
        {
            Game.Name = NameTextBox.Text;
            Game.Price = Convert.ToSingle(PriceTextBox.Text);
            Game.Rating = Convert.ToInt32(RatingTextBox.Text);
            Game.Description = DescriptionTextBox.Text;
            ShopPage.AddGame(Game);
            UndoManager.Add(new ObservableCollection<Game>(ShopPage.Games)); 
        }

        private void AddImage_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter =
                "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == true)
            {
                Game.ImagePath = openFileDialog.FileName;
            }
        }
    }
}