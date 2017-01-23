using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._09.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degreesCelsius = double.Parse(Console.ReadLine());

            double degreesFahrenheit = degreesCelsius * 1.8 + 32;

            Console.WriteLine(Math.Round(degreesFahrenheit, 2));
        }
    }
}
