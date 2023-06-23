// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int EnterNonNegativeNumber(string message)
{
    Console.Write(message);
    int number;
    while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
    {
        Console.Write("Некорректный ввод. Введите неотрицательное число:");
    }
    return number;
}

int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;

    if (m > 0 && n == 0)
        return AckermannFunction(m - 1, 1);

    if (m > 0 && n > 0)
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));

    return -1; // Обработка некорректных входных данных
}


int m = EnterNonNegativeNumber("Введите число m: ");
int n = EnterNonNegativeNumber("Введите число n: ");

int result = AckermannFunction(m, n);

Console.WriteLine($"A({m}, {n}) = {result}");