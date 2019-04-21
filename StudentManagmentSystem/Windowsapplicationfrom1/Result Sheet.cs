using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Result_Sheet : Form
    {
        public Result_Sheet()
        {
            InitializeComponent();
        }

        private void resultbutton_Click(object sender, EventArgs e)
        { 
            SqlConnection connection = new SqlConnection();
            string Link = @"Data Source = DESKTOP-6LMCH95\SQLEXPRESS; DataBase = SMS;Integrated security = SSPI";
            connection.ConnectionString = Link;
            connection.Open();
            string query = "Select * From Result";
           // string query = "Select * From Result WHERE ID = '"+idtextBox.Text+"'";
            SqlCommand cmda = new SqlCommand(query,connection);
            SqlDataAdapter sad = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sad.SelectCommand = cmda;
            sad.Fill(dt);

            ResultCrystalReport1 aRe = new ResultCrystalReport1();
            aRe.SetDataSource(dt);
            crystalReportViewer1.ReportSource = aRe; 
             


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoursesU ac = new CoursesU();
            ac.Show();
            this.Hide();
        }
    }
}
