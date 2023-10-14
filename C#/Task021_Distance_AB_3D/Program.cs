/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

// Ввод данных
int ax = GetNumberFromUser("Введите координату Х точки А: ", "Ошибка ввода данных!");
int ay = GetNumberFromUser("Введите координату Y точки А: ", "Ошибка ввода данных!");
int az = GetNumberFromUser("Введите координату Z точки А: ", "Ошибка ввода данных!");
int bx = GetNumberFromUser("Введите координату Х точки B: ", "Ошибка ввода данных!");
int by = GetNumberFromUser("Введите координату Y точки B: ", "Ошибка ввода данных!");
int bz = GetNumberFromUser("Введите координату Z точки B: ", "Ошибка ввода данных!");

// Решение
double distance; // переменная результат вычисления расстояния между двумя точками
    try
    {
        distance = GetDistanceByCoords(ax, ay, az, bx, by, bz);
    }
    catch(Exception exc)
    {
        Console.WriteLine($"ОШИБКА! {exc.Message}");
        return;
    }

// Вывод результата работы программы
Console.WriteLine($"Расстояние между точкой A с координатами ({ax},{ay},{az}) и точкой B с координатами ({bx},{by},{bz}) равно {distance}.");

// Методы

// 01. Прием целого числа от пользователя
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

// 02. Вычисление расстояния по формуле: квадратный корень из ((BX-AX)*(BX-AX) + (BY-AY)*(BY-AY) + (BZ-AZ)*(BZ-AZ))
static double GetDistanceByCoords(int AX, int AY, int AZ, int BX, int BY, int BZ)
{
    return Math.Sqrt((BX-AX)*(BX-AX) + (BY-AY)*(BY-AY) + (BZ-AZ)*(BZ-AZ));
}
