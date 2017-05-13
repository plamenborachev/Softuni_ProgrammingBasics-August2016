using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Battles
    {
        static void Main(string[] args)
        {
            int pockemonsPlayer1 = int.Parse(Console.ReadLine());
            int pockemonsPlayer2 = int.Parse(Console.ReadLine());
            int battlesCount = 0;
            int maxBattles = int.Parse(Console.ReadLine());

            for (int p1 = 1; p1 <= pockemonsPlayer1; p1++)
            {
                for (int p2 = 1; p2 <= pockemonsPlayer2; p2++)
                {
                    if (maxBattles == battlesCount)
                    {
                        break;
                    }
                    Console.Write("({0} <-> {1}) ", p1, p2);
                    battlesCount++;
                }
            }
            Console.WriteLine();
        }

    }
}

