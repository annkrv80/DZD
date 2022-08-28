// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

Console.Write("Введите число k1: ");
double k1 = double.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число b1: ");
double b1 = double.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число k2: ");
double k2 = double.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число b2: ");
double b2 = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Для нахождения точки пересечения прямых составим систему из уравнений этих прямых");
Console.WriteLine($" y = {k1} * x + {b1} ");
Console.WriteLine($" y = {k2} * x + {b2}");
GetPointIntersection(k1, b1, k2, b2);

void GetPointIntersection(double k1, double b1, double k2, double b2)
{
    if ((k1 == k2) && (b1 == b2))
    {
        Console.Write("Прямые совпадают");
    }

    else if (k1 == k2)
    {
        Console.Write("Прямые параллельны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);

        double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
        Console.Write($"Прямые пересекаются в точке с координатами x={x} y={y}");
    }

}
