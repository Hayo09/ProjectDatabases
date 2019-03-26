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
    public class Student_DAO : Base
    {
      
        public List<Student> Db_Get_All_Students()
        {
            string query = "SELECT StudentNummer, Naam, GeboorteDatum FROM Student";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Student Db_Get_Student_By_Name(string naam)
        {
            string query = "SELECT StudentNummer, Naam, GeboorteDatum FROM Student WHERE Naam = '" + naam +  "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            Student students = ReadTable(ExecuteSelectQuery(query, sqlParameters));
            return students;
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = (int)dr["StudentNummer"],
                    Name = (String)(dr["Naam"].ToString()),
                    BirthDate = (DateTime)(dr["GeboorteDatum"])
                };
                students.Add(student);
            }
            return students;
        }

        private Student ReadTable(DataTable dataTable)
        {
            DataRow dr = dataTable.Rows[0];
            Student student = new Student()
            {
                Number = (int)dr["StudentNummer"],
                Name = (String)(dr["Naam"].ToString()),
                BirthDate = (DateTime)(dr["GeboorteDatum"])
            };
            return student;
        }

    }
}
