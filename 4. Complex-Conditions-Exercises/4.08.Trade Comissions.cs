using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double salesVolume = double.Parse(Console.ReadLine());
            double comissionRate = 0.0;

            if (city == "Sofia")
            {
                if (0 <= salesVolume && salesVolume <= 500)
                {
                    comissionRate = 0.05;
                }
                else if (500 < salesVolume && salesVolume <= 1000)
                {
                    comissionRate = 0.07;
                }
                else if (1000 < salesVolume && salesVolume <= 10000)
                {
                    comissionRate = 0.08;
                }
                else if (10000 < salesVolume)
                {
                    comissionRate = 0.12;
                }
            }
            else if (city == "Varna")
            {
                if (0 <= salesVolume && salesVolume <= 500)
                {
                    comissionRate = 0.045;
                }
                else if (500 < salesVolume && salesVolume <= 1000)
                {
                    comissionRate = 0.075;
                }
                else if (1000 < salesVolume && salesVolume <= 10000)
                {
                    comissionRate = 0.10;
                }
                else if (10000 < salesVolume)
                {
                    comissionRate = 0.13;
                }
            }
            else if (city == "Plovdiv")
            {
                if (0 <= salesVolume && salesVolume <= 500)
                {
                    comissionRate = 0.055;
                }
                else if (500 < salesVolume && salesVolume <= 1000)
                {
                    comissionRate = 0.08;
                }
                else if (1000 < salesVolume && salesVolume <= 10000)
                {
                    comissionRate = 0.12;
                }
                else if (10000 < salesVolume)
                {
                    comissionRate = 0.145;
                }
            }

            if (comissionRate != 0)
            {
                Console.WriteLine("{0:f2}", salesVolume * comissionRate);
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
