string Hobby1 = "Magician";
string Hobby2 = "Golfer";
string Hobby3 = "Gamer";
string Hobby4 = "Programmer";
string Hobby5 = "Dancer";



Console.WriteLine("Hello, Write your name to get a new hobby!");
string name = Console.ReadLine();
Console.WriteLine(name +" your new hobby is: " + GetRandomHobby());

string GetRandomHobby()
{
    Random random = new Random();
    int randomNumber = random.Next(1, 6);
    if (randomNumber == 1) return Hobby1;
    if (randomNumber == 2) return Hobby2;
    if (randomNumber == 3) return Hobby3;
    if (randomNumber == 4) return Hobby4;
    if (randomNumber == 5) return Hobby5;
    return "Wrong integer for hobby";
}


Console.WriteLine("");
Console.WriteLine("Press enter to exit");
Console.ReadLine();