/* Strategi
 * 
 * Lage liste av ord.
 * Velge et random ord fra en liste.
 * 
 * Lage klasse for status av spillet.
 * Antall feil. Bokstaver som er gjettet
 * 
 * Tegne Hangman og bokstavene i ordet
 * Tegne _ for hver bokstav i ordet som ikke er gjettet.
 * 
 * Starte på nytt hvis spillet er ferdig ? 
 */



using System.Globalization;
using Hangman;
using static System.Runtime.InteropServices.JavaScript.JSType;

char input2;





do
{
    Console.Clear();
    HangmanGame game = new HangmanGame();
    while (!(game.Loose || game.Win))
    {
        var input = Console.ReadKey();
        game.AddToGuessedLetter(Char.ToLower(input.KeyChar));
    }
    Console.WriteLine("Trykk e for å avsltute, trykk noe annet for å fortsette");
    input2 = Console.ReadKey().KeyChar;
} while (input2 != 'e');