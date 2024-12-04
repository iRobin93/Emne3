using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Studentadministrasjonssystem
{
    internal class Fag
    {
        private string _fagkode;
        private string _fagnavn;
        public int _antallStudiepoeng {  get; private set; }


        public Fag(string fagkode, string fagnavn, int poeng)
        {
            _fagkode = fagkode;
            _fagnavn = fagnavn;
            _antallStudiepoeng = poeng;
        }

        public void writeInfo()
        {
            Console.WriteLine($"Fagkode: {_fagkode}\nfag: {_fagnavn}\nStudiepoeng: {_antallStudiepoeng}");
        }

        public string GetName()
        {
            return _fagnavn;
        }
    }
}
