using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAL.DAO;

namespace WindowsFormsApplication1.DAL
{
    class TeacherInfoDAL
    {
        public DataTable Show_TeacherInfoDAL()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = DatabaseConnection.openSecondeSqlConnection();
            string query = "Select TID, Name,CourseAdvisor,ContactNo From Teacher";
            SqlCommand cm = new SqlCommand(query,connection);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cm;
            adpt.Fill(dt);
            return dt;
        }
      
    }
}
