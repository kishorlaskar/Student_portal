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
    public partial class Search_Teacher_Info : Form
    {
        public Search_Teacher_Info()
        {
            InitializeComponent();
            this.PopulateDataGrideview();
            searchbutton.Enabled = true;
            clearbutton.Enabled = true;
            idtextBox.Text = "";
            nametextBox.Text = "";
            desegnationtextBox.Text = "";
            depertmenttextBox.Text = "";
            courseadvisorcomboBox.Text = "";
            councellinghourtextBox.Text = "";
            salarytextBox.Text = "";
            adresstextBox.Text = "";
            contactnotextBox.Text = "";
            this.ActiveControl = idtextBox;


        }
        public void PopulateDataGrideview()
        {
            Search_teacher_BL SearchTe = new Search_teacher_BL();
            DataTable dt = new DataTable();
            dt = SearchTe.GetExistingFromBL();
            teachersearchinfodataGridView.DataSource = dt;

        }

        private void searchTeacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Teacher_Info st = new Search_Teacher_Info();
            st.Show();
            this.Hide();
        }

        private void searchStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Student_Info search = new Search_Student_Info();
            search.Show();
            this.Hide();
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RESULTUI aResult = new RESULTUI();
            aResult.Show();
            this.Hide();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account AccountUI = new Account();
            AccountUI.Show();
            this.Hide();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teachers teacherUI = new Teachers();
            teacherUI.Show();
            this.Hide();
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

        private void backToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CoursesU ad = new CoursesU();
            ad.Show();
            this.Hide();
        }

        private void Search_Teacher_Info_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            searchbutton.Enabled = true;
            clearbutton.Enabled = true;
            idtextBox.Text = "";
            nametextBox.Text = "";
            desegnationtextBox.Text = "";
            depertmenttextBox.Text = "";
            courseadvisorcomboBox.Text = "";
            councellinghourtextBox.Text = " ";
            salarytextBox.Text = "";
            adresstextBox.Text = "";
            contactnotextBox.Text = "";


        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            SearchTeacher st = new SearchTeacher();
            st.TID = idtextBox.Text;
            st.Name = nametextBox.Text;
            st.Desegnation = desegnationtextBox.Text;
            st.Depertment = depertmenttextBox.Text;
            st.CouncellingHour = councellinghourtextBox.Text;
            st.CourseAdvisor = courseadvisorcomboBox.Text;
            st.ContactNo = contactnotextBox.Text;
            st.Adress = adresstextBox.Text;
            st.Salary = 0;
            float.TryParse(salarytextBox.Text, out st.Salary);
            Search_teacher_BL steacher = new Search_teacher_BL();
            DataTable result = steacher.search_TeacherANDsendToDAL(st);
            if (result != null)
            {
                teachersearchinfodataGridView.DataSource = result;
                idtextBox.Text = "";
                nametextBox.Text = "";
                desegnationtextBox.Text = "";
                depertmenttextBox.Text = "";
                courseadvisorcomboBox.Text = "";
                councellinghourtextBox.Text = "";
                salarytextBox.Text = "";
                adresstextBox.Text = "";
                contactnotextBox.Text = "";
            }
            else {
                MessageBox.Show("AN Error Has Been Occured!!!");
            }

        }

        private void teachersearchinfodataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            teachersearchinfodataGridView.ClearSelection();
                idtextBox.Text = "";
            nametextBox.Text = "";
            desegnationtextBox.Text = "";
            depertmenttextBox.Text = "";
            courseadvisorcomboBox.Text = "";
            councellinghourtextBox.Text = "";
            salarytextBox.Text = "";
            adresstextBox.Text = "";
            contactnotextBox.Text = "";
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Application.Exit();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Students studentsUI = new Students();
            studentsUI.Show();
            this.Hide();

        }

        private void courseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CourseO aC = new CourseO();
            aC.Show();
            this.Hide();
        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Teachers teacherUI = new Teachers();
            teacherUI.Show();
            this.Hide();
        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Account AccountUI = new Account();
            AccountUI.Show();
            this.Hide();
        }

        private void resultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RESULTUI ares = new RESULTUI();
            ares.Show();
            this.Hide();
        }

        private void searchStudentInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search_Student_Info search = new Search_Student_Info();
            search.Show();
            this.Hide();
        }

        private void searchTeacherInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Search_Teacher_Info st = new Search_Teacher_Info();
            st.Show();
            this.Hide();
        }

        private void backToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CoursesU ac = new CoursesU();
            ac.Show();
            this.Hide();

        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void idtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                nametextBox.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
            }
            
        }

        private void nametextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                desegnationtextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                 idtextBox.Focus();

            }
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
            }

        }

        private void desegnationtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                depertmenttextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                nametextBox.Focus();

            }
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
            }
        }

        private void depertmenttextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
               contactnotextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                desegnationtextBox.Focus();

            }
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
            }
        }

        private void contactnotextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
               courseadvisorcomboBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                depertmenttextBox.Focus();

            }
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
            }
        }

        private void courseadvisorcomboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                councellinghourtextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                contactnotextBox.Focus();

            }
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
            }
        }

        private void councellinghourtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                salarytextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                courseadvisorcomboBox.Focus();

            }
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
            }
        }

        private void salarytextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                adresstextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                councellinghourtextBox.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
            }
        }

        private void adresstextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                adresstextBox.Focus();

            }
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
            }
        }

        private void searchbutton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
               clearbutton.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                searchbutton.Focus();

            }
        }

        private void clearbutton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                searchbutton.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                adresstextBox.Focus();

            }
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

        private void signOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label11.Text = DateTime.Now.ToString("T");
        }
    }
}
