
int Number1 = 15;
int Number2 = 16;
int Number3 = 15;
int Number4 = 30;

bool Bool1 = TakeTwoNumbers(Number1, Number2);
bool Bool2 = TakeTwoNumbers(Number1, Number3);
bool Bool3 = TakeTwoNumbers(Number1, Number4);
bool TakeTwoNumbers(int Number1, int Number2)
{

    if (Number1 + Number2 == 30 || Number1 == 30 || Number2 == 30)
    {
        return true;
    }
    else return false;

}


Console.WriteLine("15 and 16: " + Bool1);
Console.WriteLine("15 and 15: " + Bool2);
Console.WriteLine("15 and 30: " + Bool3);
Console.WriteLine("");
Console.WriteLine("Press enter to exit");
Console.ReadLine();