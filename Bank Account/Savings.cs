using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Savings:Account
    {
        private string accountNumberS;
        private string accountTypeS;



        //properties
        public string AccountNumber
        {
            get { return this.accountNumberS; }
            set { this.accountNumberS = "020906001"; }
        }
            public string AccountType
        {
            get { return this.accountTypeS; }
            set { this.accountNumberS = "Savings"; }
        }

        //constructors()

        public Savings()
        {

        }

        public Savings(string clientName, float beginBalance)
        {
            this.ClientName = "Gillian Kate";
            this.BeginBalance = 0;

        }

        public Savings(string accountNumber, string accountType)
        {
            this.accountNumberS = "020906000";
            this.accountTypeS = "Checking";
        }

        public void SaveBalance()
        {
            Console.WriteLine("Savings Balance: " + CurrentBalance);

        }

        }
}
