/*Задача № 12
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не 
кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/
Console.Clear();

Console.WriteLine("Введите первое число ");
string userInput1 = Console.ReadLine() ?? ""; 
int a = int.Parse(userInput1); 

Console.WriteLine("Введите второе число ");
string userInput2 = Console.ReadLine() ?? ""; 
int b = int.Parse(userInput2);

if (a % b == 0)
{
    Console.WriteLine($"{a}, {b} -> кратно");
}
else 
{
    Console.WriteLine($"{a}, {b} -> не кратно, остаток {a % b}");
}

