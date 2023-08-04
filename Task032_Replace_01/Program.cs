/*
Задача 32: Напишите программу замены элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[4, 8, 8, 2] --> [4, 8, 8, 2]
*/

Console.Clear();

int [] array = GetArray(6, -10, 10);
Console.WriteLine(String.Join(" ", array));
Replace(array);
Console.WriteLine(String.Join(" ", array));

int [] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void Replace(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}