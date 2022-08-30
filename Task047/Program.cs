// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
Console.Write("Введите число строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine() ?? "");

double[,] array = GetArray(rows, columns, -50, 50);
PrintArray(array);


double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue)) / 10;  
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}