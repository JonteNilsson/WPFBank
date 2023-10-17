using System.Windows;
using WPFBank.Classes;
using WPFBank.UserClasses;

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
            // Läs av textboxarna
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            if (userName == "Admin" && password == "Admin")
            {
                btnAdminlogin.Visibility = Visibility.Visible;

            }
            // Kolla så inputs ej är tomma er är tomma
            if (userName != "" && password != "")
            {
                if (UserManager.Clients.Count != 0)
                {

                    foreach (Client user in UserManager.Clients)
                    {

                        if (userName == user._Username && password == user._Password)
                        {

                            Client selectedUser = user;


                            AccountsWindow newAccountWindow = new(selectedUser);
                            newAccountWindow.Show();
                            Close();

                        }

                    }
                }
                if (UserManager.Clients.Count == 0)
                {
                    MessageBox.Show("No users registered");
                }

                else
                {
                    MessageBox.Show("User is not found!");
                }

            }

            else if (userName == "" || password == "")
            {
                MessageBox.Show("Please enter all fields!");
            }


        }

        private void btnRegisterUser_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow newRegiserWindow = new();
            newRegiserWindow.Show();
            Close();

        }

        private void btnAdminlogin_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            foreach (Client users in UserManager.Clients)
            {
                if (txtUsername.Text == "Admin" && txtPassword.Text == "Admin")
                {

                    AdminWindow newAdminWindow = new();
                    newAdminWindow.Show();
                    Close();
                }
            }

        }
    }
}
