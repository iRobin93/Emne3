using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyreTransplantasjon
{
    internal class Nyre
    {
        public string Id { get; private set; }
        public int Quality { get; private set; }


        public Nyre(string id, int quality)
        {
            Id = id;
            Quality = quality;
        }
    }
}
