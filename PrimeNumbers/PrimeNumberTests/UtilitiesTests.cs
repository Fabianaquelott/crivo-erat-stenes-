using NUnit.Framework;
using PN;
using System;
using System.Collections.Generic;

namespace PNGeneratorTests
{
    public class UtilitiesTests
    {
        [Test]
        public void ShallReturnEmptyListWhenIntervalIsZero()
        {
            // Arrange
            Random random = new Random();

            int initialNumber = random.Next(0, 100);
            int finalNumber = initialNumber;

            // Act
            List<int> listOfPrimeNumbers = Utilities.ExtractPrimeNumbersFromInterval(initialNumber, finalNumber);

            // Assert
            Assert.That(listOfPrimeNumbers.Count, Is.EqualTo(0));
        }

        [Test]
        public void ShallReturnThreePrimeNumbers()
        {
            //Arrange
            int initialNumber = 0;
            int finalNumber = 6;

            // Act
            List<int> listOfPrimeNumbers = Utilities.ExtractPrimeNumbersFromInterval(initialNumber, finalNumber);

            // Assert
            Assert.That(listOfPrimeNumbers.Count, Is.EqualTo(3));
        }

        [Test]
        public void ShallReturnThisListOfNumbersWhenIntervalRangesFromZeroToOneHundred()
        {
            // Arrange
            List<int> expectedPrimeNumbers = new List<int> { 
                2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 
                43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97
            };

            int initialNumber = 0;
            int finalNumber = 100;

            // Act
            List<int> returnedPrimeNumbers = Utilities.ExtractPrimeNumbersFromInterval(initialNumber, finalNumber);

            // Assert
            Assert.That(expectedPrimeNumbers, Is.EqualTo(returnedPrimeNumbers));
        }
    }
}
