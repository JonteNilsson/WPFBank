using WPFBank.UserClasses;

namespace WPFBank.Classes
{
    public class Admin : User
    {
        public string Adminusername { get; set; } = "Admin";
        public string Adminpassword { get; set; } = "Admin";
        public Admin(string username, string password) : base(username, password)
        {
            Adminusername = username;
            Adminpassword = password;
        }
    }
}
