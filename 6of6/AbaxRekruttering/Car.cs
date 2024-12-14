using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        internal override bool CompareRest(Vehicle otherCar)
        {
            if (_maxSpeed == ((Car)otherCar)._maxSpeed && _color == ((Car)otherCar)._color && _type == ((Car)otherCar)._type)
            {
                Console.WriteLine("Compare rest is the same(Car)");
                return true;
            }

            else 
            {
                Console.WriteLine("Compare rest is not the same(Car)");
            return false;
            }
            
        }
        public override void PrintInfo()
        {
            Console.WriteLine("ID: " + _id + " Effekt: " + _effect + " Max speed: " + _maxSpeed + " Color: " + _color + " Type: " + _type);
        }

        internal override void Run()
        {
            Console.WriteLine("You drive the car!");
        }
    }
}
