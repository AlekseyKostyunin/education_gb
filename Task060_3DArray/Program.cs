/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.Clear();

Console.Write("Введите количество строк массива: ");
int x = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int y = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите размер трехмерного массива: ");
int z = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();

if(x * y * z <= 99-9) 
{
    int[,,] array = GetArray3D(x, y, z);
    PrintElementArray3D(array);
}
else Console.WriteLine("Не хватает уникальных двузначных значений для массива. Уменьшите размер массива.");

void PrintElementArray3D(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.WriteLine($"{inArray[i, j, k]}({i}, {j}, {k})");
            }
        }
        Console.WriteLine();
    }
}

int[,,] GetArray3D(int X, int Y, int Z)
{
    int minValue = 10;
    int[,,] result = new int[X, Y, Z];
    for (int i = 0; i < X; i++)
    {
        for (int j = 0; j < Y; j++)
        {
            for (int k = 0; k < Z; k++)
            {
                result[i, j, k] = minValue;
                minValue++;
            }
        }
    }
    return result;
}