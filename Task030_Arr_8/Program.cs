/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
12
*/

//int[] arr = new int[8];

Console.Clear();

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

int[] GenMassiv(int count, int min, int max) 
{
    int[] arr = new int[count];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max+1);
    }
    return arr;
}

void PrintArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length-1)
            Console.Write($"{array[i]}, ");
        else 
            Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int count = GetNumberFromUser("Введите количество элементов в массиве: ", "Ошибка! Введите целое число.");
int min = GetNumberFromUser("Введите минимальное значение: ", "Ошибка! Введите целое число.");
int max = GetNumberFromUser("Введите максимальное значение: ", "Ошибка! Введите целое число.");
int[] arr = GenMassiv(count, min, max);
PrintArr(arr);
