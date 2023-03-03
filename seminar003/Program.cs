// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
/*
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10)
    {
        Console.WriteLine("Палиндром!");
    }
    else
    {
        Console.WriteLine("Не палиндром!");
    }
}
else
{
    Console.WriteLine("Введите другое число");
}
*/

// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
/*
double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return Math.Round(res, 2);
}

Console.Write("Введите координату по Х для первой точки ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по У для первой точки ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Z для первой точки ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Х для второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Y для второй точки ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату по Z для второй точки ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Distance3D(x1, y1, z1, x2, y2, z2);
System.Console.WriteLine($"Расстояние между точками в пространстве = {distance}");
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}