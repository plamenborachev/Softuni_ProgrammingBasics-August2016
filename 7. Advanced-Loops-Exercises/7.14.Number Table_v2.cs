using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._14.Number_Table_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 1; cols <= n; cols++)
                {
                    if (cols > 1)
                    {
                        Console.Write(" ");
                    }
                    if ((rows + cols) <= n)
                    {
                        Console.Write(rows + cols);
                    }
                    else if ((rows + cols) > n)
                    {
                        Console.Write(n * 2 - rows - cols);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
