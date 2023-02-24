// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("input first number ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input second number ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 == number2) // на случай если введут одинаковые числа)))
    {
        Console.WriteLine("numbers equal");
    }
    else
        if(number1 > number2)
        {
            Console.WriteLine($"maximum = {number1}; minimum = {number2}");
        }
        else
        {
            Console.WriteLine($"maximum = {number2}; minimum = {number1}");
        }
*/

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("input first number ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input second number ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input third number ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if(max < number2)
{
    max = number2;
}
if(max < number3)
{
    max = number3;
}
Console.WriteLine("maximum = " + max);
*/

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
/*
Console.Write("input number ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
{
    Console.WriteLine("Yes, number even");
}
else
{
    Console.WriteLine("No, number uneven");
}
*/

// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("input poitiv number ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 2;
if(number > 1)
{
    while(current <= number)
    {
        Console.Write(current + " ");
        current +=2;
    }
}
else
{
    Console.WriteLine("input other number");
}
*/
