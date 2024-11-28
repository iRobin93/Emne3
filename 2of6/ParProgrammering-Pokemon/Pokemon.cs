using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammering_Pokemon
{
    public class Pokemon
    {
        public string Name { get; private set; }
        public int Health { get; set; }
        public int Level { get; set; }

        public bool NeedToPee {  get; set; }

        public Pokemon (string name)
        {
            Name = name;
            Health = 100;
            Level = 5;
            NeedToPee = false;
        }

        public void Feed()
        {
            Health += 2;
        }

        public void LevelUp()
        {
            Level += 1;
        }

        public void HasToPee()
        {
            NeedToPee = true;
        }

        public void WalkAndPee()
        {
            NeedToPee = false;
        }
    }
}
