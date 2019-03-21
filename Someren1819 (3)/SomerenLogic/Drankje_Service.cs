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
            return drankje;
        }

    }
}
