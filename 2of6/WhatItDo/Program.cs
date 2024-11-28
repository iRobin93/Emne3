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
            Console.WriteLine(character + " - " + counts[i]);
        }
    }
}