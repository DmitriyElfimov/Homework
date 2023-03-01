// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

int CutTwoNumber(int num)
{
    int number = num / 10 % 10;
    return number;
}

Console.Write("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99 && num < 1000)
{
    Console.WriteLine($"Second digit number {num} is {CutTwoNumber(num)}");
}
else
{
    Console.WriteLine("Input another number");
}


//Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

int CutThreeNumber(int bigNumber)
{   
    if(bigNumber > 999)
    {
        while(bigNumber > 999) bigNumber = bigNumber / 10;
    }
    int threeNumber = bigNumber % 10;
    return threeNumber;
}

Console.Write("Input number: ");
int numb = Convert.ToInt32(Console.ReadLine());
if(numb < 100)
{
    Console.WriteLine("No Three Digit");
}
else
{
Console.WriteLine($"Three digit number {numb} is {CutThreeNumber(numb)}");
}


//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

bool Wekend(int data)
{
    return data == 6 || data == 7;
}

Console.Write("day of the week number: ");
int day = Convert.ToInt32(Console.ReadLine());
if(day > 0 && day < 8)
{
    Console.WriteLine($"Today wekend? Is {Wekend(day)}");
}
else
{
    Console.WriteLine("Input another day of the week number");
}
