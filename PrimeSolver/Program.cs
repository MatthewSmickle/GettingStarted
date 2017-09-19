using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transformers . . Roll out!");
            int PrimeCounter = 3;
            Boolean primeNum = true;
            for(int i = 0; i <= 1000; i++)
            {
               if(i == 2|| i == 3 || i== 5)
                {
                    Console.WriteLine(i);
                }
               else if( i % 2 == 0)
                {
                    primeNum = false;
                }
               else if ( i % 3 == 0)
                {
                    primeNum = false;
                }
               else if( i % 5 == 0)
                {
                    primeNum = false;
                }

               if(primeNum == true)
                {
                    Console.WriteLine(i);
                    PrimeCounter++;
                }
            }


            
            Console.WriteLine("Done.");
        }
    }
}
