using System;
using WPFBank.UserClasses;

namespace WPFBank.Classes
{
    public class Client : User
    {

        public string _ClientUsername { get; set; }
        public string _ClientPassword { get; set; }
        public decimal _SalaryBalance { get; set; }
        public decimal _SavingsBalance { get; set; }

        private int _AccountNumber = Guid.NewGuid().GetHashCode();


        public Client(string clientusername, string clientpassword, decimal salaryBalance, decimal savingsBalance) : base(clientusername, clientpassword)
        {
            _ClientUsername = clientusername;
            _ClientPassword = clientpassword;
            _SalaryBalance = salaryBalance;
            _SavingsBalance = savingsBalance;
        }
        public int GetHashCode()
        {
            return _AccountNumber;
        }


    }
}
