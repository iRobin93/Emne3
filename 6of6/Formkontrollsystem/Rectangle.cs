using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Formkontrollsystem
{
    internal class Rectangle : Shape
    {
        private double _length;
        private double _width;

        public Rectangle(double length, double width, string name, string color) : base(name, color)
        {
            _length = length;
            _width = width;
        }
        public override double CalculateArea()
        {
            return _length * _width;
        }
    }
}
