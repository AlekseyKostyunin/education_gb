/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

Console.Clear();

// Ввод данных
int ax = GetNumberFromUser("Введите координату Х точки А: ", "Ошибка ввода данных!");
int ay = GetNumberFromUser("Введите координату Y точки А: ", "Ошибка ввода данных!");
int bx = GetNumberFromUser("Введите координату Х точки B: ", "Ошибка ввода данных!");
int by = GetNumberFromUser("Введите координату Y точки B: ", "Ошибка ввода данных!");

// Решение
double distance; // переменная результат вычисления расстояния между двумя точками
    try
    {
        distance = GetDistanceByCoords(ax, ay, bx, by);
    }
    catch(Exception exc)
    {
        Console.WriteLine($"ОШИБКА! {exc.Message}");
        return;
    }

// Вывод результата работы программы
Console.WriteLine($"Расстояние между точкой A с координатами ({ax},{ay}) и точкой B с координатами ({bx},{by}) равно {distance}.");

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

// 02. Вычисление расстояния по формуле: квадратный корень из ((BX-AX)*(BX-AX) + (BY-AY)*(BY-AY))
static double GetDistanceByCoords(int AX, int AY, int BX, int BY)
{
    return Math.Sqrt((BX-AX)*(BX-AX) + (BY-AY)*(BY-AY));
}