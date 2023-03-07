// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
/*
Console.WriteLine("Input firstNumber :");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input secondNumber :");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int product = 1;
for(int i = 1; i <= secondNumber; i++)
{
    product = product * firstNumber;
}
Console.WriteLine($"Число {firstNumber} в степени {secondNumber} = {product}");
*/


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SummerDigital(int number)
{
    int count = 0;
    int summa = 0;
    while (number != 0)
    {
        summa = summa + number % 10;
        number /= 10;
        count++;
        
    }
    return summa;
}

Console.Write("input number :");
int numb = Convert.ToInt32(Console.ReadLine());
int summ = SummerDigital(numb);
Console.WriteLine($"Сумма цифр в числе {numb} = {summ}");
*/

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Задается количество элементов, минимальное и максимальное значение. Рандом!!!

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
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(min, max+1);
}
return arr;
}


int[] array = FillArray(size);
Console.WriteLine($"[{string.Join(", ", array)}]"); 
*/

// Второй вариант. С вводом каждого элемента!

Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int[] array = FillArray(size);
Console.WriteLine($"[{string.Join(", ", array)}]");
