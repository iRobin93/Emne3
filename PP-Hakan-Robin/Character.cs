using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Hakan_Robin
{
    internal class Character
    {
        private string _name;
        private string _house;
        private List<string> _inventory = new List<string>();


        public Character(string name, string house)
        {
            _name = name;
            _house = house;
        }

        public void PrintInfo()
        {
            Console.WriteLine(_name + " is in house " + _house);
            Console.WriteLine("In your inventory you find ");
            foreach (var item in _inventory) 
            {
                Console.WriteLine(item);
            }
        }

        public void BuyItem(char itemToBuy, MagicStore magicStore)
        {

                magicStore.SellItem(itemToBuy);
            if (itemToBuy == '1')
            {
                _inventory.Add("Pheonix Wand");
            }
            else if (itemToBuy == '2')
            {
                _inventory.Add("Oak Wand");
            }

            else if (itemToBuy == '3')
            {
                _inventory.Add("Rat");
            }

            else if (itemToBuy == '4')
            {
                _inventory.Add("Cat");
            }
        }
    }
}
