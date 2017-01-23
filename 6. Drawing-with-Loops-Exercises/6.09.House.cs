using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._09.House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine("{0}{1}{2}", new string('-', n / 2 - i - 1), new string('*', i * 2 + 2), new string('-', n / 2 - i - 1));
                }
            }
            else
            {
                for (int i = 0; i < n / 2 + 1; i++)
                {
                    Console.WriteLine("{0}{1}{2}", new string('-', n / 2 - i), new string('*', i * 2 + 1), new string('-', n / 2 - i));
                }
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}
