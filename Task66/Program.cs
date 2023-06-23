// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int EnterNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int num1, int num2)
{
    if (num1 == num2)
        return num1;

    if (num1 > num2)
        return SumNumbers(num2, num1);

    return num1 + SumNumbers(num1 + 1, num2);
}
    int number1 = EnterNumber("Введите число M: ");
    int number2 = EnterNumber("Введите число N: ");

    int sum = SumNumbers(number1, number2);

    Console.WriteLine($"Сумма натуральных чисел от {number1} до {number2}: {sum}");