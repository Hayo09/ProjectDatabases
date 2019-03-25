using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Omzetrapportage_Service
    {
        Omzetrapportage_DAO omzetrapportage_db = new Omzetrapportage_DAO();
        public int afzet = 0;
        public int omzet = 0;
        public int aantalKlanten = 0;

        public List<Omzetrapportage> Afzet(string begin, string eind)
        {
            List<Omzetrapportage> omzetrapportage = omzetrapportage_db.Db_AfzetOmzet(begin, eind);
            
            foreach(Omzetrapportage o in omzetrapportage)
            {
                afzet += o.Aantal;
            }

            return omzetrapportage;
        }

        public List<Omzetrapportage> Omzet(string begin, string eind)
        {
            List<Omzetrapportage> omzetrapportage = omzetrapportage_db.Db_AfzetOmzet(begin, eind);

            foreach (Omzetrapportage o in omzetrapportage)
            {
                omzet += (o.Aantal * o.VerkoopPrijs);
            }

            return omzetrapportage;
        }

        public List<Omzetrapportage> AantalKlanten(string begin, string eind)
        {
            List<Omzetrapportage> omzetrapportage = omzetrapportage_db.Db_AantalKlanten(begin, eind);

            aantalKlanten = omzetrapportage.Count();

            return omzetrapportage;
        }

    }
}
