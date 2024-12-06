using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgramering3_Bilforhandleren
{
    internal class Car
    {
        public string _brand {  get; private set; }
        public int _km { get; private set; }
        public string _regNr { get; private set; }
        public string _model { get; private set; }
        public int _price { get; private set; }
        
        public string _owner { get; private set; }

        public int _id { get; private set; }




        public Car(string brand, int km, string regNr, string model, int price, string owner, int id)
        {
            _brand = brand;
            _km = km;
            _regNr = regNr;
            _model = model;
            _price = price;
            _owner = owner;
            _id = id;
        }

        public void Purchase(Person buyer)
        {
            _owner = buyer._name;
        }
    }
}
