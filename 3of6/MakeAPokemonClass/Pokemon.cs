using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeAPokemonClass
{
    public class Pokemon
    {
        public string Name { get; }
        public int HP { get; }
        public int Attack { get; set; }
        public int Defence { get; set; }

        public Pokemon(string name, int hp)
        {
            this.Name = name;
            this.HP = hp;
        }

        public void Feed(int food)
        {
            this.Attack += food;
        }
       
    }
    

}
