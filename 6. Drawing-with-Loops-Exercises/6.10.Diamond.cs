using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._10.Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', n / 2 - 1 - i), new string('-', i * 2), new string('-', n / 2 - 1 - i));
                }
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', i + 1), new string('-', n - i * 2 -4), new string('-', i + 1));
                }
            }
            else
            {
                Console.WriteLine("{0}*{1}", new string('-', n / 2), new string('-', n / 2));
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', n / 2 - i - 1), new string('-', i * 2 + 1), new string('-', n / 2 - i - 1));
                }
                for (int i = 0; i < n / 2 - 1; i++)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('-', i + 1), new string('-', n - i * 2 - 4), new string('-', i + 1));
                }
                if (n > 1)
                {
                    Console.WriteLine("{0}*{1}", new string('-', n / 2), new string('-', n / 2));
                }
            }
        }
    }
}
