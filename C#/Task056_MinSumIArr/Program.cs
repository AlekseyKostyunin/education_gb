/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();

int[,] array = GetArray(rows, colums, 0, 15);
PrintArray2(array);
Console.WriteLine();

int[] sumRows = GetSumRows(array); // сформировали массив с данными по суммам каждой строки
PrintArray1(sumRows);
Console.WriteLine();

int indexMinRow = GetIndexMinRow(sumRows); // вычисляем строку с минимальной суммой
Console.Write($"Cтрока с наименьшей суммой элементов: {indexMinRow}");

int GetIndexMinRow(int[] inArray)
{
    int indexMinRow = 0;
    for (int i = 1; i < inArray.Length; i++)
    {
        if(inArray[indexMinRow] > inArray[i]) indexMinRow = i;
    }
    return indexMinRow;
}

int[] GetSumRows(int[,] inArray)
{    
    int[] sumRow = new int[inArray.GetLength(0)]; // массив для записи суммы каждой строки. Его размер равен кол-ву строк во входном массиве

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            summa += inArray[i,j];
        }
        sumRow[i] = summa;
    }
    return sumRow;
}

void PrintArray1(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}

void PrintArray2(int[,] inArray)
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

