using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._06.Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 0; rows < n; rows++)
            {
                Console.Write("{0}*", new string(' ', n - rows - 1));
                for (int cols = 0; cols < rows; cols++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int rows = 0; rows < n - 1; rows++)
            {
                Console.Write("{0}*", new string(' ', rows + 1));
                for (int cols = n - rows - 3; cols >= 0; cols-=1)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
