int Number1 = 1;
int Number2 = 2;
int Number3 = 1;

bool CheckNumbers = checkNumbers(Number1, Number2);
bool CheckNumbers2 = checkNumbers(Number1, Number3);

bool checkNumbers(int Number1, int Number2)
{
    if (Number1 == Number2)
    { return true; }
    else return false;
}

Console.WriteLine("Ulike Numre: " + CheckNumbers);
Console.WriteLine("Like Numre: " + CheckNumbers2);

Console.WriteLine("");
Console.WriteLine("Press enter to exit");
Console.ReadLine();

