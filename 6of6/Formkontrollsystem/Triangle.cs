using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Formkontrollsystem
{
    internal class Triangle : Shape
    {
        private double _base;
        private double _heigth;

        public Triangle(double @base, double heigth, string name, string color) : base(name, color)
        {
            _base = @base;
            _heigth = heigth;
        }

        public override double CalculateArea()
        {
            return 0.5 * _base * _heigth;
        }
    }
}
