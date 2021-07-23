using System.Collections.Generic;

namespace PN
{
    public class Utilities
    {
        public static List<int> ExtractPrimeNumbersFromInterval(int initialNumber, int finalNumber)
        {
            List<int> listOfPrimeNumbers = new List<int>();

            for (int i = initialNumber; i <= finalNumber; i++)
            {
                if ((i == 1) || ((i != 2) && (i % 2 == 0))) continue;

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
