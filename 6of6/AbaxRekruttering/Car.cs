using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    internal class Car : Vehicle
    {
        private int _maxSpeed;
        private string _color;
        private string _type;


        public Car(int maxSpeed, string color, string type, string id, int effect) : base( id,  effect)
        {
            _maxSpeed = maxSpeed;
            _color = color;
            _type = type;

        }
    }
}
