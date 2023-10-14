/*
Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/
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

string OutSector (int number)
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
string mes = OutSector(numberN);
Console.WriteLine(mes);
