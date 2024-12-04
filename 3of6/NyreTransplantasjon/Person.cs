using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyreTransplantasjon
{
    internal class Person
    {
        public string Name { get; private set; }
        public int Age;
        public Nyre Nyre1 { get; private set; }
        public Nyre Nyre2 { get; private set; }

        public Person(string name, int age, Nyre nyre1, Nyre nyre2)
        {
            Name = name;
            Age = age;
            Nyre1 = nyre1;
            Nyre2 = nyre2;
        }

        public bool Transplantasjon(Person giver)
        {
            bool success = true;
            Random random = new Random();
            int randomInt = random.Next(0, 11);

            if (randomInt == 2)
            {
                success = false;
                this.Nyre1 = null;
                giver.Nyre1 = null;
            }
                

            if (success)
            {
                this.Nyre1 = giver.Nyre1;
                giver.Nyre1 = null;
            }

            return success;
        }

        public void WriteInfo()
        {
            string tekst1 = Nyre1 == null ? "" : Nyre1.Id + " med ";
            string tekst2 = Nyre1 == null ? "\"mangler nyre 1\"" : Nyre1.Quality.ToString() + "% kvalitet";

            Console.WriteLine(Name + " har nyrene " + tekst1  + tekst2 + $" og {Nyre2.Id} med {Nyre2.Quality}% kvalitet");
        }
    }

}

