using System;
using System.Windows;

using WPFBank.Classes;
using WPFBank.UserClasses;

namespace WPFBank
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Random newSavings = new Random();
            // Läs av alla textboxar
            string userName = txtRegisterUser.Text;
            string password = txtRegisterPassword.Text;
            decimal salaryBalance = 0;
            decimal savingsBalance = newSavings.Next(0, 1001);

            // Kolla så input ej är tomma
            if (userName != "" && password != "")
            {
                // Skapa ny client
                Client newClient = new(userName, password, salaryBalance, savingsBalance);
                // Sätt username och password läst från textbox för inlogg
                newClient._Username = userName;
                newClient._Password = password;

                // Lägg till ny user i user"databas"
                UserManager.Clients.Add(newClient);

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Please input all fields!");
            }
        }

        private void btnReturnFromRegistration_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
