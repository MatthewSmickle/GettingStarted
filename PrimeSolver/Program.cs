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
            int prime = 0;
            List<int> primes = new List<int>(new int[]{ 2, 3, 5 });
            for(int i = 6; PrimeCounter <= 1000; i++)
            {
                for (int c = 0; c < primes.Count; c++)
                {

                    if (i % primes[c] == 0)
                    {
                        prime++;
                    }

                }
                if(prime > 0)
                {
                    primes.Add(i);
                    Console.WriteLine(i);
                    PrimeCounter++;
                }
            }
            Console.WriteLine("Done.");
        }

    }
}
