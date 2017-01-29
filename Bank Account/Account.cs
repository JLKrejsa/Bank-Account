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

        private float depositAmount;
        private float withdrawAmount;
        private float beginBalance;
        private float currentBalance;

        

        //properties
        public string ClientName
        {
            get { return this.clientName; }
            set { this.clientName = "Gillian Kate"; }
        }

        public float Deposit
        {
            get { return this.depositAmount; }
            set { this.depositAmount = value; }
        }

        public float Withdraw
        {
            get { return this.withdrawAmount; }
            set { this.withdrawAmount = value; }
        }

        public string Summary
        {
            get { return this.summary; }
            set { this.summary = value; }
        }


        public float BeginBalance
        {
            get { return this.beginBalance; }
            set { this.beginBalance = 0; }
        }

        public float CurrentBalance
        {
            get { return this.currentBalance; }
            set { this.currentBalance = value; }
        }


        public Account(string clientName, string summary)
        {
            this.clientName = clientName;
            this.summary = summary;
        }

        //constructor
        public Account()
        {

        }

        //methods
        public void AccountInfo()
        {
            Console.WriteLine(clientName);
            Console.WriteLine(currentBalance);
        }

        

        public void DepositMoney()

        {
            Console.WriteLine("Enter amount for deposit: ");
            float depositValue = float.Parse(Console.ReadLine());
            this.currentBalance += depositValue;

        }
        
        
        public void WithdrawMoney()
        {
            Console.WriteLine("Enter amount to Withdraw: ");
            float withdrawValue = float.Parse(Console.ReadLine());
            this.currentBalance += withdrawValue;
        }    

        //float currentBalance = float.Parse(Console.ReadLine());
        public void SummaryView()
        {
            Console.WriteLine("Name" + ClientName);
            Console.WriteLine("Balance" + CurrentBalance);
        }
        public void Balance()
        {
            Console.WriteLine();
        }

           
        








}
}
