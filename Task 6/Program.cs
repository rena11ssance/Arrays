using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность матрицы N: ");
            int nValue = Convert.ToInt32(Console.ReadLine());

            int[,] arrayInitialization = new int[nValue, nValue];

            Console.WriteLine("Введите элементы матрицы построчно.");
            for (int i = 0; i < nValue; i++)
            {
                for (int j = 0; j < nValue; j++)
                {
                    Console.Write("Элемент {0}, {1}: ", i, j);
                    arrayInitialization[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Матрица: ");
            for (int i = 0; i < nValue; i++)
            {
                for (int j = 0; j < nValue; j++)
                {
                    Console.Write(arrayInitialization[i, j] + " ");
                }
                
                Console.WriteLine();
            }

            int magicSum = 0;
            for (int j = 0; j < nValue; j++)
            {
                magicSum += arrayInitialization[0, j];

            }
            bool isMagic = true;

            for (int i = 0; i < nValue && isMagic; i++)
            {
                int rowSum = 0, colSum = 0;
                for (int j = 0; j < nValue; j++)
                {
                    rowSum += arrayInitialization[i, j];
                    colSum += arrayInitialization[j, i];
                }
                if (rowSum != magicSum || colSum != magicSum)
                    isMagic = false;
            }

            int mainDiagonal = 0, sideDiagonal = 0;
            for (int i = 0; i < nValue; i++)
            {
                mainDiagonal += arrayInitialization[i, i];
                sideDiagonal += arrayInitialization[i, nValue - 1 - i];
            }
            if (mainDiagonal != magicSum || sideDiagonal != magicSum)
                isMagic = false;

            Console.WriteLine(isMagic ? "Это магический квадрат." : "Это не магический квадрат.");
            Console.ReadKey();
        }
    }
}
