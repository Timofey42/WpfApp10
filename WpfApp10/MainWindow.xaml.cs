using System;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace MyApplication
{
    public partial class MainWindow : Window
    {
        //private string connectionString = "Model.edmx"; // Укажите вашу строку подключения
        //private string connectionString = "Server=DESKTOP-C5E3SUH\\SERVER;Database=словарь;Integrated Security=True;";
        public MainWindow()
        {
            InitializeComponent();
            Slovar.ItemsSource = Entities.GetContext().Table.ToList();
        }

        //private void LoadData()
        //{
        //    DataTable dt = new DataTable();
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string query = "SELECT * FROM Таблица"; // Замените YourTableName на имя вашей таблицы
        //        SqlCommand command = new SqlCommand(query, connection);

        //        connection.Open();

        //        // Выполнение запроса и обработка результатов
        //    }

        //    dataGrid.ItemsSource = dt.DefaultView;
        //}

        //private void AddButton_Click(object sender, RoutedEventArgs e)
        //{
        //    // Create a new window for adding a definition
        //    AddDefinitionWindow addWindow = new AddDefinitionWindow();

        //    // Open the window as a dialog to block the main window until it's closed
        //    bool? result = addWindow.ShowDialog();

        //    // After closing the dialog window, check the result
        //    if (result == true) // User confirmed adding the definition
        //    {
        //        TextBox nameTextBox = addWindow.nameTextBox as TextBox;
        //        TextBox principal_idTextBox = addWindow.principal_IdTextBox as TextBox;

        //        if (nameTextBox != null && principal_idTextBox != null)
        //        {
        //            string name = nameTextBox.Text;
        //            int principalId;
        //            if (Int32.TryParse(principal_idTextBox.Text, out principalId))
        //            {
        //                // Continue with your logic to save this data to your SQL table
        //            }
        //        }
        //    }
        //    LoadData(); // Reload data after adding a new record
        //}


        //// Provide logic for deleting a selected row from the table
        //private void DeleteButton_Click(object sender, RoutedEventArgs e)
        //{
        //    // Logic to delete the selected row from the table
        //}
    }
}
