using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day6_ASSIGNMENT
{
    internal class Util
    {
        public void TemperaturConversion(int Num4)
        {
            
            double c, f;

            switch (Num4)
            {
                case 0:
                    Console.WriteLine("Enter any Temperature value in celcius");
                    c = Convert.ToDouble(Console.ReadLine());
                    f = c * 9 / 5 + 32;
                    Console.WriteLine("Temperature in FAHRENHEIT " + f);
                    break;
                case 1:
                    Console.WriteLine("Enter any Temperature value in Fahrenheit");
                    f = Convert.ToDouble(Console.ReadLine());
                    c = (f - 32) * 5 / 9;
                    Console.WriteLine("Temperature in CELCIUS " + c);
                    break;

            }
        }
    }
}
