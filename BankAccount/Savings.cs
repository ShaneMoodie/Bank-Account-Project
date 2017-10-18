using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Savings: Accounts
    {
        //Fields
        public double minBalance = 200.00;

        //Constructors
        public Savings(string acctType, int acctNum, double startBalance, double minBalance)
        {
        this.acctType = acctType;
        this.acctNum = acctNum;
        this.currentBalance = startBalance;
        this.minBalance = minBalance;
        }

        //Properties

        //Methods
        //Savings Account Information
        public override void AccountInfo()
        {
            Console.WriteLine("************");
            Console.WriteLine(acctType + "\n");
            Console.WriteLine("Account Number: " + acctNum + "\n");
            Console.WriteLine("Your current balance is: " + currentBalance + "\n");
            Console.WriteLine("Your minimum balance is: " + minBalance + "\n");
            Console.WriteLine("Press ENTER to continue.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.WriteLine("************");
        }
        //Deposit to Savings Account
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
        //Withdraw from Savings Account
        public override void AcctWithdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            withdrawAmount = double.Parse(Console.ReadLine());
            currentBalance = currentBalance - withdrawAmount;
            if (currentBalance < 200)
            {
                currentBalance = currentBalance + withdrawAmount;
                Console.WriteLine("Your Savings Account must retain a balance of at least $200.00.\nPlease choose a lesser amount or cancel transaction.");
                Console.WriteLine("How much would you like to withdraw?");
                withdrawAmount = double.Parse(Console.ReadLine());
                currentBalance = currentBalance - withdrawAmount;
                Console.WriteLine("You have withdrawn $" + withdrawAmount);
                Console.WriteLine("Your new balance is $" + currentBalance);
            }
            else if (currentBalance > 200)
            {
                Console.WriteLine("You have withdrawn $" + withdrawAmount);
                Console.WriteLine("Your new balance is $" + currentBalance + "\n");
                Console.WriteLine("Press ENTER to continue.");
                while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            }
            
        }

    }
}
