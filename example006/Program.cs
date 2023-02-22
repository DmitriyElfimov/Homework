Console.WriteLine("Введите Ваше имя: ");
string username = Console.ReadLine();
if(username.ToLower() == "skit")
{
    Console.WriteLine("Hi, skit");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}