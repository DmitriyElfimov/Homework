// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.(100, 1000);
    }
    return arr;
}
int[] array = FillArray(size);
Console.WriteLine($"[{string.Join(", ", array)}]");

int count = 0;
for(int i = 0; i < size; i++)
{
    if( array[i] % 2 == 0)
    count++;
}
Console.WriteLine($"количество четных чисел = {count}");
*/

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.(min, max + 1);
    }
    return arr;
}
int[] array = FillArray(size);
Console.WriteLine($"[{string.Join(", ", array)}]");

int SummaOnePosition (int [] array)
{
    int summa = 0;
    for(int i = 1; i < size; i += 2)
    summa = summa + array[i];
    return summa;
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {SummaOnePosition(array)}");
*/

// Задайте массив вещественных чисел(тип double). 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное массива: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] FillArray(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min * 100, (max + 1) * 100);
        arr[i] = arr[i] / 100;
    }
    return arr;
}
double[] array = FillArray(size);
Console.WriteLine($"[{string.Join(", ", array)}]");

double maximum = array[0];
for (int j = 1; j < size; j++)
{
    if (array[j] > maximum) maximum = array[j];
}

double minimum = array[0];
for (int n = 1; n < size; n++)
{
    if (array[n] < minimum) minimum = array[n];
}

double difference = maximum - minimum;

Console.WriteLine($"Разница между максимальным значением и минимальным ровна = {Math.Round(difference, 2)}");
