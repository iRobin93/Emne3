using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontrollsystem
{
    internal class Circle : Shape
    {
        private double _radius;

        public Circle(double radius, string name, string color) : base (name, color)
        {
            _radius = radius;
        }

        public override double CalculateArea()
        {
            return _radius * _radius * 3.14;
        }


    }
}
