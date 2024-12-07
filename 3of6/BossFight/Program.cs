using BossFight;

GameCharacter Hero = new GameCharacter("Hero", 100, 20, 40);
GameCharacter Boss = new GameCharacter("Boss", 400, 20, 10);
bool BossTurn = true;
bool end;




while (true)
{
    Console.WriteLine("Velkommen til BossFight, trykk en tast for å fighte, 5 for å avslutte");

var input = Console.ReadKey();
    if (input.KeyChar == '5')
    {
        goto trueEnd;
    }

    if (BossTurn)
    {
        end = Boss.Fight(Hero);
        BossTurn = false;
    }

    else
    {
        end = Hero.Fight(Boss);
        BossTurn = true;
    }

    if (end)
        goto end;

}




end:

while (true)
{
    
    Console.WriteLine("Tast 5 for å avslutte");
    var input1 = Console.ReadKey();
    if (input1.KeyChar == '5')
        goto trueEnd;
}
trueEnd:;




