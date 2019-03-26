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
    public class Omzetrapportage_DAO : Base
    {
        public List<Omzetrapportage> Db_AfzetOmzet()
        {
            string query = "SELECT C.StudentNummer, C.Drankjes_ID, C.Aantal, C.VerkoopDatum, D.VerkoopPrijs FROM Consumeert AS C JOIN Drankje AS D ON C.Drankjes_ID = D.Drankjes_ID "; 
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Omzetrapportage> Db_AantalKlanten()
        {
            string query = "SELECT S.StudentNummer, C.Transactie_ID FROM Student AS S JOIN Consumeert AS C ON S.studentNummer = C.StudentNummer "; 
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Omzetrapportage> ReadTable(DataTable dataTable)
        {
            List<Omzetrapportage> omzetrapportage = new List<Omzetrapportage>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Omzetrapportage omzetrapport = new Omzetrapportage()
                {
                    StudentNummer = (int)dr["StudentNummer"],
                    DrankjeID = (int)dr["Drankjes_ID"],
                    Aantal = (int)dr["Aantal"],
                    VerkoopPrijs = (int)dr["VerkoopPrijs"],
                    VerkoopDatumDrankje = (string)dr["VerkoopDatum"]
                };
                omzetrapportage.Add(omzetrapport);
            }
            return omzetrapportage;
        }

        private List<Omzetrapportage> ReadTables(DataTable dataTable)
        {
            List<Omzetrapportage> omzetrapportage = new List<Omzetrapportage>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Omzetrapportage omzetrapport = new Omzetrapportage()
                {
                    StudentNummer = (int)dr["StudentNummer"],
                    transactieID = (int)dr["Transactie_ID"],


                };
                omzetrapportage.Add(omzetrapport);
            }
            return omzetrapportage;
        }
    }
}
