using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringsystem
{
    internal class Storage
    {
        public List<IProduct> Products = new();

        public void RemoveProduct(IProduct product)
        {
            Products.Remove(product);
        }

        public void AddProduct(IProduct product)
        {
            Products.Add(product);
        }

        public void WriteAllProducts()
        {
            foreach (IProduct product in Products)
            {
                product.WriteInfo();
            }
        }


    }
}
