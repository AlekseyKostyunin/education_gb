/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();

// Запрашиваем у пользователя значения b1, k1, b2 и k2
int b1 = GetNumberFromUser("Введите значение b1: ", "Ошибка!");
int b2 = GetNumberFromUser("Введите значение b2: ", "Ошибка!");
int k1 = GetNumberFromUser("Введите значение k1: ", "Ошибка!");
int k2 = GetNumberFromUser("Введите значение k2: ", "Ошибка!");

//int b1 = 2;
//int b2 = 4;
//int k1 = 5;
//int k2 = 9;

if (k1 == k2)
{
    Console.WriteLine("Прямые с такими параметрами паралельны");
}
else 
{
    double x = CoordinateX(b1, b2, k1, k2);
    double y = CoordinateY(b1, b2, k1, k2);

    // Выводим результат
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}

double CoordinateX(int B1, int B2, int K1, int K2)  // x = (b2 - b1) / (k1 - k2) // y = k1 * x + b1 // Convert.ToDouble(int)
{
    return (
        (Convert.ToDouble(B2)-Convert.ToDouble(B1))
        /
        (Convert.ToDouble(K1)-Convert.ToDouble(K2))
        );
}

double CoordinateY(int B1, int B2, int K1, int K2) // y = k1*(b2-b1)/(k1-k2) + b1
{
    return     Convert.ToDouble(K1) * ( Convert.ToDouble(B2) - Convert.ToDouble(B1) )
                /
                ( Convert.ToDouble(K1) - Convert.ToDouble(K2) )
                + Convert.ToDouble(B1)
            ; 
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