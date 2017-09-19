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
            int PrimeCounter = 0;
            Boolean primeNum = true;
            for(int i = 0; PrimeCounter <= 1000; i++)
            {
                primeNum = true;
               if(i == 2  || i == 3 || i== 5 || i == 7)
                {
                    PrimeCounter++;
                    Console.WriteLine(i);
                }

                if ( i % 2 == 0)
                {
                    primeNum = false;
                }

                if ( i % 3 == 0)
                {
                    primeNum = false;
                }

                if ( i % 5 == 0)
                {
                    primeNum = false;
                }

                if (i % 7 == 0)
                {
                    primeNum = false;
                }

                if (primeNum == true)
                {
                    Console.WriteLine(PrimeCounter +"     " +i);
                    PrimeCounter++;
                }

               
            }


            
            Console.WriteLine("Done.");
        }
    }
}
