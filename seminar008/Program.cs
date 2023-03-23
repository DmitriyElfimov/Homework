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

Console.WriteLine("Введите кол-во строк первой матрицы: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов первой матрицы: ");
int column1 = Convert.ToInt32(Console.ReadLine());
int[,] firstMatrix = FillMatrixWithRandom(row1, column1);
Console.WriteLine("Введите кол-во строк второй матрицы: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов второй матрицы: ");
int column2 = Convert.ToInt32(Console.ReadLine());
int[,] secondMatrix = FillMatrixWithRandom(row2, column2);
PrintMatrix(firstMatrix);
Console.WriteLine();
PrintMatrix(secondMatrix);
if (column1 == row2)
{
int [,] newMatrix = new int [row1, column2];
for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            for (int k = 0; k < column1; k++)
            {
                newMatrix[i,j] = newMatrix[i,j]+firstMatrix[i,k]*secondMatrix[k,j];
            } 
        }
        
    }
Console.WriteLine();
Console.WriteLine("Результат умножения:");    
PrintMatrix(newMatrix);
}
else Console.WriteLine("такие матрицы перемножать нельзя");
*/

// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
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

int min = matrix[0, 0];
int m = 0;
int n = 0;
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        if (matrix[i, j] < min)
        {
            min = matrix[i, j];
            m = i;
            n = j;
        }

    }
}
Console.WriteLine();
Console.WriteLine($"Минимальный элемент {min} - [{m}, {n}]");


int[,] newMatrix = new int[row - 1, column - 1];
int i1 = 0;
int j1 = 0;
for (int i = 0; i < row - 1; i++)
{
    for (int j = 0; j < column - 1; j++)
    {
        if (i >= m) i1 = i + 1;
        else i1 = i;
        if (j >= n) j1 = j + 1;
        else j1 = j;
        newMatrix[i, j] = matrix[i1, j1];
    }
}
Console.WriteLine();

PrintMatrix(newMatrix);
*/

// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
/*
Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
int [,] triangle = new int [row,row];
const int cellWidth = 3;

void FillTriangle()
{
    for(int i = 0; i < row; i++)
    {
        triangle[i,0] = 1;
        triangle[i,i] = 1;
    }
    for(int i = 2; i < row; i++)
    {
        for(int j = 1; j <= i; j++)
        {
            triangle[i,j] = triangle[i-1, j-1] + triangle[i-1,j];
        }
    }
}

void Magic()
{
    int col = cellWidth * row;
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j<=i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i,j] != 0) Console.Write($"{triangle[i,j], cellWidth}");
            col += cellWidth * 2;
        }

        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}

FillTriangle();
Magic();
*/
