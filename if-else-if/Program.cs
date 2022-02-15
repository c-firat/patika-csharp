//If else if example
int currentHour = DateTime.Now.Hour;
if (currentHour > 8 && currentHour < 18)
{
    Console.WriteLine("Have a nice work!");
}
else if (currentHour > 18 && currentHour < 23)
{
    Console.WriteLine("Good night");
}
else
{
    Console.WriteLine("Go to sleep");
}

string result = currentHour >= 6 && currentHour <= 18 ? "Have a nice work" : "get some fun";
Console.WriteLine(result);