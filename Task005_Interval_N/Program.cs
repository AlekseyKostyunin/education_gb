﻿/* Задача № 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
*/

Console.WriteLine("Введите число ");
string userInput1 = Console.ReadLine() ?? ""; 
int a = int.Parse(userInput1); 
int i = -a;
Console.Write($"{a} -> ");

while (i <= a)
{
    Console.Write($"{i}, ");
    i++;
}