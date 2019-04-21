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
    class Search_Student_DAL {
     

        public DataTable SearchStudentDAL(Search aSearch)
        {
            string query = "Select * From Student";
            string Condition = "";
            bool Condition_joiner = false;
            if (aSearch.Id != "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += " Id like '%" + aSearch.Id + "%'";
                Condition_joiner = true;
            }
            if (aSearch.Name != "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += "  Name like '%" + aSearch.Name + "%'";
                Condition_joiner = true;
            }
            if (aSearch.Age != 0)
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += "  Age like '%" + aSearch.Age + "%'";
                Condition_joiner = true;
            }
            if (aSearch.Faculty != "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += "  Faculty like '%" + aSearch.Faculty + "%'";
                Condition_joiner = true;
            }
            if (aSearch.ParmanentAdress != "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += "  ParmanentAdress like '%" + aSearch.ParmanentAdress + "%'";
                Condition_joiner = true;
            }
            if (aSearch.PresentAdress != "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += "  PresentAdress like '%" + aSearch.PresentAdress + "%'";
                Condition_joiner = true;
            }
            if (aSearch.Gender != "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += " Gender = '"+aSearch.Gender + "'";
                Condition_joiner = true;
            }
            if (aSearch.ContactNo != "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += " ContactNo like '%" + aSearch.ContactNo + "%'";
                Condition_joiner = true;
            }
            if (aSearch.Bloodgroup != "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += " BloodGroup like '%" + aSearch.Bloodgroup + "%'";
                Condition_joiner = true;
            }
            if (Condition_joiner)
            {
                query += " WHERE";
            }
            query += Condition;
            SqlConnection connection = DatabaseConnection.Search_Student();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter Adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            Adp.SelectCommand = command;
            Adp.Fill(dt);
            return dt;


        }
        public DataTable GetExisingSearchDAL()
        {
            DataTable dt = new DataTable();
            SqlConnection sql = DatabaseConnection.Search_Student();
            string query = "Select * From Student";
            SqlDataAdapter adp = new SqlDataAdapter(query, sql);
            adp.Fill(dt);
            return dt;
     
        }



    }
      
    }
    //SqlConnection connection = DatabaseConnection.Search_Student();
    //string query = "Insert Into  Student VALUES('" + aSearch.Id + "','" + aSearch.Name + "','" + aSearch.Age + "','" + aSearch.Faculty + "','" + aSearch.ParmanentAdress + "','" + aSearch.PresentAdress + "','" + aSearch.Gender + "','" + aSearch.ContactNo + "','" + aSearch.Bloodgroup + "') ";
    //
    //int rowsAffected = command.ExecuteNonQuery();
    //    if (rowsAffected == 1)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }

