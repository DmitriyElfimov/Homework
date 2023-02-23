int count = 0;
Console.WriteLine("Введите дистанцию: ");
string f = Console.ReadLine();
double distance = double.Parse(f);
double distanceLimit = 1;
Console.WriteLine("Введите скорость первого друга: ");
string g = Console.ReadLine();
double firstFriendSpeed = double.Parse(g);
Console.WriteLine("Введите скорость второго друга: ");
string h = Console.ReadLine();
double secondFriendSpeed = double.Parse(h);
Console.WriteLine("Введите скорость собаки: ");
string i = Console.ReadLine();
double dogSpeed = double.Parse(i);
int directionDogToFriend = 2;
double time = 0;
while (distance > distanceLimit)
{
    if (directionDogToFriend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        directionDogToFriend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        directionDogToFriend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
    Console.Write("остаток дистанции ");
    Console.WriteLine(distance);
}
Console.Write("собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз");
