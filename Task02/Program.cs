// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое целое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите первое целое число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a > b)
// {
//     Console.WriteLine($"число {a} больше, а число {b} меньше.");
// }
//     else if (a < b)
//     {
//         Console.WriteLine($"число {b} больше, а число {a} меньше.");
//     }
// else
// {
//     Console.WriteLine("Оба числа одинаковые");
// }


Console.Write("Введите первое целое число: ");
int a;
while (!int.TryParse(Console.ReadLine(), out a))
{
    Console.Write("Некорректный ввод. Пожалуйста, введите первое целое число: ");
}

Console.Write("Введите второе целое число: ");
int b;
while (!int.TryParse(Console.ReadLine(), out b))
{
    Console.Write("Некорректный ввод. Пожалуйста, введите первое целое число: ");
}

if (a > b)
{
    Console.WriteLine($"число {a} больше, а число {b} меньше.");
}
    else if (a < b)
    {
        Console.WriteLine($"число {b} больше, а число {a} меньше.");
    }
else
{
    Console.WriteLine("Оба числа одинаковые");
}
