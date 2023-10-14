/*Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 --> 12
45 --> 9*/

Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "");

int sum = GetSumRec(n);
Console.Write($"{n} --> {sum}");

int GetSumRec (int N)
{
    if(N == 0) return 0;
    return N % 10 + GetSumRec(N/10);
}
