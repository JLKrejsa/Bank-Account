using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Savings:Account
    {
        private string accountNumber;
        private string accountType;



        //properties
        public string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = "020906001"; }
        }
            public string AccountType
        {
            get { return this.accountType; }
            set { this.accountNumber = "Savings"; }
        }








    }
}
