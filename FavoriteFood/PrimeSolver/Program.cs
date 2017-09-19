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
            int notPrime = 0;
            for(int i = 0; i <= 1000; i++)
            {
                for(int num = 0; i == 1000; num++)
                {
                    for (int minus = num - 1; minus == 2; minus--)
                    {
                        if (num % minus == 0)
                        {
                            notPrime++;
                        }

                        if (notPrime == 0)
                        {
                            i++;
                            Console.WriteLine(i);

                        }
                    }
                }
            }


            
            Console.WriteLine("Done.");
        }
    }
}
