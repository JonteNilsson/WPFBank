namespace WPFBank.UserClasses
{
    public abstract class User
    {
        public User(string username, string password)
        {
            _Username = username;
            _Password = password;
        }

        public string _Username { get; set; }
        public string _Password { get; set; }
    }
}
