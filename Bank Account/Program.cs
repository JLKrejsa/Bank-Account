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
                Account AccountInfo = new Account();
                Account DepositMoney = new Account();
                Account WithdrawMoney = new Account();
                Checking CheckBalance = new Checking();
                Savings SaveBalance = new Savings();
                Reserve ReserveBalance = new Reserve();

                //menu that works

                List<string> mainMenu = new List<string>();
                mainMenu.Add("\n");
                mainMenu.Add("Menu");
                mainMenu.Add("Enter 1 to view Account Info");
                mainMenu.Add("Enter 2 for Checking Account Balance");
                mainMenu.Add("Enter 3 for Reserve Account Balance");
                mainMenu.Add("Enter 4 for Savings Account Balance");
                mainMenu.Add("Enter 5 to Make a Deposit");
                mainMenu.Add("Enter 6 to Withdraw from an Account");
                mainMenu.Add("Enter 7 to Exit");

                mainMenu.ForEach(Console.WriteLine);

                int menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine(AccountInfo);
                        break;

                    //checking acct balance
                    case 2:
                        Console.WriteLine(CheckBalance);
                        
                        break;

                    case 3:
                        Console.WriteLine(ReserveBalance);
                        break;

                    case 4:
                        Console.WriteLine(SaveBalance);
                        break;

                    //deposit
                    case 5:
                        Console.WriteLine(DepositMoney);
                        break;

                    //withdraw
                    case 6:
                        Console.WriteLine(WithdrawMoney);
                        break;
                    //exit
                    case 7:
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                    
                }








            }

            }
        }
    }
