using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oldSum = 0;
            int sum = 0;
            int diff = 0;

            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                sum = num1 + num2;
                if (i > 0)
                {
                    diff = Math.Abs(oldSum - sum);
                }
                oldSum = sum;
            }

            if (diff == 0)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", diff);
            }
        }
    }
}
