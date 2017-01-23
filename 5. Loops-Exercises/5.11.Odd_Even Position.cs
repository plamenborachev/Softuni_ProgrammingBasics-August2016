using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._11.Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double oddSum = 0.0;
            double oddMin = Double.MaxValue;
            double oddMax = Double.MinValue;

            double evenSum = 0.0;
            double evenMin = Double.MaxValue;
            double evenMax = Double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    oddSum += num;

                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                }
                else
                {
                    evenSum += num;

                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }
            }
            Console.WriteLine("OddSum={0},", oddSum);
            if (oddMin != Double.MaxValue)
            {
                Console.WriteLine("OddMin={0},", oddMin);
            }
            else
            {
                Console.WriteLine("OddMin=No,");        
            }
            if (oddMax != Double.MinValue)
            {
                Console.WriteLine("OddMax={0},", oddMax);
            }
            else
            {
                Console.WriteLine("OddMax=No,");
            }
            Console.WriteLine("EvenSum={0},", evenSum);
            if (evenMin != Double.MaxValue)
            {
                Console.WriteLine("EvenMin={0},", evenMin);
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
            }
            if (evenMax != Double.MinValue)
            {
                Console.WriteLine("EvenMax={0}", evenMax);
            }
            else
            {
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
