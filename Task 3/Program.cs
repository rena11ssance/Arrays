using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int sizeArray = 10;
            Random random = new Random();
            int[] arrayInitialization = new int[sizeArray];

            Console.Write("Сгенерированные 10 чисел для массива: ");
            for (int i = 0; i < sizeArray; i++)
            {
                int randomNumber = random.Next(-50, 51); // включая в рандом верхнюю границу по заданию, то есть 50.
                arrayInitialization[i] = randomNumber;
                Console.Write(arrayInitialization[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Результат (первые пять по возрастанию, последние пять по убыванию): ");

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (arrayInitialization[i] > arrayInitialization[j])
                    {
                        int temporaryValue = arrayInitialization[i];
                        arrayInitialization[i] = arrayInitialization[j];
                        arrayInitialization[j] = temporaryValue;
                    }
                }
            }

            for (int i = 5; i < sizeArray; i++)
            {
                for (int j = i + 1; j < sizeArray; j++)
                {
                    if (arrayInitialization[i] < arrayInitialization[j])
                    {
                        int temporaryValue = arrayInitialization[i];
                        arrayInitialization[i] = arrayInitialization[j];
                        arrayInitialization[j] = temporaryValue;
                    }
                }
            }

            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write("{0} ", arrayInitialization[i] );
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
