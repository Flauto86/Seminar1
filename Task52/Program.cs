// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] CalculateColumnAverages(int[,] matrix)
{
    int rows = matrix.GetLength(0); // мне так понятнее, а то путаюсь
    int columns = matrix.GetLength(1); // мне так понятнее, а то путаюсь
    double[] columnAverages = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += matrix[i, j];
        }
        columnAverages[j] = sum / rows;
    }

    return columnAverages;
}

void PrintColumnAverages(double[] columnAverages)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < columnAverages.Length; i++)
    {
        Console.Write($"{Math.Round(columnAverages[i], 1)}");
        if (i < columnAverages.Length - 1)
        {
            Console.Write("; ");
        }
    }
    Console.WriteLine();
}

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matrix);

double[] columnAverages = CalculateColumnAverages(matrix);
PrintColumnAverages(columnAverages);