// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив: 1 4 7 2 5 9 2 3 8 4 2 4 Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;
using hw7;

Clear();

double[,] rendomArray = Class1.GetRandomArray(3, 4, -100, 100, 1);
WriteLine("Исходный массив");
Class1.printArray(rendomArray);
WriteLine("Среднее арифметическое элементов в каждом столбце равно:");
Class1.printArray(GetColumnMean(rendomArray));

double[] GetColumnMean(double[,] arrayD2)
{

    double[] result = new double[arrayD2.GetLength(1)];
        for (int i = 0; i < arrayD2.GetLength(1); i++)
        {
            double average = 0;
            for (int j = 0; j < arrayD2.GetLength(0); j++)
            {
              average +=arrayD2[j, i];
            }
            result[i] = average / arrayD2.GetLength(0);
    }
    return result;
}