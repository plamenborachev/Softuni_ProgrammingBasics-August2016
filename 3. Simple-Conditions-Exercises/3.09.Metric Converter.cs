using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._09.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inMetric = Console.ReadLine();
            string outMetric = Console.ReadLine();

            if (inMetric == "mm")
            {
                number /= 1000; 
            }
            else if (inMetric == "cm")
            {
                number /= 100;
            }
            else if (inMetric == "mi")
            {
                number /= 0.000621371192;
            }
            else if (inMetric == "in")
            {
                number /= 39.3700787;
            }
            else if (inMetric == "km")
            {
                number /= 0.001;
            }
            else if (inMetric == "ft")
            {
                number /= 3.2808399;
            }
            else if (inMetric == "yd")
            {
                number /= 1.0936133;
            }

            if (outMetric == "mm")
            {
                number *= 1000;
            }
            else if (outMetric == "cm")
            {
                number *= 100;
            }
            else if (outMetric == "mi")
            {
                number *= 0.000621371192;
            }
            else if (outMetric == "in")
            {
                number *= 39.3700787;
            }
            else if (outMetric == "km")
            {
                number *= 0.001;
            }
            else if (outMetric == "ft")
            {
                number *= 3.2808399;
            }
            else if (outMetric == "yd")
            {
                number *= 1.0936133;
            }

            Console.WriteLine("{0} {1}", number, outMetric);
        }
    }
}
