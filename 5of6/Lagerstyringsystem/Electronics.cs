using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringsystem
{
    internal class Electronics : IProduct
    {
        public double Price { get; set; }

        public string Name { get; set; }
        public int Warranty {  get; private set; }

        public Electronics(double price, string name, int warranty)
        {
            Price = price;
            Name = name;
            Warranty = warranty;
        }

        public void WriteInfo()
        {
            Console.WriteLine("The item " + Name + " with warranty: " + Warranty + " is priced at: " + Price);
        }
    }
}
