using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    abstract class Account
    {
        //fields
         private string clientName;

        //properties
        public string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = "Gillian Kate"; }
        }

        public abstract void Deposit();
      
        public abstract void Withdraw();
           
        








}
}
