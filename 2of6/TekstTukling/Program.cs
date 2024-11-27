showMenu();


void showMenu()
{
    int UserInputInt = 0;
    string? UserInputString;

    Console.WriteLine("Press 1 for reverse string");
    Console.WriteLine("Press 2 for change string");
    
    UserInputString = Console.ReadLine();
    Console.WriteLine("Skriv et ord");
    if (UserInputString != null)
    {
        UserInputInt = Int32.Parse(UserInputString);
    }

    UserInputString = Console.ReadLine();
    

    if(UserInputInt == 1)
    {
        string revertedString = "";
        for (int i = UserInputString.Length - 1; i >= 0; i--)
            revertedString += UserInputString[i];
        Console.WriteLine(revertedString);

    }

    if (UserInputInt == 2)
    {
        string newString = "";
        for (int i = 0; i < UserInputString.Length; i++)
        {
            if (UserInputString[i] == 'e')
                newString += "a";
            else if (UserInputString[i] == 'E')
                newString += "A";
            else
                newString += UserInputString[i];
        }
            
        Console.WriteLine(newString);
    }
    
}

Console.WriteLine("");
Console.WriteLine("Press enter to exit");
Console.ReadLine();