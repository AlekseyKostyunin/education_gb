/* Задача № 10
Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8 
918 -> 1
*/
//Console.Clear();

int a;
while (true)
{
    Console.Write("Введите трехзначное число: ");
    if (int.TryParse(Console.ReadLine(), out a) && a > 99 && a < 1000)
        break;
    Console.WriteLine("Ошибка ввода! Введите трехзначное число.");
    
}

int a2 = a % 100 / 10; 

Console.WriteLine($"{a} -> {a2}");