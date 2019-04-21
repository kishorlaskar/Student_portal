using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DAL.DAO
{
    class ResultDA
    {
        public  bool  SaveANewResultToDB(Result aResult)
        {
            SqlConnection connection = DatabaseConnection.openResultSqlConnection();
            string query = "INSERT Into Result VALUES('" + aResult.ID+ "','" +aResult.Name+ "','" + aResult.Depertment + "','" + aResult.CourseTitle + "','" + aResult.CourseCode + "','" + aResult.Gread + "'," + aResult.SGPA + ")";
            SqlCommand command = new SqlCommand(query,connection);
            int rowsAffected = command.ExecuteNonQuery();
            if(rowsAffected ==1)
            {
                command.Dispose();
                return true;
            }
            else
            {
                command.Dispose();
                return false;
            }
        } 
        public bool UpdateANewResultToDB(Result aResult)
        {
            SqlConnection connection = DatabaseConnection.openResultSqlConnection();

            //string query = "UPDATE  Result VALUES('" + aResult.ID + "','" + aResult.Name + "','" + aResult.Depertment + "','" + aResult.CourseTitle + "','" + aResult.CourseCode + "','" + aResult.Gread + "'," + aResult.SGPA + ")";
            string query = "UPDATE Result Set  Name = '" + aResult.Name + "',Depertment = '" + aResult.Depertment + "',CourseTitle = '" + aResult.CourseTitle + "',CourseCode = '" + aResult.CourseCode + "',Gread = '" + aResult.Gread + "',SGPA = '" + aResult.SGPA + "' WHERE ID = '" + aResult.ID + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                command.Dispose();
                return true;
            }
            else
            {
                command.Dispose();
                return false;
            }
        }
        public bool DeleteANewResultToDB(Result aResult)
        {
            SqlConnection connection = DatabaseConnection.openResultSqlConnection();
            string query = "DELETE From Result Where ID = '"+aResult.ID+"' ";
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected == 1)
            {
                command.Dispose();
                return true;
            }
            else
            {
                command.Dispose();
                return false;
            }
        }
        public DataTable GetExistingResultFromDB()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = DatabaseConnection.openResultSqlConnection();
            string query = "Select * from Result ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;

        }
        public DataTable GetsCourseTitle(Result aResult)
        {
            SqlConnection connection = DatabaseConnection.openResultSqlConnection();
            string query = "Select CourseName From CoursesInformation Where CID = '" + aResult.CourseCode + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;
        }
    }
}
