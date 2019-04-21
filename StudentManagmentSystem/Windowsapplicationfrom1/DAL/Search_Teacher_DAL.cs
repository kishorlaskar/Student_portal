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
    class Search_Teacher_DAL
    {
        public DataTable SearchTeacherDAL(SearchTeacher ateacher)
        {

            string query = "Select * From Teacher";
            string Condition = "";
            bool Condition_joiner = false;
            if (ateacher.TID != "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += "  TId like '%" + ateacher.TID + "%'";
                Condition_joiner = true;
            }
            if (ateacher.Name != "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += "  Name like '%" + ateacher.Name + "%'";
                Condition_joiner = true;
            }
            if (ateacher.Desegnation !="" )
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += "  Desegnation like '%" + ateacher.Desegnation + "%'";
                Condition_joiner = true;
            }
            if (ateacher.Depertment != "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += "  Depertment like '%" + ateacher.Depertment + "%'";
                Condition_joiner = true;
            }
            if (ateacher.Salary !=0)
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += "  Salary like '%" + ateacher.Salary + "%'";
                Condition_joiner = true;
            }
            if (ateacher.CourseAdvisor != "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += "  CourseAdvisor like '%" + ateacher.CourseAdvisor + "%'";
                Condition_joiner = true;
            }
            if (ateacher.CouncellingHour != "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += "  CouncellingHour like '%"+ ateacher.CouncellingHour+ "%'";
                Condition_joiner = true;
            }
            if (ateacher.ContactNo != "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += " ContactNo like '%" + ateacher.ContactNo + "%'";
                Condition_joiner = true;
            }
            if (ateacher.Adress!= "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += "  Adress like '%" + ateacher.Adress + "%'";
                Condition_joiner = true;
            }
            if (Condition_joiner)
            {
                query += " WHERE";
            }
            query += Condition;
            SqlConnection connection = DatabaseConnection.Search_teacher();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter ada = new SqlDataAdapter();
            DataTable dt = new DataTable();
            ada.SelectCommand = command;
           ada.Fill(dt);
            return dt;


        }
        public DataTable GetExistingTeacherFromDB()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection();
            string query = "Select * From Teacher";
            SqlDataAdapter ad = new SqlDataAdapter(query,con);
            ad.Fill(dt);
            return dt;

        }
    }
}
