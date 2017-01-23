using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._04.Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 0; rows < n; rows++)
            {
                Console.Write("$");
                for (int cols = 0; cols < rows; cols++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
