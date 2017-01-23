using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._03.Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int c = a % b;

            while (c != 0)
            {
                a = b;
                b = c;
                c = a % b;
            }
            Console.WriteLine(b);
        }
    }
}
