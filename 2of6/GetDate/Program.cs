string getDay()
{

    Random random = new Random();
    int RandomNumber = random.Next(1,8);

    switch (RandomNumber)
    {
        case 1:
            return "Monday";
        case 2:
            return "Tuesday";
        case 3:
            return "Wednesday";
        case 4:
            return "Thursday";
        case 5:
            return "Friday";
        case 6:
            return "Saturday";
        case 7:
            return "Sunday";
        default:
            return "Error";
    }
}



Console.WriteLine("It is: " + getDay());
Console.WriteLine("");
Console.WriteLine("Press enter to exit");
Console.ReadLine();