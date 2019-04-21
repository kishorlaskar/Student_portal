using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.BLL;

namespace WindowsFormsApplication1.DAL.DAO
{
    class StudentDA
    {
        public string Message = " ";

        public bool SaveNewStudentToDB(Student aStudent)
        {
            SqlConnection connection = DatabaseConnection.openAnSqlConnection();
            string query = "INSERT INTO Student VALUES('" + aStudent.Name + "','" + aStudent.Id + "'," + aStudent.Age + ",'" + aStudent.Faculty + "','" + aStudent.ParmanentAdress + "','" + aStudent.PresentAdress + "','" + aStudent.Gender
            + "','" + aStudent.ContactNo + "','" + aStudent.Bloodgroup + "')";
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
        public bool UpdateNewStudentToDB(Student aStudent)
        {
            SqlConnection connection = DatabaseConnection.openAnSqlConnection();
            string query = "Update Student SET Name ='" + aStudent.Name + "',Age = " + aStudent.Age + ",Faculty ='" + aStudent.Faculty + "', ParmanentAdress = '" + aStudent.ParmanentAdress + "', PresentAdress ='" + aStudent.PresentAdress + "', Gender ='" + aStudent.Gender
            + "',ContactNo = '" + aStudent.ContactNo + "',BloodGroup = '" + aStudent.Bloodgroup + "' Where  Id ='" + aStudent.Id + "' ";
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
        public bool DeleteAStudentFromDB(Student aStudent)
        {
            SqlConnection connection = DatabaseConnection.openAnSqlConnection();
            string query = "DELETE FROM Student WHERE Id ='" + aStudent.Id + "'";
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



        public DataTable GetExistingStudentFromDB()

        {

            DataTable dt = new DataTable();
            SqlConnection connection = DatabaseConnection.openAnSqlConnection();
            string query = " Select * from Student";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;





        }
    }
}

