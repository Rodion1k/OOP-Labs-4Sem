using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Resources;
using GameStore.Serialization;
using GameStore.UndoRedo;
using GameStore.ViewModel;

namespace GameStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow  
    {
        private ShopPage _shopPage;

        public MainWindow()
        {
            InitializeComponent();
            StreamResourceInfo sri = Application.GetResourceStream(
                new Uri("Cursor/cursor.ani", UriKind.Relative));
            this.Cursor = new Cursor(sri.Stream);
            _shopPage = new ShopPage();
            MainFrame.Navigate(_shopPage);
        }

        private void AddGameButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddGameWindow gameWindow = new AddGameWindow();
            gameWindow.Show();
        }

        private void DeleteGameButton_OnClick(object sender, ExecutedRoutedEventArgs e)
        {
            var game = (Game)_shopPage.ListGames.SelectedItem;
            ShopPage.Games.Remove(game);
            UndoManager.Add(new ObservableCollection<Game>(ShopPage.Games)); 
            _shopPage.ListGames.Items.Refresh();
            Serializer.Serialize(ShopPage.Games, @"D:\учеба\OOP\GameStore\GameStore\Serialization\games.json");
        }


        private void ExitOnMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void SearchTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (ShopPage.Games == null)
                return;
            if (SearchTextBox.Text == "Search" || SearchTextBox.Text == "Поиск")
                return;
            var searchText = SearchTextBox.Text;
            List<Game> result = new List<Game>();
            if (searchText.Length > 0)
                result = ShopPage.Games.Where(game => game.Name.ToLower().Contains(searchText.ToLower())).ToList();
            else
                result = ShopPage.Games.ToList();
            _shopPage.ListGames.ItemsSource = new ObservableCollection<Game>(result);
        }

        private void MinButton_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MaxButton_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void LangRuButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (App.Language.Equals("ru"))
                return;
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri(String.Format("Resources/lang.ru-Ru.xaml"), UriKind.Relative);
            ResourceDictionary oldDictionary =
                Application.Current.Resources.MergedDictionaries.First(n =>
                    n.Source.OriginalString.StartsWith("Resources/lang"));
            int ind = Application.Current.Resources.MergedDictionaries.IndexOf(oldDictionary);
            Application.Current.Resources.MergedDictionaries.Remove(oldDictionary);
            Application.Current.Resources.MergedDictionaries.Insert(ind, dict);
            App.Language = "ru";
        }

        private void LangEnButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (App.Language.Equals("en"))
                return;
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri(String.Format("Resources/lang.en-Us.xaml"), UriKind.Relative);
            ResourceDictionary oldDictionary =
                Application.Current.Resources.MergedDictionaries.First(n =>
                    n.Source.OriginalString.StartsWith("Resources/lang"));
            int ind = Application.Current.Resources.MergedDictionaries.IndexOf(oldDictionary);
            Application.Current.Resources.MergedDictionaries.Remove(oldDictionary);
            Application.Current.Resources.MergedDictionaries.Insert(ind, dict);
            App.Language = "en";
        }


        private void WindowToolBar_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void ChangeThemeButton_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            ResourceDictionary dict = new ResourceDictionary(); // оптимизировать
            ResourceDictionary oldDictionary =
                Application.Current.Resources.MergedDictionaries.First(n =>
                    n.Source.OriginalString.StartsWith("Resources/Theme"));
            switch (oldDictionary.Source.OriginalString)
            {
                case "Resources/ThemeLight.xaml":
                    dict.Source = new Uri("Resources/ThemeDark.xaml", UriKind.Relative);
                    break;
                case "Resources/ThemeDark.xaml":
                    dict.Source = new Uri("Resources/ThemeLight.xaml", UriKind.Relative);
                    break;
            }

            int ind = Application.Current.Resources.MergedDictionaries.IndexOf(oldDictionary);
            Application.Current.Resources.MergedDictionaries.Remove(oldDictionary);
            Application.Current.Resources.MergedDictionaries.Insert(ind, dict);
        }

        private void CheckBox_OnChecked(object sender, RoutedEventArgs routedEventArgs)
        {
            RadioButton checkBox = sender as RadioButton;
            if (checkBox == null)
                return;
            switch (checkBox.Name)
            {
                case "NameCheckBox":
                    _shopPage.ListGames.ItemsSource = ShopPage.Games.OrderBy(n => n.Name);
                    break;
                case "RatingCheckBox":
                    _shopPage.ListGames.ItemsSource = ShopPage.Games.OrderByDescending(n => n.Rating);
                    break;
                case "PriceCheckBox":
                    _shopPage.ListGames.ItemsSource = ShopPage.Games.OrderByDescending(n => n.Price);
                    break;
            }
        }


        private void UndoButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (UndoManager.State > 0)
            {
                ShopPage.Games = UndoManager.Undo();
                Serializer.Serialize(ShopPage.Games,@"D:\учеба\OOP\GameStore\GameStore\Serialization\games.json");
                _shopPage.ListGames.ItemsSource = ShopPage.Games;
            }
        }

        private void RedoButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (UndoManager.State < UndoManager.Count - 1)
            {
                ShopPage.Games = UndoManager.Redo();
                Serializer.Serialize(ShopPage.Games,@"D:\учеба\OOP\GameStore\GameStore\Serialization\games.json");
                _shopPage.ListGames.ItemsSource = ShopPage.Games;
            }
        }
        

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            EventsWindow eventsWindow = new EventsWindow();
            eventsWindow.Show();
        }

        private void NameTextBox_OnTap(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("kek");
        }
    }
}