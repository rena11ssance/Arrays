using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность: ");
            int nValue = Convert.ToInt32(Console.ReadLine());
            int[,] arrayInitialization = new int [nValue, nValue];

            for (int i = 0; i < nValue; i++)
            {
                for (int j = 0; j < nValue; j++)
                {
                    arrayInitialization[i, j] = (((i + j) % 2 == 0) ? 1 : 0);
                    Console.Write("{0} ", arrayInitialization[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
