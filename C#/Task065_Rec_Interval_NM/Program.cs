/*Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 --> "1, 2, 3, 4,
M = 4; N = 8 --> "4 , 5, 6, 7, 8"*/

Console.Clear();

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "");

string result = GetNumbersRec(m, n);
Console.Write($"M = {m}, N = {n} --> {result}");

string GetNumbersRec (int M, int N)
{
    if(M < N) return $"{M}, " + GetNumbersRec(M + 1, N);
    else return String.Empty;
}