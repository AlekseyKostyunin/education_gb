/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.Clear();

int[] array = new int[5] {6, 7, 19, 345, 3};

int a = GetNumberFromUser("Введите число: ", "Ошибка! Введите целое число.");

Console.WriteLine($"{a}: Массив: {String.Join(" ", array)} -> {result}");

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