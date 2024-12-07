using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgramering3_Bilforhandleren
{
    internal class Person
    {
        public string _name {  get; private set; }

        public Person(string name)
        {
            _name = name;
        }
    }
}
