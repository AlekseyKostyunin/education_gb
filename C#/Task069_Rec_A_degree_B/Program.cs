/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 --> 243
A = 2; B = 3--> 8*/

Console.Clear();

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine() ?? "");

int result = GetDegreeRec(a, b);
Console.Write($"A = {a}, B = {b} --> {result}");

int GetDegreeRec (int A, int B)
{
    if(B == 0) return 1;
    if(B == 1) return A;
    return A*GetDegreeRec(A, B-1);
}