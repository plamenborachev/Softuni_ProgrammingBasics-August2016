using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._12.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsInHomeTown = int.Parse(Console.ReadLine());

            double games = ((48 - weekendsInHomeTown) * 3.0 / 4) + weekendsInHomeTown + (holidays * 2.0 / 3);

            if (year == "leap")
            {
                games = games * 1.15;
            }

            Console.WriteLine(Math.Floor(games));

        }
    }
}
