// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int[,] array = GetArray(3, 4, -10, 10);
PrintArray(array);

int rows = GetNumberFromUser("Введите индекс строки в массиве: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Введите индекс столбца в массиве: ", "Ошибка ввода!");

if(rows < array.GetLength(0) && columns < array.GetLength(1))
Console.WriteLine($"{rows}, {columns} -> {array[rows, columns]}");
else
Console.WriteLine($"{rows}, {columns} -> такого числа в массиве нет");


int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userInput))
            return userInput;
        else
            Console.WriteLine(errorMessage);
    }
}

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}