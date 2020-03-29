using System;

namespace BankInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* PROGRAM CALCULATE BANK INTEREST WITH NO LOOPING KEYWORD********************:");
            Console.WriteLine("Enter total months :");
            int numberMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your balance Rp :");
            double balance = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Your Balance now is Rp: {0}", CalculateBankInterest(numberMonth, balance));
          
            Console.ReadKey();
        }

        public static double CalculateBankInterest(int i, double balance)
        {

        LabelDefault:
            if (i ==0 || i < 0)
            {
                Console.WriteLine("Your balance Rp: {0}", balance);
            };

        LabelCount: 
            if (i > 0)
            {
                double rate = 0.01;
                balance += balance * rate;

                i--;
                goto LabelCount;
            }
            return balance;

        }
       
        }
    

    
}
