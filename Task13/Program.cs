// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = GetThirdDigit(number);

if (thirdDigit != -1)
{
Console.WriteLine($"Третья цифра числа: {thirdDigit}");
}
else
{
Console.WriteLine("Третьей цифры нет");
}
    

int GetThirdDigit(int number)
    {
    int absoluteNumber = Math.Abs(number);

    if (absoluteNumber >= 100)
    {
        int thirdDigit = (absoluteNumber / 100) % 10;
        return thirdDigit;
    }
    return -1;
    }
