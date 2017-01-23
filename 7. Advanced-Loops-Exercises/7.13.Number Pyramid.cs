using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Demo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int rows = 1; rows <= n; rows++)
            {
                if (num <= n)
                {
                    for (int cols = 1; cols <= rows; cols++)
                    {
                        if (num <= n)
                        {
                            if (cols > 1)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(num);
                            num++;
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
