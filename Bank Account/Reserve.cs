using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Reserve:Account
    {
        private string accountNumberR;
        private string accountTypeR;



        //properties
        public string AccountNumber
        {
            get { return this.accountNumberR; }
            set { this.accountNumberR = "020906002"; }
        }

        public string AccountType
        {
            get { return this.accountTypeR; }
            set { this.accountNumberR = "Reserve"; }
        }

        //constructors()

        public Reserve()
        {

        }

        public Reserve(string clientName, float beginBalance)
        {
            this.ClientName = "Gillian Kate";
            this.BeginBalance = 0;

        }

        public Reserve(string accountNumber, string accountType)
        {
            this.accountNumberR = "020906000";
            this.accountTypeR = "Checking";
        }

    }
}
