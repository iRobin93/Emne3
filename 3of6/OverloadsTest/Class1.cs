using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadsTest
{
    internal class Class1
    {

        public void PrintWelcomeMessage(string msg = "Du er snill!")
        {
            Console.WriteLine("Hei og velkommen" + msg);
        }
        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Hei og velkommen");
        }


    }
}
