using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Omzetrapportage
    {
        public int StudentNummer { get; set; }
        public int DrankjeID { get; set; }
        public int Aantal { get; set; }
        public int VerkoopPrijs { get; set; }
        public int transactieID { get; set; }
        public string VerkoopDatumDrankje { get; set; }
    }
}
