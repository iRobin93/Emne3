var range = 250;

var counts = new int[range];
string text = "something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine();
    foreach (var character in text ?? string.Empty)
    {
       counts[(int)character]++;
    }
    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            var character = (char)i;
            Console.WriteLine(character + " - " + counts[i]);
        }
    }
}





//Breakpoints : 1, 8, 12, 20.
//Verdier
/*1. 72 H
 * 2. 101 e
 * 3. 105 i
 * 4. 32 ' '
 * 5. 112 p
 * 6. 229 å
 * 7. 32 ' '
 * 8. 100 d
 * 9. 101 e
 * 10. 103 g 
 * 
 * Variabelen i må ha verdien 250 for å avslutte for løkken.
 */