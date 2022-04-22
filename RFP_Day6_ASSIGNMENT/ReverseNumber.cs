using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day6_ASSIGNMENT
{
    internal class ReverseNumber
    {
        public void Reverse(int Num3, int Rev)
        {
           
            int Value = Num3;
                while (Num3 != 0)
            {
                Rev = Rev * 10 + Num3 % 10;
                Num3 = Num3 / 10;
            }
            Console.WriteLine("Reverse of {0} is {1}", Value, Rev);
        }
    }
}
