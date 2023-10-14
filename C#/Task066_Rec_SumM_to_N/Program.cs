/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 --> 120
M = 4; N = 8 --> 30 */

Console.Clear();

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "");

int result = GetSumNM(m, n);
Console.Write($"M = {m}, N = {n} --> {result}");

int GetSumNM (int M, int N)
{
    int sum = 0;
    if(M <= N) sum += M + GetSumNM(M+1,N);
    return sum;
}
