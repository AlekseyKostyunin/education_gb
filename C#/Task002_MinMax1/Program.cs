/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 ->  max = 7
a = 2; b = 10 -> max = 10
a = -9; b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число ");
string userInput1 = Console.ReadLine() ?? ""; 
int a = int.Parse(userInput1); 

Console.WriteLine("Введите второе число ");
string userInput2 = Console.ReadLine() ?? ""; 
int b = int.Parse(userInput2);

if (a > b)
{
    Console.WriteLine($"a = {a}, b = {b} -> max = {a}");
}
else
{
    Console.WriteLine($"a = {a}, b = {b} -> max = {b}");
}
