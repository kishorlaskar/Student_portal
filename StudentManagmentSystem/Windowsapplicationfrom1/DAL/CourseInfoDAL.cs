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
    class CourseInfoDAL
    {
        public DataTable Show_CourseInfoDAL()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = DatabaseConnection.openAnanotherSqlConnection();
            string query = "Select CID,CourseName,CourseCredit From CoursesInformation";
            SqlCommand cm = new SqlCommand(query, connection);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cm;
            adpt.Fill(dt);
            return dt;
        }

    }
}
