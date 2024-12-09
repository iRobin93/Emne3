using ClickerGame;

ClickerGameClass clicker1 = new ClickerGameClass(0, 1, 1);


while (true)
{
    Console.Clear();
    Console.WriteLine("Kommandoer:\r\n  - SPACE = klikk(og få poeng)\r\n- K = kjøp oppgradering \r\nøker poeng per klikk koster 10 poeng\r\n- S = kjøp superoppgradering øker \"poeng per klikk\" for den vanlige oppgraderingen. koster 100 poeng\r\n - X = avslutt applikasjonen");
   Console.WriteLine($"Du har {clicker1.Points} poeng.");
    Console.WriteLine("Trykk tast for ønsket kommando.");
    var command = Console.ReadKey().KeyChar;
    if (command == 'x') clicker1.CommandX();
    else if (command == ' ') clicker1.CommandSpace();
    else if (command == 'k' && clicker1.Points >= 10) clicker1.CommandK();
    else if (command == 's' && clicker1.Points >= 100) clicker1.CommandS();
}