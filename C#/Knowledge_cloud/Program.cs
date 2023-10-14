/* Задача № 7
Console.WriteLine("Введите число ");
string userInput1 = Console.ReadLine() ?? ""; 
int a = int.Parse(userInput1); 
int i = a % 10;
Console.Write($"{a} -> {i}");
*/

// void - метод не возвращает значения, в нем нет оператора "вернуть" return
// Console.Clear();
//int [] array = {1,2,3,4,5,6,7,8,9};
//int n = array.Length;
//collection[index] = new Random().Next(1, 10);

/*
Циклический ввод переменной типа double
double varA;
while (true)
{
    Console.Write("Введите А: ");
        if (double.TryParse(Console.ReadLine(), out varA))
            break;
    Console.WriteLine("Ошибка ввода!");
}

Console.WriteLine($"A={varA}");
*/

/* Задача № 11
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
/*
int num = new Random().Next(100, 1000);
int a1 = num / 100; // получаем первую цифру
int a2 = num % 10; // получаем последнюю цифру
int a3 = a1 * 10 + a2; // 

Console.WriteLine($"{num} -> {a3}");
*/
/*Задача № 12
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не 
кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/
/*
Console.WriteLine("Введите первое число ");
string userInput1 = Console.ReadLine() ?? ""; 
int a = int.Parse(userInput1); 

Console.WriteLine("Введите второе число ");
string userInput2 = Console.ReadLine() ?? ""; 
int b = int.Parse(userInput2);

if (a % b == 0)
{
    Console.WriteLine($"{a}, {b} -> кратно");
}
else 
{
    Console.WriteLine($"{a}, {b} -> не кратно, остаток {a % b}");
}
*/

/*
Задача № 14. Напишите программу, которая принимает на вход число 
и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/
/*
Console.WriteLine("Введите число ");
string userInput1 = Console.ReadLine() ?? ""; 
int a = int.Parse(userInput1); 

if (a % 7 == 0 && a % 23 == 0) 
{
    Console.WriteLine($"{a} -> да");
}
else 
{
    Console.WriteLine($"{a} -> нет");
}
*/

/* 
Задача № 16. Напишите программу, которая принимает на вход два числа 
и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет 
*/
/*
Console.WriteLine("Введите первое число ");
string userInput1 = Console.ReadLine() ?? ""; 
int a = int.Parse(userInput1); 

Console.WriteLine("Введите второе число ");
string userInput2 = Console.ReadLine() ?? ""; 
int b = int.Parse(userInput2);

if (b == a*a || a == b*b)
{
    Console.WriteLine($"{a}, {b} -> да");
}
else 
{
    Console.WriteLine($"{a}, {b} -> нет");
}
*/


/* Задача № 17 */
/*
Console.Clear();

int X, Y;

try
{
    Console.Write("Введите Х: ");
    X = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите Y: ");
    Y = int.Parse(Console.ReadLine() ?? "");
}
catch(Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
    return;
}

if(X > 0 && Y > 0)
{
    Console.WriteLine("1");
}
else if(X < 0 && Y > 0)
{
    Console.WriteLine("2");
}
else if(X < 0 && Y < 0)
{
    Console.WriteLine("3");
}
else if(X > 0 && Y < 0)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("Ошибка! Точка попадает на оси координат!");
}
*/

/*
int InputNumber(string message, string errorMessage)
{
    while(true)
    {
        try{
            Console.Write(message);
            int a = int.Parse(Console.ReadLine() ?? "");
            return a;
        }
        catch
        {
            Console.WriteLine(errorMessage);
        }
    }
}

string OutN (int number)
{
    if(number == 1)
    {
        return "X > 0, Y > 0";
    }
    else if(number == 2)
    {
         return "X < 0, Y > 0";
    }
    else if(number == 3)
    {
        return "X < 0, Y < 0";
    }
    else if(number == 4)
    {
        return "X > 0, Y < 0";
    }
    else
    {
        return "Ошибка! Введите корректный номер четверти";
    }
}

int numberN = InputNumber("Введите номер четверти: ", "Ошибка! Некорректный номер");
string mes = OutN(numberN);
Console.WriteLine(mes);

*/
/*
//A (3,6); B (2,1) -> 5,09 
Console.WriteLine( 
    Math.Round(
        Math.Sqrt((3-2)*(3-2) + (6-1)*(6-1)),
        2
    )
);
*/
/*
static string GetSquareFrom1ToN(int N)
{
    string list = "";
    
    int i = 1;
    while(i <= N)
    {
        list = list + i*i;
        i++;
    }

    return list;
}

Console.WriteLine(GetSquareFrom1ToN(3));*/
/*
int N = 12345;
Console.WriteLine(N / 1000 % 10);
*/
//N / 10000 == N % 10 && N / 1000 == N % 100 / 10


/*
Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int sumNumbers = GetSumNumbers(num);
Console.WriteLine($"{num} -> {sumNumbers}");

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

int GetSumNumbers(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
}
*/

/*
Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int count = GetCountDigits(num);
Console.WriteLine($"{num} -> {count}");

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

int GetCountDigits(int num)
{
    int count = 0;
    while(num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}
*/

/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

/*
Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int proiz = GetProiz(num);
Console.WriteLine($"{num} -> {proiz}");

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

int GetProiz(int n)
{
    int proiz = 1;
    int i = 1;
    while(i <= n)
    {
        proiz = proiz*i;
        i++;
    }
    return proiz;
}

*/
/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
12
*/

//int[] arr = new int[8];
/*
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
*/

/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 --> 243 (
2, 4 --> 16
*/
/*
Console.Clear();

int a = GetNumberFromUser("Введите первое число: ", "Ошибка! Введите целое число.");
int b = GetNumberFromUser("Введите второе число: ", "Ошибка! Введите целое число.");
int result = GetStepen(a, b);

Console.Write($"{a}, {b} -> {result}");

int GetStepen(int A, int B)
{
    int result = A;
    for (int i = 0; i < B-1; i++)
    {
        result = result * A;
    }
    return result;
}

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

*/
/* 
Задача 31:
Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [ 9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве 
[3,9,8,1,0, 7,2, 1,8, 3, 1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
20.
*/

// Цикл фор нужно использовать, если мы хотим менять значения массива
// Цикл foreach нужно использовать если мы хотим последовательно перебрать
// и прочитать каждый элемент массива
/*
Console.Clear();

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

int positiveSum = GetPositiveSum(array);
int negativeSum = GetNegativeSum(array);

Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} ");

int [] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetPositiveSum(int[] arr)
{
    int positiveSum = 0;
    foreach (int el in arr)
    {
        if (el > 0) positiveSum += el;
    }
    return positiveSum;
}

int GetNegativeSum(int[] arr)
{
    int negativeSum = 0;
    foreach (int el in arr)
    {
        negativeSum += el < 0 ? el : 0;
    }
    return negativeSum;
}
*/
/*
Задача 32: Напишите программу замены элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[4, 8, 8, 2] --> [4, 8, 8, 2]
*/
/*
Console.Clear();

int [] array = GetArray(4, -10, 10);
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
*/

/*
Задача 33:
Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3]--> нет
3; массив [6, 7, 19, 345, 3] --> да
*/
/*
Console.Clear();

int[] array = new int[5] {6, 7, 19, 345, 3};

int a = GetNumberFromUser("Введите число: ", "Ошибка! Введите целое число.");
bool result = FindNumber(a, array); 

Console.WriteLine($"{a}: массив {String.Join(" ", array)} -> {(result ? "да" : "нет")}");

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

bool FindNumber(int a, int[] array)
{
    foreach (int el in array)
    {
        if (el == a) return true;
    }
    return false;
} 
*/

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
/*
Console.Clear();

int [] array = GetArray(12, 1, 200);
Console.WriteLine(String.Join(" ", array));

int count = GetCount(array);
Console.WriteLine($"количество элементов: {count}");

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
*/

/*
Задача 37:
Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5]--> 5 8 3
[6 7 3 6]--> 36 21
*/
/*
Console.Clear();

int[] array = new int[5] {1, 2, 3, 4, 5};
Console.WriteLine(String.Join(" ", array));

int[] arrnew = GetSumPar(array);
Console.WriteLine(String.Join(" ", arrnew));

int[] GetSumPar(int[] array)
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
*/

// Напишите программу, которая перевернет одномерный массив
// последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

int[] reversArray = ReversArray1(array);
Console.WriteLine(String.Join(" ", reversArray));

ReversArray2(array);
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

int[] ReversArray1(int[] inArray) 
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}

void ReversArray2(int[] inArray) 
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = k;
    }
}
*/

/*
Задача 40: Напишите программу, которая принимает на вход три числа и 
проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
суммы двух других сторон.
*/
/*
Console.Clear();

int a = GetNumberFromUser("Введите длину первой стороны: ", "Ошибка! Введите целое число.");
int b = GetNumberFromUser("Введите длину второй стороны: ", "Ошибка! Введите целое число.");
int c = GetNumberFromUser("Введите длину третьей стороны: ", "Ошибка! Введите целое число.");

bool result = Proverka(a, b, c);

Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} -> {(result ? "существует" : "не существует")} ");

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

bool Proverka(int A, int B, int C)
{
    if (A < B + C) 
    {
        if (B < A + C)
        {
            if (C < B + A)
            {
                return true;
            }
        }
    }
    return false;
}
*/

/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/
/*
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
*/

/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
/*
Console.Clear();
int n = GetNumberFromUser("Введите число N больше 2: ", "Ошибка!");
int[] result = GetN(n);
Console.Write($"Если {n} -> ");
Console.WriteLine(String.Join(" ", result));

int[] GetN(int n)
{
    int[] res = new int[n];
    res[0] = 0;
    res[1] = 1;
    for (int i = 2; i < res.Length; i++)
    {
        res[i] = res[i-1] + res[i-2];
    } 
    return res;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect && userNumber > 2)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
*/

/*
Задача 46:
Задайте двумерный массив размером m × n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/
/*
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);

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
*/

/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A ij = i + j .
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */
/*
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
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
*/

/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их
квадраты.
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/
/*
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);

Console.WriteLine();

GetNewArray(array);
PrintArray(array);

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

void GetNewArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if(i % 2 != 0 && j % 2 != 0)  inArray[i, j] = inArray[i, j] * inArray[i, j];
        }
    }
}
*/

/* Задача 51: Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д
Например , задан
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
/*
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);

Console.WriteLine();

int sum = GetSumDiagonal(array);
Console.Write($"Сумма элементов главной диагонали: {sum}");

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

int GetSumDiagonal(int[,] inArray)
{
    int sum = 0;
    int rows = inArray.GetLength(0);
    int colums = inArray.GetLength(1);
    
    int min = (rows < colums) ? rows : colums;

    for (int i = 0; i < min; i++)
    {
        sum += inArray[i, i];
    }
    return sum;
}
*/

/* Задача 47: Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();

double[,] array = GetArray(rows, colums);
PrintArray(array);

Console.WriteLine();

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * 100 - 50;
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}
*/

/* Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку массива.
*/
/*
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);

Console.WriteLine();

ReplaceStrings(array);
PrintArray(array);

void ReplaceStrings(int[,] inArray)
{
    int lastRow = inArray.GetLength(0) - 1; // индекс последней строки
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        int temp = inArray[0, j];
        inArray[0, j] = inArray[lastRow, j];
        inArray[lastRow, j] = temp;
    }
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
*/

/* Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
*/
/*
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);

Console.WriteLine();

if (rows == colums)
{
    int[,] newarray = Transpor(array, rows, colums);
    PrintArray(newarray);
}
else Console.WriteLine("Невозможно преобразовать!");

int[,] Transpor(int[,] inArray, int Rows, int Colums)
{
    int[,] newarray = new int[Rows, Colums];
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Colums; j++)
        {
            newarray[i,j] = inArray[j,i];
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
*/
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
/*
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
*/