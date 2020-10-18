using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace ASM2
{
    class Program
    {
        public static string getPassword()
        {
            Console.Write("Enter your password please: ");
            StringBuilder passwordBuilder = new StringBuilder();
            bool continueReading = true;
            char newLineChar = '\r';
            while (continueReading)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                char passwordChar = consoleKeyInfo.KeyChar;
                if(consoleKeyInfo.Key == ConsoleKey.Enter)
                {
                    continueReading = false;
                    break;
                }
                Console.Write("*");
                if (passwordChar == newLineChar)
                {
                    continueReading = false;
                }
                else
                {
                    passwordBuilder.Append(passwordChar.ToString());
                }
            }
            Console.Write('\n');
            return passwordBuilder.ToString();
        }
        static void Main(string[] args)
        {
            int userChoice = 1;
            bool isLogin = false;
            List<User> users = new List<User>();
            User onlineUser = new User();

            while (userChoice != 0)
            {
                Console.WriteLine("_____________________________");
                Console.WriteLine("||Nhap 1 : Tao tai khoan   ||");
                Console.WriteLine("||Nhap 2 : Hien thi cac tai khoan ||");
                Console.WriteLine("||Nhap 3 : Dang nhap       ||");
                Console.WriteLine("||Nhap 4 : Nap tien        || ");
                Console.WriteLine("||Nhap 5 : Kiem tra so du        ||");
                Console.WriteLine("||Nhap 6 : Dang xuat ||");
                Console.WriteLine("||Nhap 0 : Exit       ||");
                Console.WriteLine("-----------------------------");
                userChoice = int.Parse(Console.ReadLine());
                

                switch (userChoice)
                {
                  
                    case 1:
                        Console.WriteLine("Enter username: ");
                        string username = Console.ReadLine();
                        string password = getPassword();
                        
                        User user = new User(username, password, 0);
                        users.Add(user);
                        break;
                    case 2:
                        foreach(var account in users)
                        {
                            Console.WriteLine("username: {0}, password: {1}", account.Name, account.Password);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter username: ");
                        string name = Console.ReadLine();
                        string pass = getPassword();

                        foreach(var curUser in users)
                        {
                            if(curUser.Name == name && curUser.Password == pass)
                            {
                                isLogin = true;
                                onlineUser = curUser;
                                Console.WriteLine("Login successfully !!!");
                                break;
                            }
                            Console.WriteLine("Login failed !!! Please try again");
                        }
                        break;
                    case 4:
                        if(!isLogin)
                        {
                            Console.WriteLine("Please login to use this feature !!!");
                            break;
                        }
                        Console.WriteLine("please enter your deposit: ");
                        double money = double.Parse(Console.ReadLine());

                        onlineUser.AddDeposit(money);
                        break;
                    case 5:
                        if (!isLogin)
                        {
                            Console.WriteLine("Please login to use this feature !!!");
                            break;
                        }
                        onlineUser.DisplayAccountBalance();
                        break;
                    case 6:
                        isLogin = false;
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
