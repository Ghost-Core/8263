
/*******************************************************************/
/**                                                               **/
/**                                                               **/
/**    Student Name                :  Amin Ahmadi                 **/
/**    EMail Address               :  ahma0160@algonquinlive.com  **/
/**    Student Number              :  040993411                   **/
/**    Course Number               :  CST 8253                    **/
/**    Lab Section Number          :  011                         **/
/**    Professor Name              :  Wei Gong                    **/
/**    Assignment Name/Number      :  Lab 4                       **/
/**    Optional Comments           :                              **/
/**                                                               **/
/**                                                               **/
/*******************************************************************/






using System;
using System.Collections.Generic;

namespace Lab4
{
    class Bank
    {
        static void Main(string[] args)
        {
            List<Account> AccountList = new List<Account>();

            Console.Write("Enter the number of the months to deposit:");
            int numberOfMonths = int.Parse(Console.ReadLine());

            bool startAgain = true;
            while (startAgain)
            {
                Console.Write("Enter the custmer's name:");
                string name = Console.ReadLine();
                if (name == "")
                {
                    startAgain = false;
                }
                else
                {
                    Console.Write("Enter {0}'s Initial Deposit Amount (minimum $1000.00): ", name);
                    double initialDeposit = Double.Parse(Console.ReadLine());

                    Console.Write("Enter {0}'s Monthly Deposit Amount (minimum $50.00): ", name);
                    double monthlyDeposit = Double.Parse(Console.ReadLine());

                    Account anAccount = new Account(name, initialDeposit);

                    for (int i = 0; i < numberOfMonths; i++)
                    { 
                        anAccount.Withdraw(Account.MonthlyFee);
                        anAccount.Balance = anAccount.Balance + anAccount.Balance * Account.MonthlyInterestRate;
                        anAccount.Deposit(monthlyDeposit);
                    }
                    AccountList.Add(anAccount);
                }
            }
            foreach (var account in AccountList)
            {
                Console.Write("\nAfter {0} month, {1}'s account (#{2}), has a balance of: ${3}", numberOfMonths, account.OwnerName, account.AccountNumber, String.Format("{0:n}", account.Balance));
            }
            Console.Write("\n\nPress Enter to complete");
            Console.ReadLine();
        }
    }
}
