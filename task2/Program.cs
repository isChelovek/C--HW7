// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7-> такого числа в массиве нет

using System;
using static System.Console;
using hw7;

Clear();

double[,] rendomArray = Class1.GetRandomArray(3, 4, -100, 100, 1);

Class1.printArray(rendomArray);

Write("Введите адрес через пробел: ");
int[] array = Class1.GetArrayFromString(ReadLine());

if (rendomArray.GetLength(0) >= array[0] && rendomArray.GetLength(1) >= array[1])
{
    Write(rendomArray[array[0], array[1]]);
}
else
{
    Write("такого числа в массиве нет");
}