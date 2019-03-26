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

        public List<Drankje> Db_Get_All_Drankjes()
        {
            string query = "SELECT Drankjes_ID, DrankjeNaam, VerkoopPrijs, Voorraad FROM Drankje";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Drankje Db_Get_Drankje_By_Name(string naam)
        {
            string query = "SELECT Drankjes_ID, DrankjeNaam, VerkoopPrijs, Voorraad FROM Drankje WHERE DrankjeNaam = '" + naam + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            Drankje drankjes = ReadTable(ExecuteSelectQuery(query, sqlParameters));
            return drankjes;
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

        private Drankje ReadTable(DataTable dataTable)
        {
            DataRow dr = dataTable.Rows[0];
            Drankje drankje = new Drankje()
            {
                Drankjes_ID = (int)dr["Drankjes_ID"],
                DrankjeNaam = (String)(dr["DrankjeNaam"].ToString()),
                DrankjePrijs = (int)(dr["VerkoopPrijs"]),
                Voorraad = (int)(dr["Voorraad"])
            };
            return drankje;
        }

        public void ChangeVoorraad(int drankjeID, int drankjeVoorraad)
        {
            string query = "UPDATE Drankje SET Voorraad = " + drankjeVoorraad + " WHERE Drankjes_ID = " + drankjeID;
            
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
