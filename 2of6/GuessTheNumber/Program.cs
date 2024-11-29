using System.Runtime.InteropServices;
using System.Security.Cryptography;


void InitializeGame()
{
    int RandomNr = new Random().Next(1, 101);
    Game(RandomNr);
}

bool Game(int RandomNr)
{
    int userInputInt = 0;
    
    Console.WriteLine("Guess a number between 1-100");
    var userInput = Console.ReadLine();
    try
    {
        userInputInt = Int32.Parse(userInput);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    
    if(userInputInt == RandomNr)
    {
        Console.WriteLine("You Won");
        Console.WriteLine("Do you want to play again? Y/N");
        ConsoleKeyInfo userInput2 = Console.ReadKey();
        if(userInput2.KeyChar == 'y')
        {
            InitializeGame();
            return true;
        }
        else { return false; }
    }
    else
    {
        if (userInputInt < RandomNr)
        {
            Console.WriteLine("Random nr is higher");
        }

        else if (userInputInt > RandomNr) 
        {
            Console.WriteLine("Random nr is lower");
        }

        Game(RandomNr);
    }
    
}


InitializeGame();

Console.WriteLine("");
Console.WriteLine("Press enter to exit");
Console.ReadLine();