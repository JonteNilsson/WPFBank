using System.Windows;

namespace WPFBank
{
    /// <summary>
    /// Interaction logic for AccountsWindow.xaml
    /// </summary>
    public partial class AccountsWindow : Window
    {
        public AccountsWindow()
        {
            InitializeComponent();
        }

        private void btnReturnFromRegistration_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            Close();
        }
    }
}
