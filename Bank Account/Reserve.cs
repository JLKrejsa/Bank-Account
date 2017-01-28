using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Reserve:Account
    {
        private string accountNumber;
        private string accountType;



        //properties
        public string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = "020906002"; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountNumber = "Reserve"; }
        }

    }
}
