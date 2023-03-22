// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
/*
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
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
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);

int[,] newMatrix = matrix;
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        for (int k = j+1; k < column; k++)
        {
            int temp = 0;
            if (newMatrix[i, j] < newMatrix[i, k])
            {
                temp = newMatrix[i, j];
                newMatrix[i, j] = newMatrix[i, k];
                newMatrix[i, k] = temp;
            }
        }
    }
}
Console.WriteLine();
PrintMatrix(newMatrix);
*/

// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
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
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);

int[] summa = new int[row];
for (int m = 0; m < row; m++)
{
    for (int n = 0; n < column; n++)
    {
        summa[m] += matrix[m, n];

    }
}
int minSumma = summa[0];
int min = 0;
for (int k = 0; k < row; k++)
{
    if (summa[k] < minSumma)
    {
        minSumma = summa[k];
        min = k;
    }
}
Console.WriteLine($"минимальная сумма элементов {minSumma} в строке {min + 1}");
*/

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
int[,,] FillMatrixWithRandom(int row, int column, int list)
{
    int[,,] matrix = new int[row, column, list];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLongLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(0, 10);
            }
        }

    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLongLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k}) \t");
            }
            Console.WriteLine();
        }
        
    }
}

Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во листов: ");
int list = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = FillMatrixWithRandom(row, column, list);
PrintMatrix(matrix);
*/

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

