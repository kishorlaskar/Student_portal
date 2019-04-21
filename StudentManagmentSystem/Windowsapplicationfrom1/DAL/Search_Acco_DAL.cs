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
    class Search_Acco_DAL
    {
        public DataTable SearchACCODAL(Accounts aAcco)
        {
            string query = "Select * From Account";
            string Condition = "";
            bool Condition_joiner = false;
            if (aAcco.AID != "")
            {
                if (Condition_joiner)
                {
                    Condition += "and";
                }

                Condition += " AId like '%" + aAcco.AID + "%'";
                Condition_joiner = true;
            }
                if (Condition_joiner)
                {
                    query += " WHERE";
                }
                query += Condition;
                SqlConnection connection = DatabaseConnection.OpenAccountSqlConnection();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter Adp = new SqlDataAdapter();
                DataTable dt = new DataTable();
                Adp.SelectCommand = command;
                Adp.Fill(dt);
                return dt;
            }
        public DataTable GetExisingSearchAccountinfo()
        {
            DataTable dt = new DataTable();
            SqlConnection sql = DatabaseConnection.OpenAccountSqlConnection();
            string query = "Select * From Account";
            SqlDataAdapter adp = new SqlDataAdapter(query, sql);
            adp.Fill(dt);
            return dt;

        }
    }
      
    }

