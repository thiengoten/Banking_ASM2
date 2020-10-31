using System;
using System.Collections.Generic;
using System.Text;


namespace ASM2
{
    class Bank
    {
        // Property
        public List<User> Users = new List<User>();
        User onlineUser;

        // Method
        public void AddNewUser(User user)
        {
            Users.Add(user);
        }
        public double AddDeposit()
        {
            if(isLogin(onlineUser)) {
                double money = Utility.GetMoney();
                onlineUser.Deposit += money;
                return onlineUser.Deposit;
            }
            Console.WriteLine("Please login to use this feature !!!");
            return -1;
        }
        public double Withdrawal()
        {
            if (isLogin(onlineUser))
            {
                double money = Utility.GetMoney();
                onlineUser.Deposit -= money;
                return onlineUser.Deposit;
            }
            Console.WriteLine("Please login to use this feature !!!");
            return -1;
        }

        public void DisplayUsers()
        {
            foreach (var user in Users)
            {
                Console.WriteLine("username: {0}, password: {1}", user.Name, user.Password);
            }
        }

        public User Login() {
            string username = Utility.GetUsername();
            string password = Utility.GetPassword();

            foreach (var user in Users)
            {
                if (user.Name == username && user.Password == password)
                {
                    onlineUser = user;
                    Console.WriteLine("Login successfully !!!");
                    return user;
                }
            }
            Console.WriteLine("Username or password is invalid!!!");
            return null;
        }

        public static bool isLogin(User onlineUser)
        {
            if (onlineUser == null)
            {
                
                return false;
            }
            return true;
        }

        public User Logout()
        {
            onlineUser = null;
            return onlineUser;
        }
    }
}
