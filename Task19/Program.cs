// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (IsPalindrome(number))
{
    Console.WriteLine("Да, число является палиндромом.");
}
else
{
    Console.WriteLine("Нет, число не является палиндромом.");
}

bool IsPalindrome(int num)
{
    int temp = num;
    int reversedNumber = 0;

    while (temp > 0)
    {
        int remainder = temp % 10;
        reversedNumber = reversedNumber * 10 + remainder;
        temp /= 10;
    }

    return num == reversedNumber;
}
