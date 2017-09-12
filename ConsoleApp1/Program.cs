using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 3rd number: ");
            int third = Convert.ToInt32(Console.ReadLine());

             

            if (first > second && first > third)
            {
                Console.WriteLine("The 1st Number is The greatest among three");
            }
            else if(second > first && second > third)
            {
                Console.WriteLine("The 2nd Number is The greatest among three");
            }
            else
            {
                Console.WriteLine("The 3rd Number is The greatest among three");
            }

        }
    }
}
