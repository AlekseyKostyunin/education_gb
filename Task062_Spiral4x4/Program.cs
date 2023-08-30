/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

Решение подсмотрено здесь:
https://github.com/Lidia-Vorontsova/task62_homework/blob/main/Program.cs
*/

Console.Clear();

Console.Write("Введите размер квадратного массива: ");
int n = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetSpiralArray(n);
PrintArray(array);

int[,] GetSpiralArray(int N) 
{
    int[,] result = new int[N, N];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= N * N)
    {
        result[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < result.GetLength(1) - 1)   j++;
        else if (i < j && i + j >= result.GetLength(0) - 1)  i++;
        else if (i >= j && i + j > result.GetLength(1) - 1)  j--;
        else                                                 i--;
    }
    return result;
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