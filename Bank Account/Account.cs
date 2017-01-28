using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Account
    {
        //fields
        private string clientName;
        private string summary;

        private float deposit;
        private float withdraw;

        //properties
        public string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = "Gillian Kate"; }
        }

        public float Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }

        public float Withdraw
        {
            get { return this.withdraw; }
            set { this.withdraw = value; }
        }

        public string Summary
        {
            get { return this.summary; }
            set { this.summary = value; }
        }

        //methods

        public void Deposit();
      
        public void Withdraw();

        public void Summary();

           
        








}
}
