using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace ASM2
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int userChoice = 1;
            Bank Bank = new Bank();
            User onlineUser = null;
            string username;
            string password;
            double money;
            while (userChoice != 0)
            {
                Console.WriteLine("_____________________________");
                Console.WriteLine("||Nhap 1 : Tao tai khoan   ||");
                Console.WriteLine("||Nhap 2 : Hien thi cac tai khoan ||");
                Console.WriteLine("||Nhap 3 : Dang nhap       ||");
                Console.WriteLine("||Nhap 4 : Nap tien        || ");
                Console.WriteLine("||Nhap 5 : Rut tien        ||");
                Console.WriteLine("||Nhap 6 : Kiem tra so du        ||");
                Console.WriteLine("||Nhap 7 : Dang xuat ||");
                Console.WriteLine("||Nhap 0 : Exit       ||");
                Console.WriteLine("-----------------------------");
                userChoice = int.Parse(Console.ReadLine());
                

                switch (userChoice)
                {
                  
                    case 1:
                        username = Utility.GetUsername();
                        password = Utility.GetPassword();
                        money = Utility.GetMoney();
                        
                        User user = new User(username, password, money);
                        Bank.AddNewUser(user);
                        break;
                    case 2:
                        Bank.DisplayUsers();
                        break;
                    case 3:
                        onlineUser = Bank.Login();
                        break;
                    case 4:
                        Bank.AddDeposit();
                        break;
                    case 5:
                        Bank.Withdrawal();
                        break;
                    case 6:
                        User curUser = new User();
                        curUser.DisplayAccountBalance(onlineUser);
                        break;
                    case 7:
                        onlineUser = Bank.Logout();
                        Console.WriteLine("Logout successfully !!!");
                        break;
                    default:
                        Console.WriteLine("Moi nhap lai!");
                        break;
                }
            }
        }
    }
}
