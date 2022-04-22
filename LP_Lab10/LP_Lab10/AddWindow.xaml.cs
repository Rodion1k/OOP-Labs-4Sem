using System.Windows;
using System.Windows.Controls;

namespace LP_Lab10
{
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
            AddFrame.Navigate(new AddingStudent());
            // create regular expression with oliy numbers 1- 10 digits 
            // and letters A-Z
            //Regex reg = new Regex(@"^[0-9]{1,10}$");
        }

        private void RadioButton_OnClick(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            switch (rb?.Name)
            {
                case "RadioButtonStudent":
                    AddFrame.Navigate(new AddingStudent());
                    break;
                case "RadioButtonTeacher":
                    AddFrame.Navigate(new AddingTeacher());
                    break;
                case "RadioButtonSubject":
                    AddFrame.Navigate(new AddingSubject());
                    break;
            }
        }
    }
}