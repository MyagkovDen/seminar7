// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int m = GetNumberFromUser("Введите число строк в массиве: ", "Ошибка ввода!");
int n = GetNumberFromUser("Введите число столбцов в массиве: ", "Ошибка ввода!");

int[,] array = GetArray(m, n, -10, 10);
PrintArray(array);

Console.Write("Среднее арифметическое каждого столбца: ");
GetSumNumbersInColumn(array);


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

void GetSumNumbersInColumn(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int sum = 0;
        int count = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
            count++;
        }
        double sumAverage = (double)sum / count;
        Console.Write($"{sumAverage}; ");
    }
}