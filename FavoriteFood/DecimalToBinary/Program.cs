using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int Input = Convert.ToInt32(Console.ReadLine());

            int FirstDigit = 0;
            int SecondDigit = 0;
            int ThirdDigit = 0;
            int FourthDigit = 0;
            int FifthDigit = 0;
            int SixthDigit = 0;
            int SeventhDigit = 0;
            int EighthDigit = 0;

            for(int i = 0; i <= 8; i++)
            {
                if(Input >= 128)
                {
                    Input = Input - 128;
                    FirstDigit = 1;
                    
                }
                else if (Input >= 64)
                {
                    Input = Input - 64;
                    SecondDigit = 1;
                   
                }
                else if (Input >= 32)
                {
                    Input = Input - 32;
                    ThirdDigit = 1;
                    
                }
                else if (Input >= 16)
                {
                    Input = Input - 16;
                    FourthDigit = 1;
                   
                }
                else if (Input >= 8)
                {
                    Input = Input - 8;
                    FifthDigit = 1;
                    
                }
                else if (Input >= 4)
                {
                    Input = Input - 4;
                    SixthDigit = 1;
                    
                }
                else if (Input >= 2)
                {
                    Input = Input - 2;
                    SeventhDigit = 1;
                   
                }
                else if (Input >= 1)
                {
                    Input = Input - 1;
                    EighthDigit = 1;
                    
                }
            }
            Console.WriteLine(FirstDigit + "" + SecondDigit + "" + ThirdDigit + "" + FourthDigit + "" + FifthDigit + "" + SixthDigit + "" + SeventhDigit + "" + EighthDigit);
        }
    }
}
