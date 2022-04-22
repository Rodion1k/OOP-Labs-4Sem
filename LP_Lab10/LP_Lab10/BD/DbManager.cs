using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace LP_Lab10.BD
{
    public class DbManager
    {
        private static DbManager _instance;
        private static readonly object _lock = new object();
        private SqlConnection _connection;
        private string _connectionString;

        private DbManager()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public static DbManager GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DbManager();
                    }
                }
            }

            return _instance;
        }

        public bool GetConnection(string connectionString)
        {
            try
            {
                _connection = new SqlConnection(connectionString);
                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public void ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand(query, connection, transaction);
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    transaction.Rollback();
                }
            }
        }

        public void AddTeacher(SqlParameter[] parameters)
        {
            using (SqlCommand command = new SqlCommand("AddTeacher", new SqlConnection(_connectionString)))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameters);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void ExecuteQuery(string query, SqlParameter[] parameters) //параметризированный 
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlCommand command = new SqlCommand(query, connection, transaction);
                    command.Parameters.AddRange(parameters);
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    transaction.Rollback();
                }
            }
        }


        public DataSet GetDataSet(string query)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                DataTable dataTable = dataSet.Tables[0];
                return dataSet;
            }
        }

        public void DeleteRow(string query, IList dataGridSelectedItems)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    DataTable dataTable = dataSet.Tables[0];
                    string[] id = new string[dataGridSelectedItems.Count];
                    string columnID = dataTable.Columns[0].ColumnName;
                    DataRow[] selectedCells = new DataRow[dataGridSelectedItems.Count];
                    for (int i = 0; i < dataGridSelectedItems.Count; i++)
                    {
                        DataRowView row = dataGridSelectedItems[i] as DataRowView;
                        id[i] = row.Row.ItemArray[0].ToString().Trim(new char[] { ' ' });
                        ;
                        selectedCells[i] = dataTable.Select($"{columnID} = '{id[i]}'").First();
                    }

                    for (int i = 0; i < selectedCells.Length; i++)
                    {
                        selectedCells[i].Delete();
                    }

                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Update(dataSet);
                    UndoManager.Add(dataSet);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    //transaction.Rollback();
                }
            }
        }

        public void UpdateRow(string dataSetString, string editedText, int columnIndex, string id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))//loadDataRow
            {
                SqlDataAdapter adapter = new SqlDataAdapter(dataSetString, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                DataTable dataTable = dataSet.Tables[0];
                DataRow selectedRow = dataTable.Select($"{dataTable.Columns[0].ColumnName} = '{id}'").First();
                selectedRow[columnIndex] = editedText;
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(dataSet);
            }
        }

        public void UpdateTable(string dataSetString, DataSet dataSet)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(dataSetString, connection);
                DataSet _dataSet = new DataSet();
                adapter.Fill(_dataSet);
                _dataSet.Clear();
                
                 // DataTableReader reader = dataSet.CreateDataReader(); не работает
                 // _dataSet.Load(reader, LoadOption.PreserveChanges, _dataSet.Tables[0]);
                 ;
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(_dataSet);
            }
        }
    }
}