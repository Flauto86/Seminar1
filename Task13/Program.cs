// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Задачу мне решил  ChatGPT, я не понял как это решается, туплю над ней дальше

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int absoluteNumber = number >= 0 ? number : -number; // Получаем абсолютное значение числа
int digitCount = 0;
int temp = absoluteNumber;

// Считаем количество цифр в числе
while (temp > 0)
{
    temp = temp / 10;
    digitCount++;
}

if (digitCount >= 3)
{
    // Ищем третью цифру слева
    int divisor = 1;
    for (int i = 1; i < digitCount - 2; i++)
    {
        divisor *= 10;
    }

    int thirdDigit = (absoluteNumber / divisor) % 10;
    Console.WriteLine($"Третья цифра числа: {thirdDigit}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}