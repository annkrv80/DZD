// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();

int[] array = new int[8];
int num;

void FillingArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t");
        string number=Console.ReadLine()??"";

        if(int.TryParse(number, out num))
        {
            array[i] = num;
        }
        else
        {
            Console.WriteLine ("Ошибка! Введите число!");
        }
    }
}

void PrintArray(int[] array)

{
    Console.WriteLine("Вывод масcива");
    
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

FillingArray(array);
PrintArray(array);