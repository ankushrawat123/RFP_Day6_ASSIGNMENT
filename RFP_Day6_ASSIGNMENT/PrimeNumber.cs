using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day6_ASSIGNMENT
{
    internal class PrimeNumber
    {
        public void PrimeNunberMethod(int Num2,int Count)
        {
            
            Console.WriteLine("Prime factors of " + Num2);
            for (int i = 1; i <= Num2; i++)
            {
                if (Num2 % i == 0)
                {
                    Count++;
                    Console.WriteLine(i + " is a prime factor of "+Num2);
                }
               
            }
            if (Count == 2)
            {
                Console.WriteLine("\n {0} is a prime number ",Num2);
            }
            else
            {
                Console.WriteLine("\n {0} is not a prime number ", Num2);
            }
        }
    }
}
