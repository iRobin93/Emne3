using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Hakan_Robin
{
    internal class MagicStore
    {
        private int _pheonixWands = 10;
        private int _oakWands = 10;
        private int _rat = 1;
        private int _cat = 1;


        

        public void WriteInfo()
        {
            Console.WriteLine("Tast 1 for å kjøpe: Pheonix Wands: " + _pheonixWands);
            Console.WriteLine("Tast 2 for å kjøpe: Oak Wands: " + _oakWands);
            Console.WriteLine("Tast 3 for å kjøpe: Rat: " + _rat);
            Console.WriteLine("Tast 4 for å kjøpe: Cat: " + _cat);
            Console.WriteLine("Tast 5 for gå tilbake");
        }

        public void SellItem(char itemToSell)
        {
            if (itemToSell == '1')
            {
                Console.WriteLine("Gratulerer du kjøpte en pheonix wand!");
                _pheonixWands--;
            }
            else if (itemToSell == '2') 
            {
                Console.WriteLine("Gratuler du kjøpte en oak wand!");
                _oakWands--;
            }

            else if (itemToSell == '3')
            {
                Console.WriteLine("Gratulerer du kjøpte en rotte!");
                _rat--;
            }

            else if (itemToSell == '4')
            {
                Console.WriteLine("Gratulerer du kjøpte en katt!");
                _cat--;
            }
                
                
        }

    }
}
