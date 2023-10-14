/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 --> 243 (
2, 4 --> 16
*/

Console.Clear();

int a = GetNumberFromUser("Введите основание: ", "Ошибка! Введите целое число.");
int b = GetNumberFromUser("Введите показатель степени: ", "Ошибка! Введите целое число.");

if(Validate(b))
{
    Console.Write($"Число {a} в степени {b} -> {GetStepen(a, b)}");
}

bool Validate(int Stepen)
{
    if(Stepen < 0)
    {
        Console.Write("Число не должно быть меньше нуля. Запустите программу снова.");
        return false;
    }
    return true;
}

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
