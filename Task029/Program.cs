// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();

int [] array = new int [8];

for (int i=0; i<8; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:\t");
    array[i]=int.Parse(Console.ReadLine());
}
Console.WriteLine("Вывод масcива");
for (int i=0; i<8; i++)
{
    Console.WriteLine(array[i]);
    
}