/* 
Задача № 16. Напишите программу, которая принимает на вход два числа 
и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет 
*/
Console.Clear();

Console.WriteLine("Введите первое число ");
string userInput1 = Console.ReadLine() ?? ""; 
int a = int.Parse(userInput1); 

Console.WriteLine("Введите второе число ");
string userInput2 = Console.ReadLine() ?? ""; 
int b = int.Parse(userInput2);

if (b == a*a || a == b*b)
{
    Console.WriteLine($"{a}, {b} -> да");
}
else 
{
    Console.WriteLine($"{a}, {b} -> нет");
}