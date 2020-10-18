using System;
using System.Collections.Generic;
using System.Text;

namespace ASM2
{
    class User
    {
        public string Name;
        public string Password;
        public double Deposit = 0;

        public User() { }
        public User(string name, string password, double deposit)
        {
            Name        = name;
            Password    = password;
            Deposit     = deposit;
        }

        public double AddDeposit(double money)
        {
            return Deposit += money;
        }

        public void DisplayAccountBalance()
        {
            Console.WriteLine("So du cua ban la: {0}", Deposit);
        }
    }
}
