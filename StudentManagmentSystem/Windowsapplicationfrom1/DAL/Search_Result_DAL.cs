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
    class Search_Result_DAL
    {
        public DataTable SearchACCODAL(Result aRes)
        {
            string query = "Select * From Result";
            string Condition = "";
            bool Condition_joiner = false;
            if (aRes.ID != "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += " ID like '%" + aRes.ID + "%'";
                Condition_joiner = true;
            }
            if (Condition_joiner)
            {
                query += " WHERE";
            }
            query += Condition;
            SqlConnection connection = DatabaseConnection.openResultSqlConnection();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter Adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            Adp.SelectCommand = command;
            Adp.Fill(dt);
            return dt;
        }
        public DataTable GetExisingSearchResultinfo()
        {
            DataTable dt = new DataTable();
            SqlConnection sql = DatabaseConnection.openResultSqlConnection();
            string query = "Select * From Result";
            SqlDataAdapter adp = new SqlDataAdapter(query, sql);
            adp.Fill(dt);
            return dt;

        }
    }
}
