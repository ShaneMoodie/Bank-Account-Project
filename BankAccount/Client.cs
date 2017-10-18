using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        //Fields
        private string clientNum;
        private string clientName;
        private string clientAddress;
        protected int acctNumCheck;
        protected int acctNumSave;

        //Properties
        public string ClientName
        {
            get { return ClientName; }
            set { clientName = value; }
        }
        public string ClientAdd
        {
            get { return clientAddress; }
            set { clientAddress = value; }
        }
        public string ClientNum
        {
            get { return clientNum; }
            set { clientNum = value; }
        }
        protected int AcctNumCheck
        {
            get { return acctNumCheck; }
            set { acctNumCheck = value; }
        }
        protected int AcctNumSave
        {
            get { return acctNumSave; }
            set { acctNumSave = value; }
        }

        //Constructors
        public Client()
        {

        }
        public Client(string clientName, string clientAddress, string clientNum, int acctNumCheck, int acctNumSave)
        {
            this.clientName = clientName;
            this.clientAddress = clientAddress;
            this.clientNum = clientNum;
            this.acctNumCheck = acctNumCheck;
            this.acctNumSave = acctNumSave;
        }

        //Methods
        public void ClientInfo()
        {
            Console.WriteLine("************+++++++++++++++++++++++++");
            Console.WriteLine("Client Name: " + clientName + "\n");
            Console.WriteLine("Client Adress: " + clientAddress + "\n");
            Console.WriteLine("Client Phone Number: " + clientNum +"\n");
            Console.WriteLine("Press ENTER to continue.");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.WriteLine("*************************************");
        }
    }
}
