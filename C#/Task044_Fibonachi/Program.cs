/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

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