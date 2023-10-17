using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using WPFBank.Classes;
using WPFBank.UserClasses;

namespace WPFBank
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {

            InitializeComponent();
            lstAccountInfo.Items.Clear();

            List<Client> clients = UserManager.Clients;



            foreach (Client client in clients)
            {
                ListViewItem item = new();

                item.Content = client._ClientUsername;

                item.Tag = client;

                lstAccountInfo.Items.Add(new
                {

                    AccountName = client._ClientUsername,
                    Savings = client._SavingsBalance,
                    Salary = client._SalaryBalance

                });
            }

        }

        private void btnReturnFromAdminView_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            Close();
        }
    }
}
