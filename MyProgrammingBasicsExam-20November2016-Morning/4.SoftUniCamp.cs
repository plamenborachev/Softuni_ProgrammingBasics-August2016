using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniCamp
{
    class SoftUniCamp
    {
        static void Main(string[] args)
        {
            int groupsOfStudents = int.Parse(Console.ReadLine());

            double car = 0.0;
            double microbus = 0.0;
            double smallBus = 0.0;
            double bigBus = 0.0;
            double train = 0.0;

            for (int i = 1; i <= groupsOfStudents; i++)
            {
                int studentsInGroup = int.Parse(Console.ReadLine());

                if (0 < studentsInGroup && studentsInGroup < 6)
                {
                    car += studentsInGroup;
                }
                else if (studentsInGroup < 13)
                {
                    microbus += studentsInGroup;
                }
                else if (studentsInGroup < 26)
                {
                    smallBus += studentsInGroup;
                }
                else if (studentsInGroup < 41)
                {
                    bigBus += studentsInGroup;
                }
                else if (studentsInGroup >= 41)
                {
                    train += studentsInGroup;
                }
            }

            double allStudents = car + microbus + smallBus + bigBus + train;

            Console.WriteLine("{0:f2}%", car * 100.0 / allStudents);
            Console.WriteLine("{0:f2}%", microbus * 100.0 / allStudents);
            Console.WriteLine("{0:f2}%", smallBus * 100.0 / allStudents);
            Console.WriteLine("{0:f2}%", bigBus * 100.0 / allStudents);
            Console.WriteLine("{0:f2}%", train * 100.0 / allStudents);
        }
    }
}
