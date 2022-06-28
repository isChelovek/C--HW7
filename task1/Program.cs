// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
using static System.Console;
using hw7;

Clear();

Write("m = ");
int m = int.Parse(ReadLine());
Write("n = ");
int n = int.Parse(ReadLine());
Class1.printArray(Class1.GetRandomArray(m, n, -100, 100, 1));
