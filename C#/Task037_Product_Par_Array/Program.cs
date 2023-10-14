/*
Задача 37:
Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5]--> 5 8 3
[6 7 3 6]--> 36 21
*/

Console.Clear();

int[] array = new int[4] {6, 7, 3, 6};
Console.WriteLine(String.Join(" ", array));

int[] arrnew = GetProductPar(array);
Console.WriteLine(String.Join(" ", arrnew));

int[] GetProductPar(int[] array)
{
    int s = array.Length / 2;
    int j = array.Length - 1;
    int[] arrnew = new int [s];
    for (int i = 0; i < s; i++)
    {
        arrnew[i] = array[i] * array[j];
        j--;
    }
    return arrnew;
}