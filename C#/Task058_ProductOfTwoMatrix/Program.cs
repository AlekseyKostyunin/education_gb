/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();

Console.Write("Введите размер первой матрицы: ");
int matrix1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите размер второй матрицы: ");
int matrix2 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();

int[,] array1 = GetArrayMarix(matrix1, 0, 10);
PrintArray(array1);
Console.WriteLine();

int[,] array2 = GetArrayMarix(matrix2, 0, 10);
PrintArray(array2);
Console.WriteLine();

if (matrix1 == matrix2)
{
    int[,] newmatrix = new int[matrix1, matrix1];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++) 
        {
            newmatrix[i,j] = array1[i,j] * array2[i,j];
        }
    }
    Console.WriteLine("Результирующая матрица: ");
    PrintArray(newmatrix);
}
else Console.Write("Матрицы не равны! Повторите ввод.");

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

int[,] GetArrayMarix(int m, int minValue, int maxValue)
{
    int[,] result = new int[m, m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}