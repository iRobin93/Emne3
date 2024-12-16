using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formkontrollsystem
{
    public abstract class Shape
    {
        protected string _name;
        protected string _color;


        protected Shape(string name, string color)
        {
            _name = name;
            _color = color;
        }

        public abstract double CalculateArea();

        public string GetName()
        {
            return _name;
        }

        public string GetColor()
        {
            return _color;
        }

    }
}
