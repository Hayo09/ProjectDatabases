using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Transactie_DAO : Base
    {
        
        
        public void InsertTransactie(Transactie transactie)
        {
            string datum = transactie.VerkoopDatum.ToShortDateString();
            string query = "INSERT INTO Consumeert(StudentNummer, Drankjes_ID, Aantal, VerkoopDatum) VALUES('" + transactie.Student.Number + "', '" + transactie.GewenstDrankje.Drankjes_ID + "', '1', '"+ datum+ "')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}