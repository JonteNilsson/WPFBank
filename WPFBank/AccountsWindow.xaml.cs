using System.Windows;
using WPFBank.Classes;

namespace WPFBank
{
    /// <summary>
    /// Interaction logic for AccountsWindow.xaml
    /// </summary>
    public partial class AccountsWindow : Window
    {
        Client currentClient;
        public AccountsWindow(Client client)
        {
            InitializeComponent();
            this.currentClient = client;
            UpdateCurrentAccountUI();
        }

        private void btnReturnFromRegistration_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            Close();
        }
        private void btnTransfer_Click(object sender, RoutedEventArgs e)
        {
            currentClient._SalaryBalance += decimal.Parse(txtTransfer.Text);
            currentClient._SavingsBalance -= decimal.Parse(txtTransfer.Text);
            UpdateCurrentAccountUI();


        }
        private void UpdateCurrentAccountUI()
        {
            txtSalaryBalance.Text = "";
            txtSavingsBalance.Text = "";
            txtTransfer.Text = "";

            txtAccountNumber.Text = currentClient.GetHashCode().ToString();
            txtSalaryBalance.Text = currentClient._SalaryBalance.ToString();
            txtSavingsBalance.Text = currentClient._SavingsBalance.ToString();
            lblUserName.Content = currentClient._ClientUsername;
        }


    }
}
