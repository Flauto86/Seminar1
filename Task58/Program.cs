// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

bool CanMultiplyMatrices(int[,] matrixA, int[,] matrixB)
{
    int columnsA = matrixA.GetLength(1);
    int rowsB = matrixB.GetLength(0);

    return columnsA == rowsB;
}

int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int columnsA = matrixA.GetLength(1);
    int columnsB = matrixB.GetLength(1);

    int[,] resultMatrix = new int[rowsA, columnsB];

    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < columnsB; j++)
        {
            int sum = 0;
            for (int k = 0; k < columnsA; k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }

    return resultMatrix;
}


int[,] matrixA = CreateMatrixRndInt(2, 2, 1, 5);
int[,] matrixB = CreateMatrixRndInt(2, 3, 1, 5);

Console.WriteLine("Матрица A:");
PrintMatrix(matrixA);

Console.WriteLine("Матрица B:");
PrintMatrix(matrixB);

if (CanMultiplyMatrices(matrixA, matrixB))
{
    int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);

    Console.WriteLine("Результирующая матрица:");
    PrintMatrix(resultMatrix);
}
else
{
    Console.WriteLine("Матрицы несовместимы для умножения.");
}

Console.ReadLine();
