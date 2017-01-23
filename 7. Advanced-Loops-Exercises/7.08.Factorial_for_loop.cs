using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._08.Factorial
{
    class Factorial_for_loop
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num1 = 1;
            int num2 = 2;
            int factoriel = 1;

            for (int i = 1; i < n; i++)
            {
                factoriel = num1 * num2;
                num1 = factoriel;
                num2++;
            }
            Console.WriteLine(factoriel);
        }
    }
}
