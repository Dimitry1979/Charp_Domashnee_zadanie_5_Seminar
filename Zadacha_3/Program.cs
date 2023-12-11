// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

using System;

namespace FindMinSumRowInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём двумерный массив
            int[,] array = new int[3, 4];

            // Заполняем массив случайными числами
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(100);
                }
            }

            // Выводим оригинальный массив
                Console.WriteLine("Оригинальный массив:");
                

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0,2} ", array[i, j]);
                }
                Console.WriteLine();
            }

            // Находим строку с наименьшей суммой элементов
            int minSumRow = 0;
            int minSum = int.MaxValue;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
                if (sum < minSum)
                {
                    minSum = sum;
                    minSumRow = i;
                }
            }

            // Выводим строку с наименьшей суммой элементов
            Console.WriteLine("Строка с наименьшей суммой элементов:");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0,2} ", array[minSumRow, j]);
            }
            Console.WriteLine();
        }
    }
}