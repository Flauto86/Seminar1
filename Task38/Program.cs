// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateArrayRndDouble(int size, int min, int max, int round = 2)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, round);
    }

    return arr;
}

void PrintArrayDouble(double[] arr, string sep = ";")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.WriteLine($"{arr[i]}");
    }
}

double FindMaxMinDifference(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        if (arr[i] < min)
            min = arr[i];
    }

    return max - min;
}


double[] array = CreateArrayRndDouble(5, 1, 100, 2); // создаем массив вещественных чисел
PrintArrayDouble(array); // выводим в консоль этот массив

double diff = FindMaxMinDifference(array); // находим разницу между максимальным и минимальным элементами массива
Console.WriteLine($"Разница между максимальным и минимальным элементами: {Math.Round(diff, 2)}");