using System;
using System.Collections.Generic;

namespace Transform
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** PROGRAM ENCODING CHARACTERS AND DECODING CHARACTERS ***************:");
            Console.WriteLine("Choose Menu [1].Encoding  or [2].Decoding: ");
            int menu = Convert.ToInt32(Console.ReadLine());

            while (!(menu == 1) && !(menu == 2))
            {
                Console.WriteLine("Please choose menu [1].Encoding or [2].Decoding !");
                menu = Convert.ToInt32(Console.ReadLine());
               
            }

            if (menu == 1)
            {
                Console.WriteLine("Enter the words you want to encode: ");
                string words = Console.ReadLine();
                Console.WriteLine("Result Encoding is: {0} ",Encode(words));
            }
            else if (menu == 2)
            {
                Console.WriteLine("Enter the words you want to decode: ");
                string words = Console.ReadLine();
                Console.WriteLine("Result Decoding is: {0} ",Decode(words));
            }

        }

        //Ecoding character
        private static string Encode(string words)
        {
            string wordsTarget = words.ToUpper();

            Dictionary<Char, Char> charSchema = new Dictionary<Char, Char>();
            charSchema.Add('@', 'P');
            charSchema.Add('A', 'Q');
            charSchema.Add('B', 'R');
            charSchema.Add('C', 'S');
            charSchema.Add('D', 'T');
            charSchema.Add('E', 'U');
            charSchema.Add('F', 'V');
            charSchema.Add('G', 'W');
            charSchema.Add('H', 'X');
            charSchema.Add('I', 'Y');
            charSchema.Add('J', 'Z');
            charSchema.Add('K', '[');
            charSchema.Add('L', '\\');
            charSchema.Add('M', ']');
            charSchema.Add('N', '^');
            charSchema.Add('O', '_');
            charSchema.Add('P', '@');
            charSchema.Add('Q', 'A');
            charSchema.Add('R', 'B');
            charSchema.Add('S', 'C');
            charSchema.Add('T', 'D');
            charSchema.Add('U', 'E');
            charSchema.Add('V', 'F');
            charSchema.Add('W', 'G');
            charSchema.Add('X', 'H');
            charSchema.Add('Y', 'I');
            charSchema.Add('Z', 'J');
            charSchema.Add('[', 'K');
            charSchema.Add('\\', 'L');
            charSchema.Add(']', 'M');
            charSchema.Add('^', 'N');
            charSchema.Add('_', 'O');

            string result = "";
            foreach (char c in wordsTarget)
            {

                if (charSchema.ContainsKey(c))
                {
                    result += charSchema[c];
                }
            }

            return result;
        }

        //decoding character
        private static string Decode(string words)
        {
            string wordsTarget = words.ToUpper();

            Dictionary<Char, Char> charSchema = new Dictionary<Char, Char>();
            charSchema.Add('P', '@');
            charSchema.Add('Q', 'A');
            charSchema.Add('R', 'B');
            charSchema.Add('S', 'C');
            charSchema.Add('T', 'D');
            charSchema.Add('U', 'E');
            charSchema.Add('V', 'F');
            charSchema.Add('W', 'G');
            charSchema.Add('X', 'H');
            charSchema.Add('Y', 'I');
            charSchema.Add('Z', 'J');
            charSchema.Add('[', 'K');
            charSchema.Add('\\', 'L');
            charSchema.Add(']', 'M');
            charSchema.Add('^', 'N');
            charSchema.Add('_', 'O');
            charSchema.Add('@', 'P');
            charSchema.Add('A', 'Q');
            charSchema.Add('B', 'R');
            charSchema.Add('C', 'S');
            charSchema.Add('D', 'T');
            charSchema.Add('E', 'U');
            charSchema.Add('F', 'V');
            charSchema.Add('G', 'W');
            charSchema.Add('H', 'X');
            charSchema.Add('I', 'Y');
            charSchema.Add('J', 'Z');
            charSchema.Add('K', '[');
            charSchema.Add('L', '\\');
            charSchema.Add('M', ']');
            charSchema.Add('N', '^');
            charSchema.Add('O', '_');

            string result = "";
            foreach (char c in wordsTarget)
            {

                if (charSchema.ContainsKey(c))
                {
                    result += charSchema[c];
                }
            }

            return result;
        }
    }
}












