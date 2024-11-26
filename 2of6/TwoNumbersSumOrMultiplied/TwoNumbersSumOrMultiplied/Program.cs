int Number1 = 5;
int Number2 = 6;
int Number3 = 5;

int Number4 = SumOrMultiply(Number1, Number2);
int Number5 = SumOrMultiply(Number1, Number3);


int SumOrMultiply(int Number1, int Number2)
{
    if (Number1 == Number2)
    { return Number1 * Number2; }
    else return Number1 + Number2;

}

Console.WriteLine(" 5 + 6 er: " + Number4);
Console.WriteLine("5 * 5 er: " + Number5);

Console.WriteLine("");
Console.WriteLine("Press enter to exit");
Console.ReadLine();