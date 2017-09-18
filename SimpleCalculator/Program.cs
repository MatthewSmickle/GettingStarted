using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an expression: ");
            var Input = Console.ReadLine();

        
            String FirstNum = "";
            String SecondNum = "";
            if (Input.Substring(0,2).Contains(" "))
            {
                FirstNum = Input.Substring(0, 1);
                if(Input.Substring(Input.Length-2).Contains(" "))
                {
                    SecondNum = Input.Substring(Input.Length - 2);
                }
                else
                {
                     SecondNum = Input.Substring(Input.Length - 3);
                }
            }
            else
            {
                FirstNum = Input.Substring(0, 2);
                SecondNum = Input.Substring(Input.Length - 2);
            }

            int NewFirst = Convert.ToInt32(FirstNum);
            int NewSecond = Convert.ToInt32(SecondNum);

            

           if(Input.Contains("+"))
            {

                double result = (double)NewFirst + (double)NewSecond;
                Console.WriteLine("Result: "+ Input + " = "+result);
            }
            if (Input.Contains("*"))
            {
                double result = (double)NewFirst * (double)NewSecond;
                Console.WriteLine("Result: " + Input + " = " + result);
            }
            if (Input.Contains("-"))
            {
                double result = (double)NewFirst - (double)NewSecond;
                Console.WriteLine("Result: " + Input + " = " + result);
            }
            if (Input.Contains("/"))
            {
                double result = (double)NewFirst / (double)NewSecond;
                Console.WriteLine("Result: " + Input + " = " + result);
            }

        }
    }
}
