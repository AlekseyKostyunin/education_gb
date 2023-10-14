/* Задача № 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница
*/

Console.WriteLine("Введите номер дня недели ");
string userInput1 = Console.ReadLine() ?? ""; 
int a = int.Parse(userInput1); 

if (a == 1)
{
    Console.WriteLine($"{a} -> Понедельник");
}
else if (a == 2)
{
    Console.WriteLine($"{a} -> Вторник");
}
else if (a == 3)
{
    Console.WriteLine($"{a} -> Среда");
}
else if (a == 4)
{
    Console.WriteLine($"{a} -> Четверг");
}
else if (a == 5)
{
    Console.WriteLine($"{a} -> Пятница");
}
else if (a == 6)
{
    Console.WriteLine($"{a} -> Суббота");
}
else if (a == 7)
{
    Console.WriteLine($"{a} -> Воскресенье");
}
else 
{
    Console.WriteLine("Вы ввели некорректный номер");
}
