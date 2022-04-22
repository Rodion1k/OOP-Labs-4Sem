using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace LP_Lab10
{
    public partial class AddingTeacher : Page
    {
        public AddingTeacher()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e) // TODO не работае
        {
            string teacher = TEACHER.Text;
            string name = TEACHER_NAME.Text;
            char gender = GENDER.Text[0];
            string pulpit = PULPIT.Text;
            string query =
                "INSERT INTO TEACHER (TEACHER, TEACHER_NAME, GENDER, PULPIT) VALUES (@teacher, @name, @gender,@pulpit)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@teacher",teacher),
                new SqlParameter("@name",name),
                new SqlParameter("@gender",gender),
                new SqlParameter("@pulpit",pulpit),
            };
            App.DbManager.AddTeacher(parameters);
           // App.DbManager.ExecuteQuery(query, parameters);
            MessageBox.Show($"Данные добавлены");
        }
    }
}