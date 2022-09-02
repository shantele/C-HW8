// Задача 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array3D = new int[2, 2, 2];

for (int i = 0; i < array3D.GetLength(0); i++)
{
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
        for (int k = 0; k < array3D.GetLength(2); k++)
        {
            int temp = new Random().Next(10, 100);
            if (CheckUnique(array3D, temp))
            {
                array3D[i, j, k] = temp;
            }
            else
            {
                k--;
            }
        }
    }
}

bool CheckUnique(int[,,] cube, int number)  // проверка на уникальность
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                if (cube[i, j, k] == number) return false;
            }
        }
    }
    return true;
}

void PrintCube(int[,,] cubeToPrint)
{
    for (int i = 0; i < cubeToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < cubeToPrint.GetLength(1); j++)
        {
            for (int k = 0; k < cubeToPrint.GetLength(2); k++)
            {
                if (i == 0 && k == 0) Console.Write($"{cubeToPrint[i, j, k]} ({i},{j},{k})" + "\t");
                if (i == 1 && k == 0) Console.Write($"{cubeToPrint[i, j, k]} ({i},{j},{k})" + "\t");
                if (i == 0 && k == 1) Console.Write($"{cubeToPrint[i, j, k]} ({i},{j},{k})" + "\t");
                if (i == 1 && k == 1) Console.Write($"{cubeToPrint[i, j, k]} ({i},{j},{k})" + "\t");
            }
            Console.WriteLine();
        }
    }
}

PrintCube(array3D);