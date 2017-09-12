using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an grade: ");
            var input = Console.ReadLine();

            if (input == "a")
            {
                Console.WriteLine("You have Chosen Average.");
            }
            else if(input == "e")
            {
                Console.WriteLine("You have Chosen Excellent.");
            }
            else if( input == "v")
            {
                Console.WriteLine("You have Chosen Very good.");
            }
            else if( input == "f")
            {
                Console.WriteLine("You have Chosen fail.");
            }
            else
            {
                Console.WriteLine("You have Chosen nothing you lose good day sir.");
            }

        }
    }
}
