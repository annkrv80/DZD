//Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

int num = new Random(). Next(1,8);

if(num==6 || num==7)
{
    Console.WriteLine($"{num} выходной день");
}
    
else
{
    Console.WriteLine($"{num} рабочий день");
}