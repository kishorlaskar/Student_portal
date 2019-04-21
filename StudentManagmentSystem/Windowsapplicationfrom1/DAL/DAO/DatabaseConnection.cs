using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DAL.DAO
{
    class DatabaseConnection
    {

        public static SqlConnection openAnSqlConnection()
        {
        string connctionString = @" Data Source = DESKTOP-6LMCH95\SQLEXPRESS; Database = SMS; Integrated Security = SSPI";
        SqlConnection connction = new SqlConnection();
        connction.ConnectionString = connctionString;
            connction.Open();
            return connction;
       }

        public static SqlConnection openAnanotherSqlConnection()
        {
            string connctionString = @" Data Source = DESKTOP-6LMCH95\SQLEXPRESS; Database = SMS; Integrated Security = SSPI";
            SqlConnection connction = new SqlConnection();
            connction.ConnectionString = connctionString;
            connction.Open();
            return connction;
        }

        public static SqlConnection openSecondeSqlConnection()
        {
            string connctionString = @" Data Source = DESKTOP-6LMCH95\SQLEXPRESS; Database = SMS; Integrated Security = SSPI";
            SqlConnection connction = new SqlConnection();
            connction.ConnectionString = connctionString;
            connction.Open();
            return connction;
        }
      
        public static SqlConnection openResultSqlConnection()
        {
            string connectionstring = @"Data Source =DESKTOP-6LMCH95\SQLEXPRESS;Database =SMS;Integrated Security = SSPI";
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = connectionstring;
            Connection.Open();
            return Connection;
        }

        public static SqlConnection OpenAccountSqlConnection()
        {
            string connectionstring = @"Data Source =DESKTOP-6LMCH95\SQLEXPRESS;Database =SMS;Integrated Security = SSPI";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionstring;
            connection.Open();
            return connection;
        }
        public static SqlConnection Search_Student()
        {
            string connectionstring = @"Data Source = DESKTOP-6LMCH95\SQLEXPRESS; Database = SMS; Integrated Security = SSPI";
            SqlConnection connction = new SqlConnection();
            connction.ConnectionString = connectionstring;
            connction.Open();
            return connction;
        }
        public static SqlConnection Search_teacher()
        {
            string connectionstring = @"Data Source = DESKTOP-6LMCH95\SQLEXPRESS; Database = SMS; Integrated Security = SSPI";
            SqlConnection connction = new SqlConnection();
            connction.ConnectionString = connectionstring;
            connction.Open();
            return connction;
        }
        //public static SqlConnection SearchSqlConnection()
        //{
        //    string connectionstring = @"Data Source =DESKTOP-6LMCH95\SQLEXPRESS;Database =SMS;Integrated Security = SSPI";
        //    SqlConnection connection = new SqlConnection();
        //    connection.ConnectionString = connectionstring;
        //    connection.Open();
        //    return connection;
        //}

    }
}
