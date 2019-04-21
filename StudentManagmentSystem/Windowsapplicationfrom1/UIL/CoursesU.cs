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

namespace WindowsFormsApplication1
{
    public partial class CoursesU : Form
    {
        public CoursesU()
        {
            InitializeComponent();
           
        }

        private void CoursesUI_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            TeacherInfoBL ateach = new TeacherInfoBL();
            dt = ateach.Show_TeacherInfoBL();
            AlldataGridView.DataSource = dt;

            DataTable dta = new DataTable();
            CourseInfoBL ac = new CourseInfoBL();
            dta = ac.Show_CoureseInfoBL();
            courseinfodataGridView.DataSource = dta;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Students studentsUI = new Students();
            studentsUI.Show();
            this.Hide();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teachers teacherUI = new Teachers();
            teacherUI.Show();
            this.Hide();
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
            sign_In asign = new sign_In();
            asign.Show();
            this.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible=false;
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Students studentsUI = new Students();
            studentsUI.Show();
            this.Hide();
        }

        private void courseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CourseO aC = new CourseO();
            aC.Show();
            this.Hide();
        }

        private void teacherToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Teachers teacherUI = new Teachers();
            teacherUI.Show();
            this.Hide();
        }

        private void accountToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Account AccountUI = new Account();
            AccountUI.Show();
            this.Hide();
        }

        private void resultToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RESULTUI aResult = new RESULTUI();
            aResult.Show();
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

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
                }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("T");
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
        ;

        }

        private void accountReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report aReport = new Report();
            aReport.Show();
            this.Hide();
        }

        private void resultReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Result_Sheet aRes = new Result_Sheet();
            aRes.Show();
            this.Hide();
        }
    }
}
