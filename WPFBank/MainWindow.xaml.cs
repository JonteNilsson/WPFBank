using System.Windows;

namespace WPFBank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ClearInputs();

        }

        private void ClearInputs()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            AccountsWindow accountsWindow = new();
            accountsWindow.Show();
            Close();
        }

        private void btnRegisterUser_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new();
            registerWindow.Show();
            Close();
        }

        private void btnAdminlogin_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow adminWindow = new();
            adminWindow.Show();
            Close();
        }
    }
}
