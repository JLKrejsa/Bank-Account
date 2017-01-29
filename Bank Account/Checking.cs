using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Checking:Account
    {
        //fields
        private string accountNumberC;
        private string accountTypeC;

        

        //properties
        public string AccountNumber
            {
            get { return this.accountNumberC; }
            set { this.accountNumberC = "020906000"; }
            }

        public string AccountType
            {
            get { return this.accountTypeC; }
            set {this.accountTypeC = "Checking";}
            }

        //constructor(3)

        public Checking()
        {

        }

        public Checking(string clientName, float beginBalance)
        {
            this.ClientName = "Gillian Kate";
            this.BeginBalance = 0;
           
        }

        public Checking(string accountNumber, string accountType)
        {
            this.accountNumberC = "020906000";
            this.accountTypeC = "Checking";
        }

        //method
        public void CheckBalance()
        {
            Console.WriteLine("Checking Balance: " + CurrentBalance);
        }
       

        //end of class
        }
}
