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

        
        public void DisplayAccountBalance(User onlineUser)
        {
            if (Bank.isLogin(onlineUser))
            {
                Console.WriteLine("So du cua ban la: {0}", onlineUser.Deposit);
                return;
            }
            Console.WriteLine("Please login to use this feature");
            return;
        }
    }
}
