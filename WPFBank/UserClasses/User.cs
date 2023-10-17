﻿namespace WPFBank.Classes
{
    public abstract class User
    {
        protected User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }
    }

}