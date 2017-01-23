using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._08.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            int timeSum = time1 + time2 + time3;

            if (0 <= timeSum % 60 && timeSum % 60 <= 9)
            {
                Console.WriteLine("{0}:0{1}", timeSum / 60, timeSum % 60);
            }
            else
            {
                Console.WriteLine("{0}:{1}", timeSum / 60, timeSum % 60);
            }
        }
    }
}
