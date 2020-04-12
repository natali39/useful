using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_interest
{
    class Program
    {
        //Функция расчета сложного процента
        static double Calculate(string userInput)
        {
            string[] wordsOfInput = userInput.Split(' ');

            double summInitial = double.Parse(wordsOfInput[0]);
            double interestRate = double.Parse(wordsOfInput[1]);
            double periodInMonths = double.Parse(wordsOfInput[2]);

            double profitPerMonth = (interestRate / 100) / 12;

            return summInitial * Math.Pow(1 + profitPerMonth, periodInMonths);
        }
        static void Main(string[] args)
        {
            //На вход подается 3 числа через пробел:
            //начальная сумма, годовой процент, срок в месяцах
            string userInput = Console.ReadLine();

            Console.WriteLine(Calculate(userInput));

            Console.ReadKey();
        }
    }
}
