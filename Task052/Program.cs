// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();

Console.Write("Введите число строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 50);
PrintArray(array);
Console.WriteLine();
FindArithmeticMean(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
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

void FindArithmeticMean(int[,] inArray)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double sum = 0;
        double meanSum = 0;

        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
            meanSum = sum / inArray.GetLength(0);
        }

        Console.Write($"{meanSum.ToString("F1")}\t");
    }

}

