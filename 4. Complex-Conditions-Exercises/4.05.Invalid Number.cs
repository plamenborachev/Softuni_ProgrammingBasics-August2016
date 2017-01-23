using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._05.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (!(number == 0 || (100 <= number && number <=200)))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
