// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int GetNaturalNumber()
{
    while (true)
    {
        int number;
        if (int.TryParse(Console.ReadLine(), out number) && number > 0)
        {
            return number;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите натуральное число:");
        }
    }
}

void NaturalNumbers(int num) // 5
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);
}

Console.WriteLine("Введите натуральное число:");
int number = GetNaturalNumber();

Console.WriteLine($"Натуральные числа от {number} до 1:");
NaturalNumbers(number);