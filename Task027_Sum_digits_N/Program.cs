/* Задача 27:
Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82-> 10
9012 -> 12
*/

Console.Clear();

int number = GetNumberFromUser("Введите число: ", "Ошибка! Введите целое число.");
int sumDigits = GetSumDigits(number);
Console.Write($"Сумма всех цифр в числе {number} равна: {sumDigits}");

int GetSumDigits(int N)
{
    int result = 0;
    while(N > 0)
    {
        result = result + N % 10;
        N = N / 10;
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
