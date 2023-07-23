/* 
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число: ");
string userInput1 = Console.ReadLine() ?? ""; 
int a = int.Parse(userInput1); 

if (a % 2 == 0) Console.Write($"{a} -> да");
else Console.Write($"{a} -> нет");