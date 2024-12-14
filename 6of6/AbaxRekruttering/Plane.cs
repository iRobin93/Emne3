using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    internal class Plane : Vehicle
    {
        private int _wingSpan;
        private int _cargoLimit;
        private int _weight;
        private string _type;

        public Plane(string id, int effect, int wingSpan, int cargoLimit, int weight, string type) : base(id, effect)
        {
            _wingSpan = wingSpan;
            _cargoLimit = cargoLimit;
            _weight = weight;
            _type = type;
        }


        public override void PrintInfo()
        {
            Console.WriteLine("ID: " + _id + " Effekt: " + _effect + " Type: " + _type + "Wingspan: " + _wingSpan + "Cargo limit: " + _cargoLimit + "Weight: " + _weight);

        }

        internal override void Run()
        {
            Console.WriteLine("You fly the plane!");
        }
    }
}
