//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

Console.Write("Сколько всего цифр будет введено?  ");
int size = int.Parse(Console.ReadLine() ?? "");
int[] num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int positivNum = GetPositivNum(num);
PrintArray(num);
Console.WriteLine();
Console.Write($"количество чисел больше нуля {positivNum}.");



int[] GetNumberFromUser(string message, string errorMessage)
{
    int[] number = new int[size];
    for (int i = 0; i < size; i++)
    {
        while (true)
        {
            Console.Write(message);
            bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
            if (isCorrect)
                number[i] = userNumber;
            break;
            Console.WriteLine(errorMessage);
        }
    }
    return number;
}

int GetPositivNum(int[] number)
{
    int count = 0;
    foreach (int el in number)
    {
        if (el > 0) count++;
    }
    return count;
}

void PrintArray(int[] number)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{number[i]} ");
    }
}
