/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число ");
string userInput1 = Console.ReadLine() ?? ""; 
int a = int.Parse(userInput1); 
int i = 1;

Console.Write($"{a} -> ");

while (i <= a)
{
    if (i % 2 == 0) Console.Write($"{i}, ");
    i++;
}