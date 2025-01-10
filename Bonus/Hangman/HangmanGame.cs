using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class HangmanGame
    {
        private static List<string> _lines = new List<string>();
        private string _chosenWord;
        private int _wrongs = 0;
        public bool Loose = false;
        public bool Win = false;
        private List<char> _guessedletters = new List<char>();


        public HangmanGame()
        {
            if(_lines.Count == 0)
                ReadFile("C:\\Users\\robin\\source\\repos\\Emne3\\Bonus\\Hangman\\WordList.txt");
            PickRandomWord();
            DrawLettersReturnWin();
            DrawHangman();
        }

        public void WriteWord()
        {
            Console.WriteLine(_chosenWord);
        }
        private static void ReadFile(string filepath)
        {
            string line;

            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(filepath);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    //Read line, and split it by whitespace into an array of strings
                    AddToList(line);

                    //Read the next line
                    line = sr.ReadLine();

                }
                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static void AddToList(string line)
        {
            _lines.Add(line);
        }


        public void AddToGuessedLetter(char guessedletter)
        {
            CheckIfWordContainsLetter(guessedletter);
            _guessedletters.Add(guessedletter);
            if (_wrongs == 7)
                Loose = true;
            Console.Clear();
            if (!Loose)
                Win = DrawLettersReturnWin();

            DrawHangman();
        }
        private void CheckIfWordContainsLetter(char guessedletter)
        {
            if (_chosenWord.ToLower().Contains(guessedletter))
                return;
            else _wrongs++;
        }
        private bool DrawLettersReturnWin()
        {
            bool checkIfCorrect = true;
            Console.WriteLine();
            foreach (char c in _chosenWord) 
            {
                if (_guessedletters.Contains(Char.ToLower(c)))
                    Console.Write(" " + c + " ");
                else
                {
                    checkIfCorrect = false;
                    Console.Write(" _ ");
                }
                    

             
            }
            Console.WriteLine();
            foreach (char guessedletter in _guessedletters)
                Console.Write(" " + guessedletter + " ");

            return checkIfCorrect;
        }

        public void WriteInfo()
        {
            foreach (string line in _lines)
            {
                Console.WriteLine(line);
            }
        }

        private void PickRandomWord()
        {
            Random random = new Random();
            int randomNr;
            randomNr = random.Next(0, 100);
            _chosenWord = _lines[randomNr];
        }


        public void DrawHangman()
        {
            
            if (Win)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("        \\O/");
                Console.WriteLine("         |");
                Console.WriteLine("        / \\");
                Console.WriteLine("");
                Console.WriteLine("  You win!");
                return;
            }
            switch (_wrongs)
            {
                case 0:
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    break;
                case 1:
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("  |");
                    Console.WriteLine("  |");
                    Console.WriteLine("  |");
                    Console.WriteLine("  |");
                    Console.WriteLine("  |");
                    break;
                case 2:
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("  _______");
                    Console.WriteLine("  |      |");
                    Console.WriteLine("  |      O");
                    Console.WriteLine("  |");
                    Console.WriteLine("  |");
                    break;
                case 3:
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("  _______");
                    Console.WriteLine("  |      |");
                    Console.WriteLine("  |      O");
                    Console.WriteLine("  |      |");
                    Console.WriteLine("  |");
                    break;
                case 4:
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("  _______");
                    Console.WriteLine("  |      |");
                    Console.WriteLine("  |      O");
                    Console.WriteLine("  |     /|");
                    Console.WriteLine("  |");
                    break;
                case 5:
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("  _______");
                    Console.WriteLine("  |      |");
                    Console.WriteLine("  |      O");
                    Console.WriteLine("  |     /|\\");
                    Console.WriteLine("  |");
                    break;
                case 6:
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("  _______");
                    Console.WriteLine("  |      |");
                    Console.WriteLine("  |      O");
                    Console.WriteLine("  |     /|\\");
                    Console.WriteLine("  |     / ");
                    break;
                case 7:
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("  _______");
                    Console.WriteLine("  |      |");
                    Console.WriteLine("  |      O");
                    Console.WriteLine("  |     /|\\");
                    Console.WriteLine("  |     / \\");
                    Console.WriteLine("  |");
                    Console.WriteLine("  Game Over! The word was: " + _chosenWord);
                    break;
                default:
                    Console.WriteLine("Invalid guess count");
                    break;
            }
        }
    }
}
