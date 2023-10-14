/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

Console.Clear();

// Запрашиваем у пользователя число М
int m = GetNumberFromUser("Укажите количество вводимых чисел: ", "Ошибка! Введите целое число.");

// Получаем от пользователя M чисел и записываем их в массив
int[] array = GetArray(m);

// Считаем количество положительных чисел, введенных пользователем
int result = GetPositive(array);

// Выводим результат
Console.WriteLine($"В массиву: {String.Join(" ", array)} -> {result} элемента(ов) больше 0");

int[] GetArray(int n)
{
    int[] res = new int[n];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = GetNumberFromUser("Введите целое число: ", "Ошибка! Введите целое число.");
    }
    return res;
}

int GetPositive(int[] inArr)
{
    int count = 0;
    foreach (var item in inArr)
    {
        if (item > 0) count++;
    }
    return count;
}

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