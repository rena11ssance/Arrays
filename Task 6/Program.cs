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
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[n, n];

            Console.WriteLine("Введите элементы матрицы построчно.");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Элемент {0}, {1}: ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Матрица: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                
                Console.WriteLine();
            }

            int magicSum = 0;
            for (int j = 0; j < n; j++)
            {
                magicSum += matrix[0, j];

            }
            bool isMagic = true;

            for (int i = 0; i < n && isMagic; i++)
            {
                int rowSum = 0, colSum = 0;
                for (int j = 0; j < n; j++)
                {
                    rowSum += matrix[i, j];
                    colSum += matrix[j, i];
                }
                if (rowSum != magicSum || colSum != magicSum)
                    isMagic = false;
            }

            int mainDiag = 0, sideDiag = 0;
            for (int i = 0; i < n; i++)
            {
                mainDiag += matrix[i, i];
                sideDiag += matrix[i, n - 1 - i];
            }
            if (mainDiag != magicSum || sideDiag != magicSum)
                isMagic = false;

            Console.WriteLine(isMagic ? "Это магический квадрат." : "Это не магический квадрат.");

        }
    }
}
