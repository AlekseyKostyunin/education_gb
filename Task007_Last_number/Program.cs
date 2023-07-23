/* Задача № 7 
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.	
456 -> 6	782 -> 2	918 -> 8
*/

Console.WriteLine("Введите число ");
string userInput1 = Console.ReadLine() ?? ""; 
int a = int.Parse(userInput1); 
int i = a % 10;
Console.Write($"{a} -> {i}");