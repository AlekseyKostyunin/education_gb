/*Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 --> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "");

int result = GetAkkermanNM(m, n);
Console.Write($"M = {m}, N = {n} --> {result}");

int GetAkkermanNM (int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return GetAkkermanNM(M - 1, 1);
    }
    else
    {
        return (GetAkkermanNM(M - 1, GetAkkermanNM(M, N - 1)));
    }
}