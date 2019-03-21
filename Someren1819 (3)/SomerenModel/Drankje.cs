using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drankje
    {
        public int Drankjes_ID { get; set; }
        public string DrankjeNaam { get; set; }
        public int DrankjePrijs { get; set; }
        public double BTW { get; set; }
        public int Voorraad { get; set; }
    }
}
