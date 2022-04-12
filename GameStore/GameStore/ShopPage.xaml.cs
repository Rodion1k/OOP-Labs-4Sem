using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using GameStore.Serialization;
using GameStore.UndoRedo;

namespace GameStore
{
    public partial class ShopPage : Page
    {
        public static ObservableCollection<Game> Games { get; set; }
        
        public ShopPage()
        {
            InitializeComponent();
            var observableCollection = new ObservableCollection<Game>();
            // Games = new ObservableCollection<Game>();
            // Games.Add(new Game(){Name = "Игра 1", Price = 100, Description = "Описание игры 1", Rating = 3});;
            // Serializer.Serialize(Games,@"D:\учеба\OOP\GameStore\GameStore\Serialization\games.json");
            if(Serializer.Deserialize(@"D:\учеба\OOP\GameStore\GameStore\Serialization\games.json",out observableCollection))
            {
                Games = observableCollection;
            }
            else
            {
                Games = new ObservableCollection<Game>();
            }
            UndoManager.Add(new ObservableCollection<Game>(Games));
            ListGames.ItemsSource = Games;
        }
        public static void AddGame(Game game)
        {
            Games.Add(game);
            Serializer.Serialize(Games,@"D:\учеба\OOP\GameStore\GameStore\Serialization\games.json");
        }

        
    }
}