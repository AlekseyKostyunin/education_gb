/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до M
M = 1; N = 5. --> 5 , 4 , 3, 2 , 1
M = 4; N = 8. --> 8 , 7 , 6 , 5, 4*/

Console.Clear();

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "");

string result = GetNumbersRec(m, n);
Console.Write($"M = {m}, N = {n} --> {result}");

string GetNumbersRec (int M, int N)
{
    if(N >= M) return $"{N}, " + GetNumbersRec(M, N - 1);
    else return String.Empty;
}
