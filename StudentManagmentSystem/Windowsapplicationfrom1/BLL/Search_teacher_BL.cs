using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.DAL.DAO;

namespace WindowsFormsApplication1.BLL
{
    class Search_teacher_BL
    {
        public DataTable search_TeacherANDsendToDAL(SearchTeacher aST)
        {
            DataTable result = null;
            if (aST.TID == "" && aST.Name == "" && aST.Desegnation == "" && aST.Depertment == "" && aST.CourseAdvisor == "" && aST.CouncellingHour == "" && aST.Salary == 0 && aST.ContactNo == "" && aST.Adress == "")
            {
                return result;
            }
            else 
                {
                Search_Teacher_DAL stdal = new Search_Teacher_DAL();
                result = stdal.SearchTeacherDAL(aST);
                return result;

            }
        }
        public DataTable GetExistingFromBL()
        {
            DataTable dt = new DataTable();
            SqlConnection con = DatabaseConnection.Search_teacher();
            string query = "Select * From Teacher";
            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            adp.Fill(dt);
            return dt;
        }
    }
}

