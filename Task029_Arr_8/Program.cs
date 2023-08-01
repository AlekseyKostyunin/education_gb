/*Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
*/

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

int [] arr = new int[8];
for (int i = 0; i < 8; i++)
{
    arr[i] = GetNumberFromUser($"Введите значение элеманта массива под № {i}: ", "Ошибка! Введите целое число.");
}

PrintArr(arr);

