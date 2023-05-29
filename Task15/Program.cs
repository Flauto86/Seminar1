// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели:");
int day;

while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 7)
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 7:");
}

bool isWeekend = IsWeekend(day);
if (isWeekend)
{
    Console.WriteLine("Да, это выходной день.");
}
else
{
    Console.WriteLine("Нет, это не выходной день.");
}

bool IsWeekend(int day)
{
    return day == 6 || day == 7;
}