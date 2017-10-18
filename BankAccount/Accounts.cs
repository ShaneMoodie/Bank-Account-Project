using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Accounts: Client
    {
        //Fields
        protected string acctType;
        protected int acctNum;
        protected double startBalance;
        protected double currentBalance;
        protected double depositAmount;
        protected double withdrawAmount;

        //Properties
        public string AcctType
        {
            get { return this.acctType; }
            set { this.acctType = value; }
        }
        public int AcctNum
        {
            get { return this.acctNum; }
            set { this.acctNum = value; }
        }
        public double StartBalance
        {
            get { return startBalance; }
            set { startBalance = value; }
        }
        public double CurrentBalance
        {
            get { return this.currentBalance; }
            set { this.currentBalance = value; }
        }
        public double DepositAmount
        {
            get { return this.depositAmount; }
            set { this.depositAmount = value; }
        }
        public double WithdrawAmount
        {
            get { return this.withdrawAmount; }
            set { this.withdrawAmount = value; }
        }

        //Constructors
        public Accounts()
        {

        }
        public Accounts(string acctType, int acctNum, double startBalance)
        {
            this.acctType = acctType;
            this.acctNum = acctNum;
            this.startBalance = startBalance;
        }

        //Methods
        public virtual void AccountInfo()
        {

        }
        public abstract void AcctDeposit();
        public abstract void AcctWithdraw();
        
    }
}
