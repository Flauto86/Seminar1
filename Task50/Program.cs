// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // rows = 3, columns = 4
{
    //                        0      1
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}

void ReadMatrixPosition(out int row, out int column)
{
    Console.Write("Введите номер строки: ");
    row = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите номер столбца: ");
    column = Convert.ToInt32(Console.ReadLine());
}

int GetMatrixElement(int[,] matrix, int row, int column)
{
    if (row < 0 || row >= matrix.GetLength(0) || column < 0 || column >= matrix.GetLength(1))
    {
        return -1; // указание, что такого элемента нет
    }

    return matrix[row, column];
}

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matrix);

int row, column;
ReadMatrixPosition(out row, out column);

int value = GetMatrixElement(matrix, row, column);
if (value != -1)
{
    Console.WriteLine($"Значение элемента: {value}");
}
else
{
    Console.WriteLine("Такого элемента нет.");
}