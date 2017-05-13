using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeftInKg = int.Parse(Console.ReadLine());
            double foodDogInKg = double.Parse(Console.ReadLine());
            double foodCatInKg = double.Parse(Console.ReadLine());
            double foodTurtleInG = double.Parse(Console.ReadLine());

            double foodNeededInKg = days * (foodDogInKg + foodCatInKg + foodTurtleInG / 1000.0);

            if (foodLeftInKg >= foodNeededInKg)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodLeftInKg - foodNeededInKg));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(foodNeededInKg - foodLeftInKg));
            }

        }
    }
}
