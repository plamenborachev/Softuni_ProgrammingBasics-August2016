using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._05.Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;

            for (int i = 0; i < n; i++)
            {
                if (n >= num)
                {
                    Console.WriteLine(num);
                    num = num * 2 + 1;
                }
            }
        }
    }
}
