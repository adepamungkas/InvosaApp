using System;
using System.Collections.Generic;
using System.Linq;

namespace multilevel_discount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* PROGRAM CALCULATE MULTILEVEL DISCOUNT  ********************:");

            Console.WriteLine("Enter Price Rp:");
            int price = Convert.ToInt32(Console.ReadLine());
            while (price <= 0)
            {
                Console.WriteLine("Price not allowed less than or equal zero:");
                Console.WriteLine("Enter Price Rp:");
                price = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter level discount :");
            int level = Convert.ToInt32(Console.ReadLine());
            List<int> listDiscount = new List<int>();

            while (level > 0)
            {
                Console.WriteLine("Enter your discount :");
                int discount = Convert.ToInt32(Console.ReadLine());
                listDiscount.Add(discount);
                level--;
            }

            Console.WriteLine("Result Price after discount is Rp: {0}", CalculateMultilevelDiscount(price, listDiscount));
            
           
        }

        //Calculate Multilevel Discount
        private static double CalculateMultilevelDiscount(double price , List<int> listDiscount)
        {

            int length = listDiscount.Count();
            double percentage;
            for (int i =0; i< length; i++)
            {
                double discount = listDiscount[i];
                percentage = (discount / 100);
                price -= price * percentage;
            }
            return price;
        }
    }
}
