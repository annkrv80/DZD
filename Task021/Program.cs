/*Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 3D пространстве.*/

Console.Clear();

int x1 = 0;
int y1 = 0;
int z1 = 0;
int x2 = 0;
int y2 = 0;
int z2 = 0;

double R = 0;

try
{
    Console.Write("Введите x1 ");
    x1 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите y1 ");
    y1 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите z1 ");
    z1 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите x2 ");
    x2 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите y2 ");
    y2 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите z2 ");
    z2 = int.Parse(Console.ReadLine() ?? "");

}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка ввода данных {exc.Message}");
    return;
}

R = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));

Console.WriteLine(R - R % 0.01);


