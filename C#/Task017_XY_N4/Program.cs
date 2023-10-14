/*17.
Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.
*/

/* Вариант 1 - без функций (методов)
Console.Clear();
Console.Write("Введите X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine());
if(X > 0 && Y > 0)
{
    Console.WriteLine("1");
}
else if(X < 0 && Y > 0)
{
    Console.WriteLine("2");
}
else if(X < 0 && Y < 0)
{
    Console.WriteLine("3");
}
else if(X > 0 && Y < 0)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("Ошибка! Точка попадает на оси координат!");
}
*/

/* Вариант 2 - с функциями (методами)
Console.Clear();

int X, Y;

try
{
    Console.Write("Введите Х: ");
    X = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите Y: ");
    Y = int.Parse(Console.ReadLine() ?? "");
}
catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}

if(X > 0 && Y > 0)
{
    Console.WriteLine("1");
}
else if(X < 0 && Y > 0)
{
    Console.WriteLine("2");
}
else if(X < 0 && Y < 0)
{
    Console.WriteLine("3");
}
else if(X > 0 && Y < 0)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("Ошибка! Точка попадает на оси координат!");
}
*/

// Вариант 3
//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка.
// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача 17. Определение номера четверти по заданным координатам";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Напишите программу, которая принимает на вход координаты точки (X и Y),
        причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
                в которой находится эта точка.
************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя целое число. Введённое число присваивается переменной x
int x = GetNumberFromUser("Введите коррдинату Х: ", "Ошибка ввода данных!");
// Вызов метода, запрашивающего у пользователя целое число. Введённое число присваивается переменной y
int y = GetNumberFromUser("Введите координату Y: ", "Ошибка ввода данных!");
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
int quarter;
try
{
    // Вызов метода, возвращающего номер четверти по переданным координатам x и y.
    // Результат вызова присваивается переменной quarter.
    quarter = GetQuarterByCoords(x, y);
}
catch(Exception exc)
{
    Console.WriteLine($"ОШИБКА! {exc.Message}");
    return; // Завершение программы в случае ошибки
}
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
Console.WriteLine($"Номер четверти: {quarter}");
#endregion --- 03. Output operations ---
// -------------------------- Конец программы ----------------------------------


// -------------------------Определение методов ---------------------------------
// Определяем функцию, выполняющую ввод целого числа с консоли
static int GetNumberFromUser(string message, string errorMessage)
{   
    while(true)
    {
        try
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine() ?? "");            
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{errorMessage} {exc.Message}");        
        }
    }
}

// Определяем функцию, принимающую два аргумента (координаты точки x и y)
// и возвращающую номер четверти плоскости, в которой находится эта точка
// В случае попадания точки на оси координат генерируется исключение
static int GetQuarterByCoords(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    else if(x < 0 && y > 0)
        return 2;
    else if(x < 0 && y < 0)
        return 3;
    else if(x > 0 && y < 0)
        return 4;
    else
        throw new Exception("Точка попадает на оси координат!");
}
// ---------------------- Конец определения методов ----------------------------
