using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int adults = int.Parse(Console.ReadLine());
            int schoolboys = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            string transportation = Console.ReadLine();

            double transportationPriceAdults = 0.0;
            double transportationPriceSchoolboys = 0.0;

            if (transportation == "train")
            {
                if ((adults + schoolboys) < 50)
                {
                    transportationPriceAdults = 24.99;
                    transportationPriceSchoolboys = 14.99;
                }
                else
                {
                    transportationPriceAdults = 24.99 * 0.50;
                    transportationPriceSchoolboys = 14.99 * 0.50;
                }
            }
            else if (transportation == "bus")
            {
                transportationPriceAdults = 32.50;
                transportationPriceSchoolboys = 28.50;
            }
            else if (transportation == "boat")
            {
                transportationPriceAdults = 42.99;
                transportationPriceSchoolboys = 39.99;
            }
            else if (transportation == "airplane")
            {
                transportationPriceAdults = 70.00;
                transportationPriceSchoolboys = 50.00;
            }

            double totalSum = (2 * (adults * transportationPriceAdults + schoolboys * transportationPriceSchoolboys) + days * 82.99) * 1.10;

            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}
