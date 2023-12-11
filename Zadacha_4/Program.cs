// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых
//  расположен наименьший элемент массива. Под удалением понимается создание нового
//  двумерного массива без строки и столбца


using System;

namespace RemoveRowAndColumnInArray
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

            // Находим строку и столбец с наименьшим элементом
            int minIndex = 0;
            int minValue = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < minValue)
                    {
                        minValue = array[i, j];
                        minIndex = i;
                    }
                }
            }

            // Создаём новый массив без строки и столбца с наименьшим элементом
            int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    if (i != minIndex && j != minIndex)
                    {
                        newArray[i, j] = array[i, j];
                    }
                }
            }

            // Выводим новый массив
            Console.WriteLine("Новый массив:");
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    Console.Write("{0,2} ", newArray[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}