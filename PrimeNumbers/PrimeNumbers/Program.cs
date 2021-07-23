using System;
using System.Collections;
using System.Collections.Generic;

namespace PN
{
    static class Program
    {
        static void Main()
        {
            int initialNumber;
            int finalNumber;

            Console.Write("\n\tOlá, seja bem vindo(a) ao jogo! \n\n\tDigite o número inicial: ");
            initialNumber = int.Parse(Console.ReadLine());

            Console.Write("\n\tDigite o número final: ");
            finalNumber = int.Parse(Console.ReadLine());

            List<int> listOfPrimeNumbers = Utilities.ExtractPrimeNumbersFromInterval(initialNumber, finalNumber);

            Console.Write("\n\n\tLista de números primos dentro do intervalo informado: \n\t");
            for (int x = 0; x < listOfPrimeNumbers.Count; x++) Console.Write(listOfPrimeNumbers[x] + " ");
        }
    }
}