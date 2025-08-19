using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int sizeArray = 7;
            int sumValue = 0;
            int[] arrayInitialization = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                Console.Write($"Введите значение: ");
                arrayInitialization[i] = Convert.ToInt32(Console.ReadLine());
                sumValue += arrayInitialization[i];
            }

            Console.Write("Ваш массив из 7 индексов выглядит так: ");

            foreach (int num in arrayInitialization)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            double average = (double)sumValue / sizeArray;
            Console.Write("А его среднее арифметическое элементов равно: {0:F2}.", average);

            Console.ReadKey();
        }
    }
}
