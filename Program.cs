using System;
using System.Collections;
using System.Collections.Generic;

namespace PrimeNumbers
{
    static class Program
    {
        static void Main()
        {
            int initialNumber;
            int finalNumber;

            Console.Write("\n\tOlá, bem vindx ao jogo! \n\n\tDigite o número inicial: ");
            initialNumber = int.Parse(Console.ReadLine());

            Console.Write("\n\tDigite o número final: ");
            finalNumber = int.Parse(Console.ReadLine());

            List<int> listOfPrimeNumbers = ExtractPrimeNumbersFromInterval(initialNumber, finalNumber);

            Console.Write("\n\n\tList of prime numbers within the informed interval: \n\t");
            for (int x = 0; x < listOfPrimeNumbers.Count; x++) Console.Write(listOfPrimeNumbers[x] + " ");

            Console.ReadLine();
        }

        public static List<int> ExtractPrimeNumbersFromInterval(int initialNumber, int finalNumber)
        {
            List<int> listOfPrimeNumbers = new List<int>();

            for (int i = initialNumber; i <= finalNumber; i++)
            {
                if ((i == 1) || (i % 2 == 0)) continue;

                bool isAPrimeNumber = true;
                for (int j = 3; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {
                        isAPrimeNumber = false;
                        break;
                    }
                }

                if (isAPrimeNumber) listOfPrimeNumbers.Add(i);
            }

            return listOfPrimeNumbers;
        }
    }
}