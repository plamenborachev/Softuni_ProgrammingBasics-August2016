using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter even number: ");
            int n = int.Parse(Console.ReadLine());

                while (n % 2 != 0)
                {
                    try
                    {
                        Console.WriteLine("The number is not even.");
                        Console.Write("Enter even number: ");
                        n = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Invalid number.");
                    }
                }
                Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
