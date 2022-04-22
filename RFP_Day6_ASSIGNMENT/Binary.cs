using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day6_ASSIGNMENT
{
    internal class Binary
    {
        public static void toBinary(int decimalNumber)

        {
            // initialize variable
            int binaryNumber = 0, count = 0, digit;
            Console.WriteLine($"Binary equivalent of {decimalNumber} is ");
            while (decimalNumber >= 2)
            {
                digit = decimalNumber % 2;
                decimalNumber /= 2;
                binaryNumber += digit * Convert.ToInt32(Math.Pow(10, count));
                count++;
            }

            binaryNumber += decimalNumber * Convert.ToInt32(Math.Pow(10, count));
            Console.Write($" {binaryNumber}\n");


        }
    }
}
