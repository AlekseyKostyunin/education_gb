/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет
*/

int a;
while (true)
{
    Console.Write("Введите номер дня недели: ");
    if (int.TryParse(Console.ReadLine(), out a) && a > 0 && a < 8)
        break;
    Console.WriteLine("Ошибка ввода! Введите правильный номер дня недели.");
}

if (a == 6 || a == 7)
{
    Console.WriteLine($"{a} -> да");
}
else 
{
    Console.WriteLine($"{a} -> нет");
}

