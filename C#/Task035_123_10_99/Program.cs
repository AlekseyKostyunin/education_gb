/*
Задача 35:
Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] --> 1
[1, 2, 3, 6, 2] --> 0
[10, 11, 12, 13, 14] --> 5
*/

int [] array = GetArray(12, 1, 200);
Console.WriteLine(String.Join(" ", array));

int count = GetCount(array);
Console.WriteLine($"Количество элементов: {count}");

int GetCount(int[] arr)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el > 10 && el < 100) count++;
    }
    return count;
}

int [] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
