using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Media3D;
using LP_Lab10.BD;

namespace LP_Lab10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private string _dataSetString;
        private DataSet _dataSet;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.ShowDialog();
        }

        private void RadioButton_OnClick(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            switch (radioButton?.Name)
            {
                case "RadioButtonStudent":
                    _dataSetString = "SELECT * FROM STUDENT";
                    break;
                case "RadioButtonTeacher":
                    _dataSetString = "SELECT * FROM TEACHER";
                    break;
                case "RadioButtonSubject":
                    _dataSetString = "SELECT * FROM SUBJECT";
                    break;
            }

            _dataSet = App.DbManager.GetDataSet(_dataSetString);
            UndoManager.Clear();
            UndoManager.Add(_dataSet);
            DataGrid.ItemsSource = _dataSet.Tables[0].DefaultView;
        }

        private void DelButton_OnClick(object sender, RoutedEventArgs e) // Костылечки подъехали!!!!
        {// ON DELETE и ON UPDATE cascade 
            App.DbManager.DeleteRow(_dataSetString, DataGrid.SelectedItems);
            DataGrid.ItemsSource = App.DbManager.GetDataSet(_dataSetString).Tables[0].DefaultView;
        }

        private void DataGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DelButton.IsEnabled = DataGrid.SelectedItems.Count != 0;
        }


        private void DataGrid_OnCellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            var textBox = e.EditingElement as TextBox;
            var editedText = textBox?.Text;
            var columnIndex = e.Column.DisplayIndex;
            var updatedRow = e.Row.Item as DataRowView;
            var id = updatedRow?.Row[0].ToString().TrimEnd();
            App.DbManager.UpdateRow(_dataSetString, editedText, columnIndex, id);
        }


        private void UndoButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (UndoManager.State > 0)
            {
                _dataSet = UndoManager.Undo();
                App.DbManager.UpdateTable(_dataSetString, _dataSet);
                DataGrid.ItemsSource = _dataSet.Tables[0].DefaultView;
                //TODO refresh
            }
        }

        private void RedoButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (UndoManager.State < UndoManager.Count - 1)
            {
                _dataSet = UndoManager.Redo();
                App.DbManager.UpdateTable(_dataSetString, _dataSet);
                DataGrid.ItemsSource = _dataSet.Tables[0].DefaultView;
            }
        }

        private void TestButton_OnClick(object sender, RoutedEventArgs e)
        {
            DataSet dataSet = new DataSet();

            DataTable customerTable = new DataTable();
            DataTable productTable = new DataTable();

            // This information is cosmetic, only.
            customerTable.TableName = "Customers";
            productTable.TableName = "Products";

            // Add the tables to the DataSet:
            dataSet.Tables.Add(customerTable);
            dataSet.Tables.Add(productTable);

            // Load the data into the existing DataSet.
            DataTableReader reader = GetReader();
            dataSet.Load(reader, LoadOption.OverwriteChanges,
                customerTable, productTable);


            DataTable GetCustomers()
            {
                // Create sample Customers table.
                DataTable table = new DataTable();
                table.TableName = "Customers";

                // Create two columns, ID and Name.
                DataColumn idColumn = table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Name", typeof(string));

                // Set the ID column as the primary key column.
                table.PrimaryKey = new DataColumn[] { idColumn };

                table.Rows.Add(new object[] { 0, "Mary" });
                table.Rows.Add(new object[] { 1, "Andy" });
                table.Rows.Add(new object[] { 2, "Peter" });
                table.AcceptChanges();
                return table;
            }

            DataTable GetProducts()
            {
                // Create sample Products table.
                DataTable table = new DataTable();
                table.TableName = "Products";

                // Create two columns, ID and Name.
                DataColumn idColumn = table.Columns.Add("ID",
                    typeof(int));
                table.Columns.Add("Name", typeof(string));

                // Set the ID column as the primary key column.
                table.PrimaryKey = new DataColumn[] { idColumn };

                table.Rows.Add(new object[] { 0, "Wireless Network Card" });
                table.Rows.Add(new object[] { 1, "Hard Drive" });
                table.Rows.Add(new object[] { 2, "Monitor" });
                table.Rows.Add(new object[] { 3, "CPU" });
                table.AcceptChanges();
                return table;
            }

            DataTableReader GetReader()
            {
                // Return a DataTableReader containing multiple
                // result sets, just for the sake of this demo.
                DataSet dataSetk = new DataSet();
                dataSetk.Tables.Add(GetCustomers());
                dataSetk.Tables.Add(GetProducts());
                return dataSetk.CreateDataReader();
            }
        }


        private void RefreshButton_OnClick(object sender, RoutedEventArgs e)
        {
            _dataSet = App.DbManager.GetDataSet(_dataSetString);
            DataGrid.ItemsSource = _dataSet.Tables[0].DefaultView;
        }
    }
}