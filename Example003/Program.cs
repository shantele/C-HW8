// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}

int[,] matrixA = FillArray(2, 2);
int[,] matrixB = FillArray(2, 2);

void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "  ");

        }
        Console.WriteLine();
    }
}

Console.WriteLine("Первая матрица: ");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
PrintArray(matrixB);

int[,] matrixProduct = new int[2, 2];

matrixProduct[0, 0] = matrixA[0, 0] * matrixB[0, 0] + matrixA[0, 1] * matrixB[1, 0];
matrixProduct[0, 1] = matrixA[0, 0] * matrixB[0, 1] + matrixA[0, 1] * matrixB[1, 1];
matrixProduct[1, 0] = matrixA[1, 0] * matrixB[0, 0] + matrixA[1, 1] * matrixB[1, 0];
matrixProduct[1, 1] = matrixA[1, 0] * matrixB[0, 1] + matrixA[1, 1] * matrixB[1, 1];

Console.WriteLine();
Console.WriteLine("Произведение двух матриц: ");
PrintArray(matrixProduct);