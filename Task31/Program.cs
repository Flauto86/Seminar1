// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] CreateArrayRndInt(int size, int min, int max) // метод, который создает
{                                                   // и заполняет массив случайнми
    int[] arr = new int[size];                      // числами в заданном диапазоне
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep = ",")    // вывод массива в консоль
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write ($"{arr[i]}{sep} ");
        else Console.Write ($"{arr[i]}");
    }
    
}

int[] GetSumPositiveNegativElen(int[] arr)      // сумма отрицательных и положительных элементов массива
{                                               // метод вывода через массив
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sumPositive += arr[i];
        else sumNegative += arr[i];
    }

    return new int[] {sumPositive , sumNegative};
}

int GetSumPositiveElen(int[] arr)               // сумма отрицательных и положительных элементов массива
{                                               // метод вывода через переменные
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }

    return sum;
}

int GetSumNegativeElen(int[] arr)               // сумма отрицательных и положительных элементов массива
{                                               // метод вывода через переменные
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    
    return sum;
}

int[] array = CreateArrayRndInt(12, -9, 9);     // печать массива
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

int[] sumPositiveNegativElen = GetSumPositiveNegativElen(array);        // метод вывода через массив
Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativElen[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativElen[1]}");

int sumPositiveElen = GetSumPositiveElen(array);                        // метод вывода через переменные
int sumNegativeElen = GetSumNegativeElen(array);
Console.WriteLine($"Сумма положительных элементов = {sumPositiveElen}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElen}");