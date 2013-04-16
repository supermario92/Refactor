using System;

namespace Task02RefactorPrintStatistics
{
    class PrintStatistics
    {
        public void PrintStatistics(double[] array)
        {
            PrintMaxElement(array);
            PrintMinElement(array);
            PrintAverage(array);
        }

        public void PrintMinElement(double[] array)
        {
            double minElement = array[0];

            for (int indexOfTheElement = 1; indexOfTheElement < array.Length; indexOfTheElement++)
            {
                if (array[indexOfTheElement] < minElement)
                {
                    minElement = array[indexOfTheElement];
                }
            }

            Console.WriteLine(minElement);
        }

        public void PrintMaxElement(double[] array)
        {
            double maxElement = array[0];

            for (int indexOfTheElement = 1; indexOfTheElement < array.Length; indexOfTheElement++)
            {
                if (array[indexOfTheElement] > maxElement)
                {
                    maxElement = array[indexOfTheElement];
                }
            }

            Console.WriteLine(maxElement);
        }

        public void PrintAverage(double[] array)
        {
            double sumOfTheElements = 0;

            for (int indexOfTheElement = 0; indexOfTheElement < array.Length; indexOfTheElement++)
            {
                sumOfTheElements += array[indexOfTheElement];
            }

            double average = sumOfTheElements / array.Length;
            Console.WriteLine(average);
        }
    }
}
