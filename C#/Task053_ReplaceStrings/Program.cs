﻿/* Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку массива.*/

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);

Console.WriteLine();

ReplaceStrings(array);
PrintArray(array);

void ReplaceStrings(int[,] inArray)
{
    int lastRow = inArray.GetLength(0) - 1; // индекс последней строки
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        int temp = inArray[0, j];
        inArray[0, j] = inArray[lastRow, j];
        inArray[lastRow, j] = temp;
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}