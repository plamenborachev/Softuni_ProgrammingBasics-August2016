using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = Int32.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > maxNum)
                {
                    maxNum = num;
                }
            }

            if (maxNum == sum - maxNum)
            {
                Console.WriteLine("Yes Sum = {0}", maxNum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(maxNum - (sum - maxNum)));
            }
        }
    }
}
