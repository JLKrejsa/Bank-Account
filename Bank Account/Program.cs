using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bank of WCCI.");
            Console.WriteLine("How may we help you today?");

            while (true)
            {
                List<string> mainMenu = new List<string>();
                mainMenu.Add("\n");
                mainMenu.Add("Menu");
                mainMenu.Add("Enter 1 to");
                mainMenu.Add("Enter 2 for Checking Account Balance");
                mainMenu.Add("Enter 3 for Reserve Account Balance");
                mainMenu.Add("Enter 4 for Savings Account Balance");
                mainMenu.Add("Enter 5 to Make a Deposit");
                mainMenu.Add("Enter 6 to Withdraw from an Account");
                mainMenu.Add("Enter 7 to Exit");

                mainMenu.ForEach(Console.WriteLine);

                int menuResponse = int.Parse(Console.ReadLine());

                switch(menuResponse)
                {
                    case 1:

                }









            }










        }
    }
}
