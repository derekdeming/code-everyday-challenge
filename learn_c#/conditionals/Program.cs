using System;

namespace IfStatementExample
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyAmountInSavingsAccount = 600;
            decimal costOfBike = 1000; 
            bool canGetLoan = true;
            decimal maxLoanAmount = 500;

            if (moneyAmountInSavingsAccount >= costOfBike)
            {
                Console.WriteLine("I can buy the bike");
            }
            else if (canGetLoan && maxLoanAmount + moneyAmountInSavingsAccount >= costOfBike)
            {
                Console.WriteLine("I don't have enough in my savings account but i can get a loan");
            }
            else if (canGetLoan && moneyAmountInSavingsAccount + maxLoanAmount > costOfBike / 2) 
            {
                Console.WriteLine("I have over half the money to buy the bike");
            }
            else
            {
                Console.WriteLine("I don't have enough money to buy the bike");
            }

            Console.ReadKey();
        }
    }
}