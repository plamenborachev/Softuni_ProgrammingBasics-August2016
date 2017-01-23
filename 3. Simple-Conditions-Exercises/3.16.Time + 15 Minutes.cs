using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._16.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int totalMinutes = h * 60 + m + 15;

            if (totalMinutes / 60 < 24)
            {
                if (totalMinutes % 60 < 10)
                {
                    Console.WriteLine("{0}:0{1}", totalMinutes / 60, totalMinutes % 60);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", totalMinutes / 60, totalMinutes % 60);
                }
            }
            else
            {
                if (totalMinutes % 60 < 10)
                {
                    Console.WriteLine("{0}:0{1}", totalMinutes / 60 - 24, totalMinutes % 60);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", totalMinutes / 60 - 24, totalMinutes % 60);
                }
            }
            
        }
    }
}
