using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Fox
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{2}", new string('*', i + 1), new string('-', n * 2 - i * 2 - 1), new string('*', i + 1));
            }


            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{2}|", new string('*', n / 2 + i), new string('*', n - i * 2), new string('*', n / 2 + i));
            }


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{2}", new string('-', i + 1), new string('*', n * 2 - i * 2 - 1), new string('-', i + 1));
            }
        }
    }
}
