// адайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void PrintNumberToN(int N)
{
    if (N == 0)
    {
        return;
    }
    Console.Write($"{N} ");
    PrintNumberToN(N - 1);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumberToN(number);
*/

// Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.

/*
int SummDigital(int firstNumber, int secondNumber)
{
if (firstNumber > secondNumber)
{
return 0;
}
return firstNumber + SummDigital(firstNumber + 1, secondNumber);
}

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber) 
    Console.WriteLine($"Сумма чисел от {secondNumber} до {firstNumber} = {SummDigital(secondNumber, firstNumber)}");
else 
    Console.WriteLine($"Сумма чисел от {firstNumber} до {secondNumber} = {SummDigital(firstNumber, secondNumber)}");
*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
/*
int FunctionAkkerman(int firstNumber, int secondNumber)
{
    if (firstNumber == 0)
    {
        return secondNumber + 1;
    }
    if (secondNumber == 0)
    {
        return FunctionAkkerman(firstNumber - 1, 1);
    }
    return FunctionAkkerman(firstNumber - 1, FunctionAkkerman(firstNumber, secondNumber -1));    
}

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FunctionAkkerman(firstNumber, secondNumber));
*/



//  Напишите программу, которая заполнит спирально массив 4 на 4.

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:D2} \t");
        }
        Console.WriteLine();
    }
}

int[,] cube = new int[4, 4];
int count = 1;

for (int j = 0; j < 4; j++)
{
    cube[0, j] = count;
    count++;
}

for (int i = 1; i < 4; i++)
{
    cube[i, 3] = count;
    count++;
}

for (int j = 2; j >= 0; j--)
{
    cube[3, j] = count;
    count++;
}
for (int i = 2; i > 0; i--)
{
    cube[i, 0] = count;
    count++;
}
for (int j = 1; j < 3; j++)
{
    cube[1, j] = count;
    count++;
}

for (int i = 2; i < 3; i++)
{
    cube[i, 2] = count;
    count++;
}
for (int j = 1; j < 2; j++)
{
    cube[2, j] = count;
    count++;
}

PrintMatrix(cube);
