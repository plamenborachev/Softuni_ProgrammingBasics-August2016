using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._18.Number_0_100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string firstDigit = null;
            string secondDigit = null;

            if (number < 0 || 100 < number)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                if (number == 100)
                {
                    secondDigit = "one hundred";
                }

                if (number / 10 == 9)
                {
                    firstDigit = "ninety";
                }
                else if (number / 10 == 8)
                {
                    firstDigit = "eighty";
                }
                else if (number / 10 == 7)
                {
                    firstDigit = "seventy";
                }
                else if (number / 10 == 6)
                {
                    firstDigit = "sixty";
                }
                else if (number / 10 == 5)
                {
                    firstDigit = "fifty";
                }
                else if (number / 10 == 4)
                {
                    firstDigit = "fourty";
                }
                else if (number / 10 == 3)
                {
                    firstDigit = "thirty";
                }
                else if (number / 10 == 2)
                {
                    firstDigit = "twenty";
                }

                if (number % 10 == 9)
                {
                    secondDigit = "nine";
                }
                else if (number % 10 == 8)
                {
                    secondDigit = "eight";
                }
                else if (number % 10 == 7)
                {
                    secondDigit = "seven";
                }
                else if (number % 10 == 6)
                {
                    secondDigit = "six";
                }
                else if (number % 10 == 5)
                {
                    secondDigit = "five";
                }
                else if (number % 10 == 4)
                {
                    secondDigit = "four";
                }
                else if (number % 10 == 3)
                {
                    secondDigit = "three";
                }
                else if (number % 10 == 2)
                {
                    secondDigit = "two";
                }
                else if (number % 10 == 1)
                {
                    secondDigit = "one";
                }
                else if (number == 0)
                {
                    secondDigit = "zero";
                }
            
                if (number == 19)
                {
                    secondDigit = "nineteen";
                }
                else if (number == 18)
                {
                    secondDigit = "eighteen";
                }
                else if (number == 17)
                {
                    secondDigit = "seventeen";
                }
                else if (number == 16)
                {
                    secondDigit = "sixteen";
                }
                else if (number == 15)
                {
                    secondDigit = "fifteen";
                }
                else if (number == 14)
                {
                    secondDigit = "fourteen";
                }
                else if (number == 13)
                {
                    secondDigit = "thirteen";
                }
                else if (number == 12)
                {
                    secondDigit = "twelve";
                }
                else if (number == 11)
                {
                    secondDigit = "eleven";
                }
                else if (number == 10)
                {
                    secondDigit = "ten";
                }
            }

            if (number == 100 || number <= 19)
            {
                Console.WriteLine(secondDigit);
            }
            else
            {
                if (number / 10 == 0)
                {
                    Console.WriteLine(firstDigit);
                }
                else
                {
                    Console.WriteLine("{0} {1}", firstDigit, secondDigit);
                }
            }
        }
    }
}
