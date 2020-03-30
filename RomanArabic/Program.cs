using System;
using System.Collections.Generic;

namespace RomanArabic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** PROGRAM TRANSFORM ROMAN NUMBER TO ARABIC NUMBER ***************:");
            Console.WriteLine("Enter Roman Number:");
            string romanNumber = Console.ReadLine();
            Console.WriteLine("Arabic Number is:  {0}", RomanToArabic(romanNumber).ToString());
        }

        public static int RomanToArabic(string romanNumber)
        {
            Dictionary<string, int> pairNumber = new Dictionary<string, int>();
            pairNumber.Add("M", 1000);
            pairNumber.Add("CM", 900);
            pairNumber.Add("D", 500);
            pairNumber.Add("CD", 400);
            pairNumber.Add("C", 100);
            pairNumber.Add("XC", 90);
            pairNumber.Add("L", 50);
            pairNumber.Add("XL", 40);
            pairNumber.Add("X", 10);
            pairNumber.Add("IX", 9);
            pairNumber.Add("V", 5);
            pairNumber.Add("IV", 4);
            pairNumber.Add("I", 1);

            int result = 0;

            foreach (var pair in pairNumber)
            {
                while (romanNumber.IndexOf(pair.Key.ToString()) == 0)
                {
                    result += int.Parse(pair.Value.ToString());
                    romanNumber = romanNumber.Substring(pair.Key.ToString().Length);
                }
            }

            return result;
        }
    }
}
