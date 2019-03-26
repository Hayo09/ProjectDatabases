using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class Transactie_Service
    {
        Transactie_DAO transactie_db = new Transactie_DAO();

        public void InstertTransactie(Transactie transactie)
        {
            transactie_db.InsertTransactie(transactie);
        }
        public void UpdateVoorraad(Transactie transactie)
        {
            transactie_db.UpdateVoorraad(transactie);
        }
    }
}
