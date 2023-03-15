// Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Введите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] FillArray(int size)
{
    int[] arr = new int[size];
    
        for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        if( arr[i] > 0) count++;
    }
    return arr;
}
int[] array = FillArray(size);

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Пользователь ввел {count} чисел больше 0");
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2
/*
Console.Write("Введите коэффициент K1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент B1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент K2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент B2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2 && b1 == b2) Console.WriteLine("Прямые имеют бесконечное множество точек пересечения");
if(k1 == k2 && b1 != b2) Console.WriteLine("Прямые не имеют точек пересечения");
if(k1 != k2) 
{
    Console.WriteLine($"Прямые пересекаются в точке ({(b2-b1)/(k1-k2)};{(b2-b1)/(k1-k2)*k1 + b1})");
}
*/
