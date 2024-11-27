Console.WriteLine("Welcome to Crocodile Game! Choose <, > or =");
int Points = 0;

bool Game()
{
    char Operator = '+';
    Random random = new Random();
    int RandomNr1 = random.Next(1, 12);
    int RandomNr2 = random.Next(1, 12);

    Console.WriteLine(RandomNr1 + " _ " + RandomNr2 + " \nYou got: " + Points + " points");
    string? UserInput = Console.ReadLine();
    if (UserInput != null)
    {
        if (UserInput == "<")
            Operator = '<';
        else if (UserInput == ">")
            Operator = '>';
        else if (UserInput == "=")
            Operator = '=';
        else
        {
            Console.WriteLine("Ending game");
            return false;
        }

    }
      
    else
    {
        Console.WriteLine("Ending game");
        return false;
    }


    if (checkAnswer(RandomNr1, RandomNr2, Operator))
    {
        Points++;
        
    }
    else
    {
        Points--;
        
    }
    return true;
}

bool checkAnswer(int RandomNr1, int RandomNr2, char Operator)
{

    switch (Operator)
    {
        case '<': if (RandomNr1 < RandomNr2) return true;
            break;
        case '>': if (RandomNr1 > RandomNr2) return true;
            break;
        case '=': if (RandomNr1 == RandomNr2) return true;
            break;
        default: return false;
    }
    return false;
}


while (Game());

Console.WriteLine("");
Console.WriteLine("Press enter to exit");
Console.ReadLine();