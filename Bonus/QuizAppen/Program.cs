using System;
using System.Security.Cryptography;
using QuizAppen;
char input = ' ';
char quizInput = ' ';

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

while (input != 'e')
{
    Console.Clear();
    WriteMeny();
    input = Console.ReadKey().KeyChar;
    if (input == 'e') break;
    if (Char.GetNumericValue(input) >= Enum.GetNames(typeof(QuizTypeEnum)).Length || !Char.IsNumber(input))
    {
        continue;
    }
    var quiz = new Quiz((QuizTypeEnum)Char.GetNumericValue(input));
    Console.Clear();
    while (!quiz.IsAllAnswered())
    {
        quiz.Question();
        quizInput = Console.ReadKey().KeyChar;
        Console.WriteLine();
        bool correctAnswer = quiz.CheckAnswer(quizInput);
        if (correctAnswer)
        {
            Console.WriteLine("Korrekt svar! Poengene dine: " + quiz.GetPoints());
        }
        else 
        {
            Console.WriteLine("Feil svar!");
        }
    }
    Console.WriteLine("Quizen er ferdig, Poengene dine: " + quiz.GetPoints());
    Console.ReadKey();

}