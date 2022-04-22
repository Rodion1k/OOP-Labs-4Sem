using System;
using System.Windows;
using System.Windows.Controls;

namespace LP_Lab10
{
    public partial class AddingSubject : Page
    {
        public AddingSubject()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            string subjectName = SUBJECT_NAME.Text;
            string subject = SUBJECT.Text;
            string pulpit = PULPIT.Text;
            string query =
                $"INSERT INTO SUBJECT (SUBJECT, SUBJECT_NAME, PULPIT) VALUES ('{subject}','{subjectName}','{pulpit}')";
            App.DbManager.ExecuteQuery(query);
            MessageBox.Show($"Данные добавлены");
        }
    }
}