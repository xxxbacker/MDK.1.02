using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arr_var27
{
    internal class Program
    {
        public static int GetPositionDifference(int[] arr)
        {
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex - minIndex + 1;
        }

        public static void SortAndReplace(double[,] ar)
        {
            int rows = ar.GetLength(0);
            int cols = ar.GetLength(1);

            // Преобразуем двумерный массив в одномерный для упорядочивания
            double[] flatArr = new double[rows * cols];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    flatArr[index++] = ar[i, j];
                }
            }

            // Упорядочиваем одномерный массив по убыванию
            Array.Sort(flatArr);
            Array.Reverse(flatArr);

            // Заменяем элементы с четными индексами
            index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        ar[i, j] = Math.Round(1 / flatArr[index++], 2);
                    }
                    else
                    {
                        ar[i, j] = flatArr[index++];
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("задание 1 ");

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(GetPositionDifference(arr));

            Console.WriteLine("----------------------------------");
            Console.WriteLine("задание 2 ");

            double[,] ar = { { 4, 3, 2 }, { 9, 8, 7 }, { 1, 5, 6 } };
            SortAndReplace(ar);
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Console.Write($"{ar[i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
 