using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._13.Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            string result = null;

            if ((y == 0 && 0 <= x && x <= h * 3) || (x == h * 3 && 0 <= y && y <= h) || (y == h && h * 2 <= x && x <= h * 3) || (x == h * 2 && h <= y && y <= h * 4) || (y == h * 4 && h <= x && x <= h * 2) || (x == h && h <= y && y <= h * 4) || (y == h && 0 <= x && x <= h) || (x == 0 && 0 <= y && y <= h))
            {
                result = "border";
            }
            else if ((0 < x && x < h * 3 && 0 < y && y < h) || (h < x && x < h * 2 && h <= y && y < h * 4))
            {
                result = "inside";
            }
            else
            {
                result = "outside";
            }

            Console.WriteLine(result);
        }
    }
}
