using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int sizeArray = 20;
            int oddElement = 0;
            Random random = new Random();
            int[] arrayInitialization = new int[sizeArray];

            Console.Write("Сгенерированные 20 чисел для массива: ");
            for (int i = 0; i < sizeArray; i++)
            {
                int randomNumber = random.Next(-50, 51); // включая в рандом верхнюю границу по заданию, то есть 50.
                arrayInitialization[i] = randomNumber;
                Console.Write(arrayInitialization[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < sizeArray; i++)
            {
                if (i % 2 == 0 && arrayInitialization[i] % 2 != 0 && arrayInitialization[i] > 0)
                    {
                        oddElement++;
                    }
            }
            Console.Write("Количество нечетных положительных элементов, стоящих на четных местах: {0}.", oddElement);
            Console.ReadKey();
        }
    }
}
