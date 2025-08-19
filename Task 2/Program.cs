using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int sizeArray = 15;
            Random random = new Random();
            int[] arrayInitialization = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                int randomNumber = random.Next(0, 51); // включая в рандом верхнюю границу по заданию, то есть 50.
                arrayInitialization[i] = randomNumber;
                Console.Write(arrayInitialization[i] + " ");
            }
            Console.WriteLine();

            int minValue = arrayInitialization[0];
            int maxValue = arrayInitialization[0];

            foreach (int temporaryValue in arrayInitialization)
            {
                if (temporaryValue < minValue)
                    minValue = temporaryValue;

                else if (temporaryValue > maxValue)
                    maxValue = temporaryValue;
            }

            Console.WriteLine("Минимальное число: {0}, максимальное {1}.", minValue, maxValue);

            int sum = minValue + maxValue;
            Console.Write("А сумма минимального и максимального чисел равняется: {0}.", sum);

            Console.ReadKey();
        }
    }
}
