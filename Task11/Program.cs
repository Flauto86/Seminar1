﻿// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000);
int deleteSecondDigit = DeleteSecondDigit(number);
Console.WriteLine($"Трехзначное число - {number} -> {deleteSecondDigit}");

int DeleteSecondDigit(int num)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    return firstDigit * 10 + secondDigit;
}