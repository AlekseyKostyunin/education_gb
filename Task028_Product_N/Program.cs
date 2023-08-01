/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int proiz = GetProiz(num);
Console.WriteLine($"{num} -> {proiz}");

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetProiz(int n)
{
    int proiz = 1;
    int i = 1;
    while(i <= n)
    {
        proiz = proiz*i;
        i++;
    }
    return proiz;
}
