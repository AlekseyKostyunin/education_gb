/*
Задача 33:
Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3]--> нет
3; массив [6, 7, 19, 345, 3] --> да
*/

Console.Clear();

int[] array = new int[5] {6, 7, 19, 345, 3};

int a = GetNumberFromUser("Введите число: ", "Ошибка! Введите целое число.");
bool result = FindNumber(a, array); 

Console.WriteLine($"{a}: массив {String.Join(" ", array)} -> {(result ? "да" : "нет")}");

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

bool FindNumber(int a, int[] array)
{
    foreach (int el in array)
    {
        if (el == a) return true;
    }
    return false;
}