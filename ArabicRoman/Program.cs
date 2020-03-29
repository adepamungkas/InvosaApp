using System;
using System.Collections.Generic;

namespace ArabicRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** PROGRAM TRANSFORM ARABIC NUMBER TO ROMAN NUMBER ***************:");
            Console.WriteLine("Enter Arabic Number:");
            int arabicNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Roman Number is:  {0}",ArabicToRoman(arabicNumber));
        }

        //Transform Arabic System Number to Roman System Nmmber
        public static string ArabicToRoman(int arabicNumber)
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

            string result = "";

            foreach (var pair in pairNumber)
            {
                while (arabicNumber >= pair.Value)
                {
                    arabicNumber -= pair.Value;
                    result += pair.Key;
                }
            }
            return result;
        }
    }
}
