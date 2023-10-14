/*
Задача № 14. Напишите программу, которая принимает на вход число 
и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/
Console.Clear();

Console.WriteLine("Введите число ");
string userInput1 = Console.ReadLine() ?? ""; 
int a = int.Parse(userInput1); 

if (a % 7 == 0 && a % 23 == 0) 
{
    Console.WriteLine($"{a} -> да");
}
else 
{
    Console.WriteLine($"{a} -> нет");
}

