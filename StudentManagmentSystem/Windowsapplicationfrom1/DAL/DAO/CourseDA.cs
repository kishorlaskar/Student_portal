using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DAL.DAO
{
    class CourseDA
    {
        
        public string Message = " ";
   //     private object aCoursesUI;

        public bool SaveNewCourseToDB(CourseO  aCoursesInformation)
        {
            SqlConnection connection = DatabaseConnection.openAnanotherSqlConnection();
            string query = "INSERT INTO CoursesInformation VALUES('" + aCoursesInformation.Name+ "','" + aCoursesInformation.Id + "','" + aCoursesInformation.Credit + "','" + aCoursesInformation.Semister + "','" + aCoursesInformation.Teacher + "'," + aCoursesInformation.CourseFee+")";
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

       


        //public bool UpdateNewStudentToDB(Student aStudent)
        //{
        //    SqlConnection connection = DatabaseConnection.openAnSqlConnection();
        //    string query = "Update Student SET Name ='" + aStudent.Name + "',Age = " + aStudent.Age + ",Faculty ='" + aStudent.Faculty + "', ParmanentAdress = '" + aStudent.ParmanentAdress + "', PresentAdress ='" + aStudent.PresentAdress + "', Gender ='" + aStudent.Gender
        //    + "',ContactNo = '" + aStudent.ContactNo + "',BloodGroup = '" + aStudent.Bloodgroup + "' Where  Id ='" + aStudent.Id + "' ";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    int rowsAffected = command.ExecuteNonQuery();
        //    if (rowsAffected == 1)
        //    {
        //        command.Dispose();
        //        return true;
        //    }
        //    else
        //    {
        //        command.Dispose();
        //        return false;
        //    }

        //}
        //public bool DeleteAStudentFromDB(Student aStudent)
        //{
        //    SqlConnection connection = DatabaseConnection.openAnSqlConnection();
        //    string query = "DELETE FROM Student WHERE Id ='" + aStudent.Id + "'";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    int rowsAffected = command.ExecuteNonQuery();
        //    if (rowsAffected == 1)
        //    {
        //        command.Dispose();
        //        return true;
        //    }
        //    else
        //    {
        //        command.Dispose();
        //        return false;
        //    }

        //}
        public bool UpdateNewCourseToDB(CourseO aCoursesInformation)
        {
            SqlConnection connection = DatabaseConnection.openAnanotherSqlConnection();
            string query = "Update CoursesInformation SET CourseName ='" + aCoursesInformation.Name + "',  CourseCredit = '" + aCoursesInformation.Credit + "', Semister ='" + aCoursesInformation.Semister + "',Teacher = '" + aCoursesInformation.Teacher + "', CourseFee = " + aCoursesInformation.CourseFee + " where CID='"+aCoursesInformation .Id+"' ";
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
        public bool DeletACourseFromDB(CourseO aCoursesInformation)
        {
            SqlConnection connection = DatabaseConnection.openAnanotherSqlConnection();
            string query = "DELETE  CoursesInformation WHERE CId ='" + aCoursesInformation.Id + "'"; 
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


        public DataTable GetExistingCoursesFromDB()

        {

            DataTable dt = new DataTable();
            SqlConnection connection = DatabaseConnection.openAnanotherSqlConnection();
            string query = " Select * from CoursesInformation";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            adapter.Dispose(); 
            return dt;





        }

        internal bool DeletACourseFromDB(object aCoursesInformation)
        {
            throw new NotImplementedException();
        }
    }
}

 