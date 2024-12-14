using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbaxRekruttering
{
    abstract class Vehicle
    {
        internal string _id;
        internal int _effect;

        public Vehicle(string id, int effect)
        {
            _id = id;
            _effect = effect;
        }

        internal virtual bool CompareRest(Vehicle otherVehicle)
        {
            Console.WriteLine("Compare rest is same.(Vehicle)");
            return true;
        }

        public bool CompareVehicle(Vehicle vehicle2)
        {

            if (CompareRest(vehicle2) && _id == vehicle2._id && _effect == vehicle2._effect)
            {
                Console.WriteLine("Vehicle is the same");
                return true;
            }
            else
            {
                Console.WriteLine("Vehicle is not the same");
             return false;
            }
        }


        public abstract void PrintInfo();

        internal abstract void Run();
  
    }
}
