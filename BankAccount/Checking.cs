using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankAccount
{
    class Checking: Accounts
    {
        //Constructors
        public Checking(string acctType, int acctNum, double startBalance)
        {
            this.acctType = acctType;
            this.acctNum = acctNum;
            this.currentBalance = startBalance;
        }
        //Methods
        //Checking Account Info
        public override void AccountInfo()
        {
            Console.WriteLine("************");
            Console.WriteLine(acctType + "\n");
            Console.WriteLine("Account Number: " + acctNum + "\n");
            Console.WriteLine("Your current balance is: " + currentBalance + "\n");
            Console.WriteLine("Press ENTER to continue.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.WriteLine("************");
        }
        //Deposit to Checking Account
        public override void AcctDeposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            depositAmount = double.Parse(Console.ReadLine());
            currentBalance = currentBalance + depositAmount;
            Console.WriteLine("Your deposit of $" + depositAmount + " has been accepted.");
            Console.WriteLine("Your new balance is $" + currentBalance + "\n");
            Console.WriteLine("Press ENTER to continue.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
        //Withdraw from Checking Account
        public override void AcctWithdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            withdrawAmount = double.Parse(Console.ReadLine());
            currentBalance = currentBalance - withdrawAmount;
            Console.WriteLine("You have withdrawn $" + withdrawAmount);
            Console.WriteLine("Your new balance is $" + currentBalance + "\n");
            Console.WriteLine("Press ENTER to continue.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
        
    }
}
