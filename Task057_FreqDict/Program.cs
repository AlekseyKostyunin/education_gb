/*Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.
Набор данных Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
*/

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();

int minValue = 0;
int maxValue = 10;
int[,] array = GetArray(rows, colums, minValue, maxValue);
PrintArray(array);

Console.WriteLine();
int[,] newarray = FreqDict(array);

PrintArray(newarray);

int[,] FreqDict(int[,] inArray)
{
    int[,] newarray = new int[maxValue-minValue+1, 2 ];
    
    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        newarray[i,0] = minValue+i;
    }

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < newarray.GetLength(0); k++)
            {
                if (newarray[k,0] == inArray[i,j])
                newarray[k,1]  += 1;
            } 
        }
    }
    return newarray;
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

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}