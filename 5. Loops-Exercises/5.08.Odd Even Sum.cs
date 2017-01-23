using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    oddSum += num;
                }
                else
                {
                    evenSum += num;
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes Sum = {0}", evenSum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(oddSum - evenSum));
            }
        }
    }
}
