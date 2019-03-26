using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Transactie
    {
        public Student Student { get; set; }
        public Drankje GewenstDrankje { get; set; }
        public DateTime VerkoopDatum { get; set; }
        public Transactie()
        {
            VerkoopDatum = DateTime.Now.Date;
        }
    }
}
