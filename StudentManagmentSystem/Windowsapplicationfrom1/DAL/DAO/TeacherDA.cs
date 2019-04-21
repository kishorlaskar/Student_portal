using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DAL.DAO
{
    class TeacherDA
    {
        public bool SaveANewTeachertoDB(Teacher aTeacher)
        {
            SqlConnection connection = DatabaseConnection.openSecondeSqlConnection();
            string query = "INSERT INTO Teacher VALUES('" + aTeacher.ID+"','"+aTeacher.Name+"','" +aTeacher.Desegnation+"','" + aTeacher.Depertment+"','" + aTeacher.ContactNo+ "','" +aTeacher.CourseAdvisor+"','" + aTeacher.CouncellingHour+ "'," + aTeacher.Salary + ",'" + aTeacher.Adress + "')";
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
        public bool UpdateANewTeachertoDB(Teacher aTeacher)
        {
            SqlConnection connection = DatabaseConnection.openSecondeSqlConnection();
            string query = "UPDATE Teacher Set Name = '" + aTeacher.Name + "', Desegnation ='" + aTeacher.Desegnation + "',Depertment = '" + aTeacher.Depertment + "',ContactNo = '" + aTeacher.ContactNo + "',CourseAdvisor = '" + aTeacher.CourseAdvisor + "',CouncellingHour = '" + aTeacher.CouncellingHour + "',Salary = '" + aTeacher.Salary + "',Adress = '" + aTeacher.Adress + "' WHERE TID = '" + aTeacher.ID + "'";
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
        public bool DeleteANewTeachertoDB(Teacher aTeacher)
        {
            SqlConnection connection = DatabaseConnection.openSecondeSqlConnection();
            string query = "DELETE  Teacher WHERE TID = '" + aTeacher.ID + "'";
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

        public DataTable GetExistingTeacherToDB()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = DatabaseConnection.openSecondeSqlConnection();
            string query = "Select * from Teacher ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;

        }

        //internal bool SaveANewTeachertoDB(WindowsFormsApplication1.Teacher aTeacher)
        //{
        //  //throw new NotImplementedException();
        //}

        //internal bool SaveANewTeachertoDB(WindowsFormsApplication1.Teacher aTeacher)
        //{
        //    throw new NotImplementedException();
        //}
    }
    }

