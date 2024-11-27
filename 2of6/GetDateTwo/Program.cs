string dayString = "";
int day;

void startProgram()
{
    Console.WriteLine("Enter a number between 1 and 7");
    dayString = Console.ReadLine();
    try
    {
        day = Int32.Parse(dayString);
        if(day > 7 || day < 1)
        {
        startProgram();
        }
            

    }
    catch (FormatException)
    {
        startProgram();
    }


}



string getDay()
{
   

    switch (day)
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
            return "Enter a number between 1 and 7";
    }
}



startProgram();
Console.WriteLine("It is: " + getDay());

Console.WriteLine("");
Console.WriteLine("Press enter to exit");
Console.ReadLine();