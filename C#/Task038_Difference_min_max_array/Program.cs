/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным
элементов массива.
[3 7 22 2 78] --> 76
*/
Console.Clear();

double[] array = GetArray(6);
Console.WriteLine(String.Join(" ", array));

double dif = GetDifMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {dif}");

double [] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * 10;
    }
    return res;
}

// Вычисляем разницу между максимальным и минимальным элементом массива
double GetDifMaxMin(double[] arr)
{
    double max = GetMaxArray(arr);
    double min = GetMinArray(arr);
    return max - min;
}

// Определяем максимальный элемент
double GetMaxArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

// Определяем минимальный элемент
double GetMinArray(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}