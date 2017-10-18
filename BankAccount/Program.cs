using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        public void MainMenu()
        {
            Console.WriteLine("Welcome to your virtual bank account! What can we do for you today?\n");
            Console.WriteLine("********************");
            Console.WriteLine("1.) View Client Info\n");
            Console.WriteLine("2.) View Account Balance\n");
            Console.WriteLine("3.) Deposit Funds\n");
            Console.WriteLine("4.) Withdraw Funds\n");
            Console.WriteLine("5.) Cancel Transaction and Exit");
            Console.WriteLine("********************");
            int menuNavigate = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            //Customer account creation
            Client shane = new Client("Shane Moodie", "1310 Carol Dr. Kent, Oh", "330-274-7957", 123456789, 98754321);
            Checking checking = new Checking("Checking Account", 12345789, 500.00);
            Savings savings = new Savings("Savings Account", 987654321, 2000.00, 200.00);
            string AB;
            int menuNavigate;

            ////Menu Navigation
            do
            {
                //App Main Menu
                Console.WriteLine("welcome to your virtual bank account! what can we do for you today?\n");
                Console.WriteLine("********************");
                Console.WriteLine("1.) view client info\n");
                Console.WriteLine("2.) view account balance\n");
                Console.WriteLine("3.) deposit funds\n");
                Console.WriteLine("4.) withdraw funds\n");
                Console.WriteLine("5.) cancel transaction and exit");
                Console.WriteLine("********************");
                menuNavigate = int.Parse(Console.ReadLine());

                if (menuNavigate == 1)
                {
                    shane.ClientInfo();
                }
                else if (menuNavigate == 2)
                {
                    Console.WriteLine("Please Select Account:\nA.) Checking Account Balance\nB.) Savings Account Balance");
                    AB = Console.ReadLine().ToUpper();
                    if (AB == "A")
                    {
                        checking.AccountInfo();
                    }
                    else if (AB == "B")
                    {
                        savings.AccountInfo();
                    }
                }
                else if (menuNavigate == 3)
                {
                    Console.WriteLine("Please select account you'd like to deposit to.\nA.) Checking Account\nB.)Savings Account");
                    AB = Console.ReadLine().ToUpper();
                    if (AB == "A")
                    {
                        checking.AcctDeposit();
                    }
                    else if (AB == "B")
                    {
                        savings.AcctDeposit();
                    }
                }
                else if (menuNavigate == 4)
                {
                    Console.WriteLine("Please select account you'd like to withdraw from.\nA.) Checking Account\nB.) Savings Account");
                    AB = Console.ReadLine().ToUpper();
                    if (AB == "A")
                    {
                        checking.AcctWithdraw();
                    }
                    else if (AB == "B")
                    {
                        savings.AcctWithdraw();
                    }
                }
                if (menuNavigate == 5)
                {
                    Environment.Exit(0);
                }
            }
            while (true);
            
        }
    }
}
