// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = GetNumberFromUser("Введите целое число m: ", "Ошибка ввода");
int n = GetNumberFromUser("Введите целое число n: ", "Ошибка ввода");
if (m >= 0 & n >= 0)
{
    FunctionAckerman(m, n);
    Console.WriteLine($" A(m,n)={FunctionAckerman(m, n)}");
}
else
{
    Console.WriteLine("Ошибка ввода! Введите неотрицательное число!");
}



int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }

}

int FunctionAckerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return FunctionAckerman(m - 1, 1);

    else return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
}


