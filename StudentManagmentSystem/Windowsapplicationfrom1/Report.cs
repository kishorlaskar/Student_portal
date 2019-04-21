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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void showreportbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connction = new SqlConnection();
            string Link = @"Data Source = DESKTOP-6LMCH95\SQLEXPRESS;Database = SMS;Integrated Security = SSPI";
            connction.ConnectionString = Link;
            connction.Open();

            string query = "Select AID,AdmissonFee,SemisterFee,TutionFee,TotalPaid,Due,Waiver From Account";
            SqlCommand cmd = new SqlCommand(query,connction);
            SqlDataAdapter sda = new SqlDataAdapter();
            DataTable dt = new DataTable();
            sda.SelectCommand = cmd;
            sda.Fill(dt);

            AccountCrystalReport1 aCR = new AccountCrystalReport1();
            aCR.SetDataSource(dt);
            crystalReportViewer2.ReportSource = aCR;

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            CoursesU ac = new CoursesU();
            ac.Show();
            this.Hide();
        }
    }
}
