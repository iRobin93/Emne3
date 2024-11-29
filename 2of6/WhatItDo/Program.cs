using System.Numerics;

var range = 250;
var counts = new int[range];
string text = "something";
int countOfCharacters = 0;
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine();
    foreach (var character in text ?? string.Empty)
    {
        
        counts[(int)char.ToLower(character)]++;
        countOfCharacters++;
    }
    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            
            var character = (char)i;
            float percentComplete = ((100f * counts[i]) / countOfCharacters);
            string OutPut1 = character + " - " + counts[i];
            string OutPut2 = character + " - " + percentComplete.ToString("0.00") + "%";
            Console.CursorLeft = Console.BufferWidth - OutPut1.Length - 1;
            Console.WriteLine(OutPut1);
            Console.CursorLeft = Console.BufferWidth - OutPut2.Length - 1;
            Console.WriteLine(OutPut2);
           
        }
    }
}
Console.WriteLine("");
Console.WriteLine("Press enter to exit");
Console.ReadLine();