// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Random random = new Random();
int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100); // Задайте диапазон псевдослучайных чисел по вашему усмотрению
}

PrintArray(array);


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}