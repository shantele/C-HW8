// Задача 62. Напишите программу, которая 
// заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 4, m = 4;
int[,] matrix = new int[n, m];

int row = 0;
int column = 0;
int directionX = 1;
int directionY = 0;
int directionChange = 0;
int border = m;

for (int i = 0; i < matrix.Length; i++)
{
    matrix[row, column] = i + 1;
    if (--border == 0)
    {
        border = m * (directionChange % 2) + n * ((directionChange + 1) % 2) - (directionChange / 2 - 1) - 2;
        int temp = directionX;    // для поворота по часовой стрелке
        directionX = -directionY;
        directionY = temp;
        directionChange++;
    }
    column += directionX;
    row += directionY;
}

void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            if (inputMatrix[i, j] < 10) Console.Write("0" + inputMatrix[i, j] + "  ");
            else Console.Write(inputMatrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

PrintArray(matrix);