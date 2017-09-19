using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i > -1; )
            {


                Console.Write("Enter a phrase: ");
                var inp = Console.ReadLine();

                var input = inp.ToLower();

                input = input.Replace(" ", "");
                input = input.Replace("!", "");
                input = input.Replace(".", "");
                input = input.Replace(",", "");
                input = input.Replace(";", "");
                input = input.Replace(":", "");
                input = input.Replace("?", "");

                char[] reversed = input.ToCharArray();
                Array.Reverse(reversed);
                String rev = new String(reversed);

                if (rev == input)
                {
                    Console.WriteLine("\"" + inp + "\" is a palindrome.");
                }
                else
                {
                    Console.WriteLine("\"" + inp + "\" is not a palindrome.");
                }
            }


        }
    }
}
