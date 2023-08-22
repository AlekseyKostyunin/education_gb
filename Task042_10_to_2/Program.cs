/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

Console.Clear();

int a = 100;
int[] result = Get2(a);
Console.Write($"{a} -> ");
Console.WriteLine(String.Join("", result));

int[] Get2(int number)
{
    int temp = number;
    int count = 0;
    while(temp > 0)
    {
        temp = temp / 2;
        count++;
    }
    int[] array = new int [count];
    int i = array.Length - 1;
    while(number > 0)
    {
        array[i] = number % 2;
        number = number / 2;
        i--;
    }
    return array;
}