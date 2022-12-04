// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

int m = GetNumberFromUser("Введите число строк в массиве: ", "Ошибка ввода!");
int n = GetNumberFromUser("Введите число столбцов в массиве: ", "Ошибка ввода!");

double[,] array = GetArray(m, n, -10, 10);
PrintArray(array);


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

double[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] arr = new double[rows, columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
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