/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3, b = 9 -> нет
*/

Console.WriteLine("Введите первое число ");
string userInput1 = Console.ReadLine() ?? "";
int a = int.Parse(userInput1);

Console.WriteLine("Введите второе число ");
string userInput2 = Console.ReadLine() ?? "";
int b = int.Parse(userInput2);

if (b*b == a)
{
    //Console.WriteLine("да");
    Console.WriteLine($"a = {a}, b = {b} -> да");
}
else
{
    //Console.WriteLine("нет");
    Console.WriteLine($"a = {a}, b = {b} -> нет");
}