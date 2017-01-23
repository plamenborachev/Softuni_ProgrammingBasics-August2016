using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._06.Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = {0}", Math.PI * r * r);
            Console.WriteLine("Perimeter = {0}", 2 * Math.PI * r);
        }
    }
}
