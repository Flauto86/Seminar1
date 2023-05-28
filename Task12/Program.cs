// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int Remainder (int num1, int num2)
{
    int rem = num1 % num2;
    return rem;
}

Console.Write("Введие первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введие второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

int reminder = Remainder(firstDigit, secondDigit);
if (reminder == 0)
{
    Console.WriteLine($"Число {firstDigit} кратно числу {secondDigit}");
}
else
{
    Console.WriteLine($"Число {firstDigit} не кратно числу {secondDigit}. Остаток от деления - {reminder}");
}