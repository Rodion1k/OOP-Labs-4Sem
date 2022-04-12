using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Windows.Resources;

namespace GameStore
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public static string Language { get; set; }
        public static string Theme { get; set; }
        public App()
        {
            InitializeComponent();
            Language = "en";
        }
    }
}