using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteFood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your favorite food? : ");
            var input = Console.ReadLine();
            if(input == "pizza")
            {
                Console.WriteLine("Great choice");
            }
            else
            {
                Console.WriteLine("Wrong!  That is a terrible choice and you should feel bad about yourself.   Your favorite should be pizza!");

            }
            
            
            Console.WriteLine(input);
         }
    }
}
