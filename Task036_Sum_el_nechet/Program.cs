/*
Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12]--> 19
[4, 6, 89, 6] --> 0
*/

Console.Clear();

int [] array = GetArray(6, 1, 20);
Console.WriteLine(String.Join(" ", array));

int sum = GetSumOdd(array);
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях, равна: {sum}");

int GetSumOdd(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 == 1) sum += arr[i];
    }
    return sum;
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