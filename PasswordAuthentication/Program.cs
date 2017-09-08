using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordAuthentication
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = "root";
            var password = "letmein";

            
            int correct = 0;
            int wrong = 0;
            for (int tries = 0; tries < 3 || correct == 1;tries++)
            {
                Console.Write("Input a username : ");
                var inputName = Console.ReadLine();
                Console.Write("Input a Password : " );
                var inputPass = Console.ReadLine();

                if (username == inputName && inputPass == password)
                {
                    correct = 1;
                    Console.WriteLine("Username and Password authenticated .. you may proceed");
                    break;
                }
                else
                {
                    
                    wrong++;
         
                }
                if (tries == 2)
                {
                    Console.WriteLine("Too many incorrect login attempts!  Try again later!");
                    break;

                }
            }
            
                
            

        }
    }
}
