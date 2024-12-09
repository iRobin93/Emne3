using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringsystem
{
    internal class Clothes : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public string Size;

        public Clothes(double price, string name, string size) 
        {
            Price = price;
            Size = size;
            Name = name;
        }


        public void WriteInfo()
        {
            Console.WriteLine("The item " + Name + " with size: " + Size + " is priced at: " + Price );
        }
    }
}
