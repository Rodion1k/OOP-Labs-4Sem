using System;
using System.Configuration;
using System.Data.SqlClient;
using LP_Lab10.BD;

namespace LP_Lab10
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public static DbManager DbManager { get; set; }

        public App()
        {
            InitializeComponent();
         
            
            DbManager = DbManager.GetInstance();
            try
            {
                // TODO проверить подключение если connection.state не ок то создать бд
               // DbManager.OpenConnection(); 
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}