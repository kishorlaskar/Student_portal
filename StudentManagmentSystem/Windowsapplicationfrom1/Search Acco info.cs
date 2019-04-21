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
    public partial class Search_Acco_info : Form
    {
        public Search_Acco_info()
        {
            InitializeComponent();
            this.PopulateDataGrideview();
            gobutton.Enabled = true;
            Accountidtextbox.Text = "";
        }
        private void PopulateDataGrideview()
        {
            Search_Acco_BL searchAcobl = new Search_Acco_BL();
            DataTable dt = new DataTable();
            dt = searchAcobl.GetExistingSearchAccoFromBL();
            searchaccodataGridView1.DataSource = dt;
        }

        private void Search_Acco_info_Load(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoursesU asign = new CoursesU();
            asign.Show();
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

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
;        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accounts aco = new Accounts();
            aco.AID = Accountidtextbox.Text;
            Search_Acco_BL acobl = new Search_Acco_BL();
            DataTable result = acobl.Search_ACCOANDSendToDAL(aco);
            if (result != null)
            {
                searchaccodataGridView1.DataSource = result;
                Accountidtextbox.Text ="";
            }
            else
            {
                MessageBox.Show("An Error Has been Occured");
            }

        }

        private void searchResultInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Result_Info ri = new Search_Result_Info();
            ri.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("T");
        }
    }
}
