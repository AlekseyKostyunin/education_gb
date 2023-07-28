/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27 
5 -> 1, 8, 27, 64, 125
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
        Console.Write($"{GetKubN(i)}, ");  
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
static int GetKubN(int N)
{
    return N*N*N;
}
