Console.WriteLine("Welcome to Crocodile Game! Choose <, > or =");
int Points = 0;

bool Game()
{
    
    
    Random random = new Random();
    int RandomNr1 = random.Next(1, 12);
    int RandomNr2 = random.Next(1, 12);

    Console.WriteLine(RandomNr1 + " _ " + RandomNr2 + " \nYou got: " + Points + " points");
    ConsoleKeyInfo key = Console.ReadKey(true);
    char usersChar = key.KeyChar;
    Console.WriteLine(usersChar);


    if (!(usersChar == '<' || usersChar == '>' || usersChar == '='))
    {
        Console.WriteLine("Ending game");
        return false;
    }
       


    if (checkAnswer(RandomNr1, RandomNr2, usersChar))
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