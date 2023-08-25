/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 7 --> такого элемента в массиве нет
*/

Console.Clear();

int[,] array = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

int m = GetNumberFromUser("Введите номер строки искомого элемента массива: ", "Ошибка! Введите целое число.");
int n = GetNumberFromUser("Введите номер столбца искомого элемента массива: ", "Ошибка! Введите целое число.");
Console.WriteLine();

if (m > array.GetLength(0) || n > array.GetLength(1)) Console.Write($"Элемента с индексами i={m}, j={n} -> нет в массиве.");
else 
{
    Console.WriteLine("Массив элементов для поиска: ");
    PrintArray(array);
    Console.WriteLine();
    int result = GetValue(array, m, n);
    Console.WriteLine($"Значение элемента массива с индексами i={m}, j={n} равно -> {result}");
}

int GetValue(int[,] inArray, int m, int n)
{
    return inArray[m, n];
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
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