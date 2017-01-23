using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            if (inputCurrency == "USD")
            {
                sum *= 1.79549; 
            }
            else if (inputCurrency == "EUR")
            {
                sum *= 1.95583;
            }
            else if (inputCurrency == "GBP")
            {
                sum *= 2.53405;
            }

            if (outputCurrency == "USD")
            {
                sum /= 1.79549;
            }
            else if (outputCurrency == "EUR")
            {
                sum /= 1.95583;
            }
            else if (outputCurrency == "GBP")
            {
                sum /= 2.53405;
            }

            Console.WriteLine(Math.Round(sum, 2));
        }
    }
}
