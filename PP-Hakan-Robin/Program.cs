/* 1. lage klassen Character - med fields, 
 * 2. lage metoden printinfo i character.
 * 3. lage meny og klasse MagicStore
 *      meny: 1. print info
 *      meny: 2. MagicStore
 *      meny: 3. trylle
 * 
 * 
 */

using PP_Hakan_Robin;

Character character = new Character("Robin", "Gryffindor");
MagicStore magicStore = new MagicStore();
bool Menu = true;

void Meny()
{
    
    Console.WriteLine("Tast 1 for å printe info, tast 2 for å gå i butikk, tast 3 for å trylle, tast 4 for å avslutte");
    char input;
    string? input2;
    input = Console.ReadKey().KeyChar;
    if (input == '1')
    {
        character.PrintInfo();
    }

    else if (input == '2')
    {
        Console.WriteLine("I magi butikken finner du følgende: ");
        magicStore.WriteInfo();
        input = Console.ReadKey().KeyChar;
        if (input == '5')
            return;
        else character.BuyItem(input, magicStore);


    }

    else if (input == '3')
    {
        Console.WriteLine("Skriv en trylleformel");
        input2 = Console.ReadLine();
        if (input2 == "leviosa")
            Console.WriteLine("Du fikk en fjær til å fly");
        else if (input2 == "hokus pokus")
            Console.WriteLine("Du fyrer av fyrverkeri");
    }


    else if (input == '4')
    {
        Menu = false;
    }
}


while (Menu)
    Meny();