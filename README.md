# Массивы

Задача: Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.

Решение:
```
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

```
____
Задача: Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50]. Определить сумму максимального и минимального элементов массива.

Решение:
```
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
```
___
Задача: Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.

Решение:
```
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
```
___
Задача: Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. Определить количество   нечетных положительных элементов, стоящих на четных местах.

Решение:
```

```
___
Задача: Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:

> 1 0 1 0 1
>
> 0 1 0 1 0
>
> 1 0 1 0 1
> 
> 0 1 0 1 0
> 
> 1 0 1 0 1


Решение:
```

```
___
Задача: Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN. Заполнить массив числами, вводимыми с клавиатуры. Проверить, является ли введенная с клавиатуры матрица магическим квадратом. Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.

Решение:
```

```
