/*
Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.Clear();

// Ввод данных
int n = GetNumberFromUser("Введите положительное число N больше 1: ", "Ошибка! Нужно ввести положительное число больше 1");

// Решение
try
{
    Console.Write($"{n} -> ");
    int i = 1;
    while(i <= n)
    {
        Console.Write($"{GetSquareN(i)}, ");  
        i++; 
    }
}
catch(Exception exc)
{
    Console.WriteLine($"ОШИБКА! {exc.Message}");
    return;
}

// Методы

// 01. Прием целого числа от пользователя
static int GetNumberFromUser(string message, string errorMessage)
{   
    
    while(true)
    {
        try
        {
            Console.Write(message);
            int a = int.Parse(Console.ReadLine() ?? "");
            if (a < 1) 
            {
                Console.WriteLine($"{errorMessage}");
            }   
            else 
            {
                return a; 
            }
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{errorMessage} {exc.Message}");        
        }
    }
}

// 02. Вычисление квадрата числа
static int GetSquareN(int N)
{
    return N*N;
}
