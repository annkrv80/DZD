//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);
int[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);
Console.Write("Введите номер строки элемента: ");
int r = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите номер столбца элемента: ");
int c = int.Parse(Console.ReadLine() ?? "");
FindElements(array, r, c);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
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

void FindElements(int[,] inArray, int m, int n)
{
    if (m < 0 | m > array.GetLength(0) - 1 | n < 0 | n > array.GetLength(1) - 1)
    {
        Console.WriteLine("Элемента массива с заданным индексом не существует");
    }
    else
    {
        Console.WriteLine($"Значение элемента массива с индексом {m}{n} = {array[m, n]}");
    }


}