using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DAL.DAO
{
    class AccountDA
    {
        public bool SaveANewAccountToDB(Accounts aAccount)
        {
            SqlConnection connection = DatabaseConnection.OpenAccountSqlConnection();
            string query = "INSERT INTO Account VALUES('" + aAccount.AID + "','" + aAccount.LibraryFee + "','" + aAccount.SemisterFee + "','" + aAccount.TotalPaid + "','" + aAccount.Waiver + "','" + aAccount.LabratoreyFee + "','" + aAccount.TransPortFee + "','" + aAccount.AdmissonFee + "','" + aAccount.ExtraCarriculamFee + "','" + aAccount.Due + "','" + aAccount.TutionFee + "')";

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
        public bool UpdateANewAccountToDB(Accounts aAccount)
        {
            SqlConnection connection = DatabaseConnection.OpenAccountSqlConnection();
            string query = "UPDATE  Account SET LibraryFee = '" + aAccount.LibraryFee + "',SemisterFee ='" + aAccount.SemisterFee + "',TotalPaid = '" + aAccount.TotalPaid + "',Waiver = '" + aAccount.Waiver + "',LabretoryFee = '" + aAccount.LabratoreyFee + "',TransportFee = '" + aAccount.TransPortFee + "',AdmissonFee = '" + aAccount.AdmissonFee + "',ExtraCarriculamFee= '" + aAccount.ExtraCarriculamFee + "',Due = '" + aAccount.Due + "',TutionFee = '" + aAccount.TutionFee + "'  WHERE AID ='" + aAccount.AID + "'";

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
        public bool DeleteANewAccountToDB(Accounts aAccount)
        {
            SqlConnection connection = DatabaseConnection.OpenAccountSqlConnection();
            string query = "DELETE From Account WHERE AID ='" + aAccount.AID + "'";

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
        public DataTable GetExistingAccountFromDB()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = DatabaseConnection.OpenAccountSqlConnection();
            string query = "Select * from Account ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;

        }

        // }

        //internal static bool SaveANewAccountToDB(WindowsFormsApplication1.Account accountUI)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
