// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double[] array = GetArrayDouble(5);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(String.Join(" ", array));
double max = GetMax(array);
double min = GetMin(array);
double difference = max - min;
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write($"Разница между {max} и {min} равна {difference}");
Console.ResetColor();


double[] GetArrayDouble(double array)
{
    Console.Write("Введите число эллементов массива ");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble();
    }
    return res;
}

double GetMax(double[] array)
{
    double max = array[0];

    foreach (double el in array)
    {
        if (el > max) max = el;
    }
    return max;

}

double GetMin(double[] array)
{
    double min = array[0];

    foreach (double el in array)
    {
        if (el < min) min = el;
    }
    return min;
}

