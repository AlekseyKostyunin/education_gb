/*Задача 26:
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int count = GetCountDigits(num);
Console.WriteLine($"{num} -> {count}");

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

int GetCountDigits(int num)
{
    int count = 0;
    while(num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}