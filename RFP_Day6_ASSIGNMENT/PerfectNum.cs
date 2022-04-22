using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day6_ASSIGNMENT
{
    internal class PerfectNum
    {

        public void perfectNumMethod(int Factor, int Num)
        {
            for (int i = 1; i < Num; i++)
            {
                if (Num % i == 0)
                {
                    Factor = Factor + i;

                }
            }
            if (Factor == Num)
            {
                Console.WriteLine(Num + " is a PerfectNumber");
            }
            else
            {
                Console.WriteLine(Num + " is not a PerfectNumber");
            }
        }
    }
}
