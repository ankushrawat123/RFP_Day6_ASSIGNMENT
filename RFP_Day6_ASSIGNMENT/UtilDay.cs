using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day6_ASSIGNMENT
{
    internal class UtilDay
    {
       public void dayOfWeek(int D ,int M, int Y)
        {
           int d1,m1,y1,x;
            
           
            y1 = Y - (14 - M) / 12;
            x = y1 + (y1/ 4) - y1 /100 + (y1 / 400);
            m1 = M + 12 * (14 - M)/12 - 2;
            d1 = (D + x + 31 *m1/ 12) % 7;
           
            Console.WriteLine(d1);
            switch (d1)
            {
                case 0:
                    Console.WriteLine("SUNDAY");
                    break;
                case 1:
                    Console.WriteLine("MONDAY");
                    break;
                case 2:
                    Console.WriteLine("TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("SATURDAY");
                    break;

            }
        }
        
    }
}
