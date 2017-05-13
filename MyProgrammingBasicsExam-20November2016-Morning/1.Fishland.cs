using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Fishland
    {
        static void Main(string[] args)
        {
            double priceSkumria = double.Parse(Console.ReadLine());
            double priceCaca = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            int kgMidi = int.Parse(Console.ReadLine());

            double pricePalamud = priceSkumria * 1.60;
            double priceSafrid = priceCaca * 1.80;
            double priceMidi = 7.50;

            double bill = pricePalamud * kgPalamud + priceSafrid * kgSafrid + priceMidi * kgMidi;

            Console.WriteLine("{0:f2}", bill);

        }
    }
}
