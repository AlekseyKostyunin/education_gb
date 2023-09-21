/*Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

Console.Clear();

int n = GetNumberFromUser("Введите количество элементов массива: ", "Ошибка! Введите целое число.");
string[] array = GetArrayString(n);

string[] newArray = GetArrayElementLenghtMin3(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", newArray)}]");

string[] GetArrayElementLenghtMin3(string[] inArray){
    int count = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if(inArray[i].Length <= 3) count++;
    }
    
    string[] newArr = new string[count];

    int j = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if(inArray[i].Length <= 3) {
            newArr[j] = inArray[i];
            j++;
        }
    } 
    return newArr;
}

string[] GetArrayString(int size){
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = Console.ReadLine() ?? "";
    }
    return array;
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

