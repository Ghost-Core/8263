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


namespace Lab4
{
    class Account
    {
        //Properties
        public int AccountNumber;
        public string OwnerName;
        public double Balance;
        public double MonthlyDepositAmount;

        //Static Properties
        public static double MonthlyFee = 4.0;
        public static double MonthlyInterestRate = 0.0025;
        public static double MinimumInitialBalance = 1000;
        public static double MinimumMonthDeposit = 50;

        //constructor
        public Account(string name, double initialDeposit)
        {
            OwnerName = name;
            Balance = initialDeposit;

        //Random Account Number Generator From 90000 to 99999
            Random rand = new Random();
            AccountNumber = rand.Next(90000, 99999);
        }

        //Deposit Method
        public void Deposit(double depositAmount)
        {
            Balance += depositAmount;
        }

        //Withdraw Method
        public void Withdraw(double withdrawAmount)
        {
            Balance -= withdrawAmount;
        }












    }



}
