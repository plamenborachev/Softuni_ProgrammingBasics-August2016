using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._03.Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 0; rows < n; rows++)
            {
                Console.Write("*");
                for (int cols = 0; cols < n - 1; cols++)
                {
                    Console.WriteLine(" *");
                }
                //Console.WriteLine();
            }
        }
    }
}
