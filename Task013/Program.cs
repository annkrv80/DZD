Console.Clear();

int num = new Random().Next(0, 100000);
int a1;
int a2;
int a3;

if (num > 0 && num <= 99)
{
    Console.WriteLine(num);
    Console.WriteLine("Третьей цифры нет");
}

if (num >= 100 && num < 1000)
{
    a1 = num % 10;

    Console.WriteLine(num);
    Console.WriteLine(a1);
}

if (num >= 1000 && num < 10000)
{
    a1 = num / 10;
    a2 = a1 % 10;

    Console.WriteLine(num);
    Console.WriteLine(a2);

}

if (num >= 10000 && num < 100000)
{
    a1 = num / 100;
    a2 = a1 % 10;

    Console.WriteLine(num);
    Console.WriteLine(a2);

}

