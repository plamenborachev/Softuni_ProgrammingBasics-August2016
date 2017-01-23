using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._05.Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 0; rows < n; rows++)
            {
                if (rows == 0 || rows == n - 1)
                {
                    Console.Write("+ ");
                }
                else
                {
                    Console.Write("| ");
                }

                for (int cols = 1; cols < n - 1; cols++)
                {
                    Console.Write("- ");
                }

                if (rows == 0 || rows == n - 1)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("|");
                }
                Console.WriteLine();
            }
        }
    }
}
