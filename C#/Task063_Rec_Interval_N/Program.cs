/*Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 --> "1, 2, 3, 4,
N = 6 --> "1, 2, 3, 4, 5,*/

Console.Clear();

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "");

string result = GetNumbersRec(1, n);
Console.Write($"N = {n} --> {result}");

string GetNumbersRec (int start, int N)
{
    if(start < N) return $"{start}, " + GetNumbersRec(start + 1, N);
    else return String.Empty;
}