using System.Runtime.InteropServices;
using System.Security.Cryptography;

bool gameRunning = true;
int RandomNr = 0;
void InitializeGame()
{
    RandomNr = new Random().Next(1, 101);
}

void Game()
{
    while (true)
    {
        int userInputInt = 0;

        Console.WriteLine("Guess a number between 1-100");
        var userInput = Console.ReadLine();
        if (userInput == "")
        {
            return;
        }
        try
        {

            userInputInt = Int32.Parse(userInput);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        if (userInputInt == RandomNr)
        {
            Console.WriteLine("You Won");
            return;
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


        }
    }


}


InitializeGame();
while (gameRunning)
{
    Game();
    Console.WriteLine("Do you want to play again? Y/N");
    ConsoleKeyInfo userInput2 = Console.ReadKey();
    if (userInput2.KeyChar == 'y')
    {
        InitializeGame();
    }
    else { gameRunning = false; }
}
    
Console.WriteLine("");
Console.WriteLine("Press enter to exit");
Console.ReadLine();