using System.Diagnostics;
namespace StartProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("ingen parametre");
                }
                else
                {
                    string myProgram = args[0];
                    myProgram = myProgram.Substring(13);
                    Process.Start(Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%") + "\\source\\repos\\" + myProgram);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

        }
    }
}