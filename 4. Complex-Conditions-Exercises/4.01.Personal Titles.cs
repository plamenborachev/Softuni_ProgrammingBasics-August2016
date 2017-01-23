using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._01.Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            string personalTitle = null;

            if (gender == 'm')
            {
                if (16 <= age)
                {
                    personalTitle = "Mr.";
                }
                else
                {
                    personalTitle = "Master";
                }
            }
            else if (gender == 'f')
            {
                if (16 <= age)
                {
                    personalTitle = "Ms.";
                }
                else
                {
                    personalTitle = "Miss";
                }
            }
            Console.WriteLine(personalTitle);
        }
    }
}
