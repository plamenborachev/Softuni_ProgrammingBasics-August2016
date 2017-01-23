using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._03.Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int prevNum = 1;

            Console.WriteLine(prevNum);
            for (int i = 1; i <= n; i++)
            {
                int num = prevNum * 2;
                prevNum = num;

                Console.WriteLine(num);
            }
        }
    }
}
