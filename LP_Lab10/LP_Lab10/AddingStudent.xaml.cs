using System;
using System.Windows;
using System.Windows.Controls;

namespace LP_Lab10
{
    public partial class AddingStudent : Page
    {
        public AddingStudent()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            int idGroup = Convert.ToInt32(IDGROUP.Text);
            string name= NAME.Text;
            string bDay = BDAY.Text;//12.07.1994
            string query =
                $"INSERT INTO STUDENT (IDGROUP, NAME, BDAY) VALUES ({idGroup},'{name}','{bDay}')";
            App.DbManager.ExecuteQuery(query);
            MessageBox.Show($"Данные добавлены");
            
        }
    }
}