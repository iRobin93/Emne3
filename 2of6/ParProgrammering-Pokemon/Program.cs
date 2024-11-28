using ParProgrammering_Pokemon;
Console.WriteLine("Hei, velkommen lag din pokemon");


void MakePokemon()
{
    Console.WriteLine("Skriv inn navn på pokemon!");
    string userInput = Console.ReadLine();
    Pokemon newPokemon = new Pokemon(userInput);
    writeMenu(newPokemon);
}



void writeMenu(Pokemon newPokemon)
{
    Console.WriteLine("Tast 1 for å mate " + newPokemon.Name);
    Console.WriteLine("Tast 2 for å kose med " + newPokemon.Name);
    Console.WriteLine("Tast 3 for å gå tur med " + newPokemon.Name);
    Console.WriteLine("Tast 4 for å lage en ny pokemon");
    string userInput = Console.ReadLine();
    int newInt = Int32.Parse(userInput);
    action(newInt, newPokemon);
    
}

void action(int action, Pokemon thePokemon)
{
    switch (action)
    {
       case 1:
            Console.WriteLine("Du matet " + thePokemon.Name);
                thePokemon.Feed();
        break;
        case 2:
            Console.WriteLine("Du koser med " + thePokemon.Name);
            Random random = new Random();
            int RandomNr = random.Next(1,4);
            CheckLevelUp(RandomNr, thePokemon);
            break;
        case 3: 
            if (thePokemon.NeedToPee)
            Console.WriteLine("Your Pokemon peed");
            thePokemon.WalkAndPee();
            break;
            case 4: MakePokemon();
            break;
    }


    Console.WriteLine("Din Pokemon stats: Helse: " + thePokemon.Health);
    Console.WriteLine("Level: " + thePokemon.Level);
    if(thePokemon.NeedToPee)
        Console.WriteLine("Your pokemon needs to pee");
    writeMenu(thePokemon);
}

void CheckLevelUp(int RandomNr, Pokemon thePokemon)
{
    switch (RandomNr)
    {
        case 3: thePokemon.LevelUp();
            break;
        case 1: thePokemon.HasToPee();
            break;
    }
}






MakePokemon();
/*Lag en konsoll-applikasjon hvor man kan generere opp flere forskjellige virtuelle kjæledyr.
Bruk constructor i klassen, og man skal ikke ha lov til å endre data som navn, age eller noen andre egenskaper utenfra klassen. Lag funksjonalitet som gjør at man kan gi dyret mat, kose med dyret eller sjekke om dyret må på do
Her er et eksempel på hvordan det kan se ut:*/