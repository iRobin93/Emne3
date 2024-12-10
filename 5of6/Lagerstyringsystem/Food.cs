using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringsystem
{
    public class Food : IProduct
    {
        public double Price { get; set; }

        public string Name { get; set; }
        public DateTime ExpirationDate { get; private set; }

        public Food(double price, string name, DateTime date)
        {
            Price = price;
            Name = name;
            ExpirationDate = date;
        }

        public void WriteInfo()
        {
            Console.WriteLine("The item " + Name + " with expiration: " + ExpirationDate + " is priced at: " + Price);
        }
    }
}
