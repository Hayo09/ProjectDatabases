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
    public class Drankje_Service
    {
        Drankje_DAO drankje_db = new Drankje_DAO();

        public List<Drankje> GetDrankjes()
        {
            List<Drankje> drankje = drankje_db.Db_Get_Drankjes();
            foreach(Drankje d in drankje)
            {
                if(d.Voorraad >= 10)
                {
                    d.DrankjeNaam = d.DrankjeNaam + " ✓";
                }
                else
                {
                    d.DrankjeNaam = d.DrankjeNaam + " ✘";
                }
            }
            return drankje;
        }

        public List<Drankje> GetAllDrankjes()
        {
            List<Drankje> drankjes = drankje_db.Db_Get_All_Drankjes();
            return drankjes;
        }

        public Drankje GetDrankjeByName(string naam)
        {
            Drankje drankje = drankje_db.Db_Get_Drankje_By_Name(naam);
            return drankje;
        }

        public void ChangeVoorraad(int drankjeID, int drankjeVoorraad)
        {
            drankje_db.ChangeVoorraad(drankjeID, drankjeVoorraad);
        }

    }
}
