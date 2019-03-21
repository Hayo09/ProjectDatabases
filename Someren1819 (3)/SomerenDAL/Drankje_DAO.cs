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
    public class Drankje_DAO : Base
    {
        public List<Drankje> Db_Get_Drankjes()
        {
            string query = "SELECT Drankjes_ID, DrankjeNaam, VerkoopPrijs, Voorraad FROM Drankje WHERE Voorraad > 1 AND VerkoopPrijs > 1 ORDER BY Voorraad, VerkoopPrijs";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Drankje> ReadTables(DataTable dataTable)
        {
            List<Drankje> drankjes = new List<Drankje>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drankje drankje = new Drankje()
                {
                    Drankjes_ID = (int)dr["Drankjes_ID"],
                    DrankjeNaam = (String)(dr["DrankjeNaam"].ToString()),
                    DrankjePrijs = (int)(dr["VerkoopPrijs"]),
                    Voorraad = (int)(dr["Voorraad"])
                };
                drankjes.Add(drankje);
            }
            return drankjes;
        }
        public void ChangeVoorraad(int drankjeID, int drankjeVoorraad)
        {
            string query = "UPDATE Drankje SET Voorraad = " + drankjeVoorraad + " WHERE Drankjes_ID = " + drankjeID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
