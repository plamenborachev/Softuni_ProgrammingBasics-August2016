using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._12.Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int n0 = 1;
            int n1 = 1;
            int n2 = n0 + n1;

            if (n == 0 || n == 1)
            {
                Console.WriteLine(n0);
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    n0 = n1;
                    n1 = n2;
                    n2 = n0 + n1;
                }
                Console.WriteLine(n2);
            }
            
        }
    }
}
