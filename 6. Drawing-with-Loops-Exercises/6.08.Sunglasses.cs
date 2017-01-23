using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._08.Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}", new string('*', n * 2), new string(' ', n), new string('*', n * 2));

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*{0}*", new string('/', n * 2 - 2));

                if (i == ((n - 1) / 2) - 1)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }

                Console.WriteLine("*{0}*", new string('/', n * 2 - 2));
            }

            Console.WriteLine("{0}{1}{2}", new string('*', n * 2), new string(' ', n), new string('*', n * 2));
        }
    }
}
