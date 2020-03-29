using System;

namespace BankInterestLooping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* PROGRAM CALCULATE BANK INTEREST WITH LOOPING  ********************:");
            Console.WriteLine("Enter total months :");
            int numberMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your balance Rp :");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your Balance now is Rp: {0}", CalculateBankInterest(numberMonth, balance));

            Console.ReadKey();
        }

        public static double CalculateBankInterest(int numberMonth, double balance)
        {
            if (numberMonth < 0 || numberMonth == 0)
            {
                return balance;
            }else
            {
                while(numberMonth > 0)
                {
                    double rate = 0.01;
                    balance += balance * rate;
                    numberMonth--;
                }

                return balance;

            }

        }

    }
}
