using QuizAppen;
char input = ' ';
void WriteMeny()
{
    Console.WriteLine("Velg en QuizType: ");
    foreach (var number in Enum.GetValues<QuizTypeEnum>())
    {
        Console.Write(((long)number));
        Console.WriteLine(": " + number);
    }
    Console.WriteLine("Trykk e for exit!");

}

while(input != 'e')
{
    WriteMeny();
    input = Console.ReadKey().KeyChar;
    new Quiz((QuizTypeEnum)Char.GetNumericValue(input));
}

