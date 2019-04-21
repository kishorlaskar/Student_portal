using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.BLL;
using WindowsFormsApplication1.DAL.DAO;

namespace WindowsFormsApplication1
{
    public partial class Search_Result_Info : Form
    {
        public Search_Result_Info()
        {
            InitializeComponent();
            this.PopulateDatagrideview();
            gobutton.Enabled = true;
            searchResulttextBox.Text = "";

        }
        public void PopulateDatagrideview()
        {
            Search_Result_BL searchresbl = new Search_Result_BL();
            DataTable dt = new DataTable();
            dt = searchresbl.GetExistingSearchRESFromBL();
            searchresultdataGridView1.DataSource = dt;
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Students studentsUI = new Students();
            studentsUI.Show();
            this.Hide();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseO CoursesUI = new CourseO();
            CoursesUI.Show();
            Hide();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teachers teacherUI = new Teachers();
            teacherUI.Show();
            this.Hide();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account AccountUI = new Account();
            AccountUI.Show();
            this.Hide();
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RESULTUI aResult = new RESULTUI();
            aResult.Show();
            this.Hide();
        }

        private void searchStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Student_Info search = new Search_Student_Info();
            search.Show();
            this.Hide();
        }

        private void searchTeacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Teacher_Info st = new Search_Teacher_Info();
            st.Show();
            this.Hide();
        }

        private void searchAccoInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Acco_info se = new Search_Acco_info();
            se.Show();
            this.Hide();
        }

        private void searchResultInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Result_Info ri = new Search_Result_Info();
            ri.Show();
            this.Hide();
        }

        private void gobutton_Click(object sender, EventArgs e)
        {
            Result aResult = new Result();
            aResult.ID = searchResulttextBox.Text;
            Search_Result_BL rbl= new Search_Result_BL();
            DataTable result = rbl.Search_RESANDSendToDAL(aResult);
            if (result != null)
            {
                searchresultdataGridView1.DataSource = result;
                searchResulttextBox.Text = "";
            }
            else
            {
                MessageBox.Show("An Error Has been Occured");
            }

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoursesU ac = new CoursesU();
            ac.Show();
            this.Hide();

                 
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("T");
        }

        private void Search_Result_Info_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
