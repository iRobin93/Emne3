using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    internal class Boat : Vehicle
    {
        private int _maxspeed;
        private int _bruttoweight;

        public Boat(string id, int effect, int maxspeed, int bruttoweight) : base(id, effect)
        {
            _maxspeed = maxspeed;
            _bruttoweight = bruttoweight;
        }


        internal override void Run()
        {
            Console.WriteLine("You drive the boat!");
        }

        public override void PrintInfo()
        {
            Console.WriteLine("ID: " + _id + " Effekt: " + _effect + "Max speed: " + _maxspeed + " Brutto Weight: " + _bruttoweight);

        }
    }
}
