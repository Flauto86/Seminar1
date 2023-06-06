// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Метод. Задаем массив заполненный случайными числами,
// куда можем передать размер массива и его диапазон.
int[] CreateArrayRndInt(int size, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

// Метод. Печать массива в консоль
void PrintArray(int[] arr)
{
    Console.WriteLine("");
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

int SumOddNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}


int[] array = CreateArrayRndInt(10, -50, 50);
PrintArray(array);

int sumOddNumbers = SumOddNumbers(array);
Console.WriteLine($"Cумму элементов, стоящих на нечётных позициях: {sumOddNumbers}");