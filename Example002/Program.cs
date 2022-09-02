// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = 4, columns = 4;

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(10);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

int[] sumArray = new int[matrix.GetLength(0)];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
        sumArray[i] = sum;
    }
}

// Console.WriteLine($"Суммы по строкам: {String.Join(" ", sumArray)}");

int index = 0, minIndex = 0;
int minSum = sumArray[index];

for (int i = 0; i < sumArray.Length; i++)
{
    if (sumArray[i] < minSum)
    {
        minSum = sumArray[i];
        minIndex = i;
    }
}

Console.WriteLine($"{minIndex + 1} строка");