/*
Задача 40: Напишите программу, которая принимает на вход три числа и 
проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
суммы двух других сторон.
*/

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
    if ((A < B + C) && (B < A + C) && (C < B + A)) return true;
    return false;
}