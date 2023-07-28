/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.Clear();

// Ввод данных
int n = GetNumberFromUser("Введите пятизначное число: ", "Ошибка! Нужно ввести пятизначное число");

// Решение
string relult;
try
{
    relult = PolidromN(n);    
}
catch(Exception exc)
{
    Console.WriteLine($"ОШИБКА! {exc.Message}");
    return;
}

Console.Write($"{n} -> {relult}");

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
            if (a < 10000 || a > 99999) 
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

// 02. Вычисление полидрома 5-ти значного числа
static string PolidromN(int N)
{
    //    1 цифра == 5 цифра      3 цифра    == 4 цифра числа  
    if (N / 10000 == N % 10 && N / 1000 % 10 == N % 100 / 10)
    {
        return "да";
    }
    else 
    { 
        return "нет";
    }
}

