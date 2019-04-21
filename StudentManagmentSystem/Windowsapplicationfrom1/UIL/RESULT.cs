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
using WindowsFormsApplication1.BLL;
using WindowsFormsApplication1.DAL.DAO;

namespace WindowsFormsApplication1
{
    public partial class RESULTUI : Form
    {
        public RESULTUI()
        {
            InitializeComponent();
            this.PopulateDataGrideview();
            saveresultbutton.Enabled = true;
           
            updateresultbutton.Enabled = true;
            deleteresultbutton.Enabled = true;
            clearresultbutton.Enabled = true;
            sidtextBox.Text = " ";
            nametextBox.Text = " ";
            depertmenttextBox.Text = " ";
            coursetitletextBox.Text = " ";
            coursecodetextBox.Text = " ";
            greadcomboBox.Text = " ";
            sgpatextBox.Text = " ";
            this.ActiveControl = sidtextBox;
            sidtextBox.Focus();
        }
        public void PopulateDataGrideview()
        {

            DataTable dt = new DataTable();
            ResultBL ResultBLOBJ = new ResultBL();
            dt = ResultBLOBJ.GetExistingResultBL();
            ResultdataGridView1.DataSource = dt;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void saveresultbutton_Click(object sender, EventArgs e)
        {
            Result aResult = new Result();
            aResult.ID = sidtextBox.Text;
            aResult.Name = nametextBox.Text;
            aResult.Depertment = depertmenttextBox.Text;
            aResult.CourseTitle = coursetitletextBox.Text;
            aResult.CourseCode = coursecodetextBox.Text;
            aResult.Gread = greadcomboBox.Text;
            aResult.SGPA = 0;
            float.TryParse(sgpatextBox.Text, out aResult.SGPA);


            //aResult.SGPA= 0;
            //float.TryParse(sgpatextBox.Text, out aResult.SGPA);
            //aResult.SGPA = sgpatextBox.Text;


            ResultBL ResultBLOBJ = new ResultBL();
            bool result = ResultBLOBJ.ValidANewResultAndSendToDA(aResult);

            if (result)
            {
                MessageBox.Show("Result Has Been Saved");

                this.PopulateDataGrideview();
                saveresultbutton.Enabled = true;
                
                updateresultbutton.Enabled = true;
                deleteresultbutton.Enabled = true;
                clearresultbutton.Enabled = true;
                sidtextBox.Text = " ";
                nametextBox.Text = " ";
                depertmenttextBox.Text = " ";
                coursetitletextBox.Text = " ";
                coursecodetextBox.Text = " ";
                greadcomboBox.Text = " ";
                sgpatextBox.Text = " ";

            }
            else
            {
                MessageBox.Show("RESULT:" + ResultBLOBJ.Message);
            }

        }

        private void updateresultbutton_Click(object sender, EventArgs e)
        {
            Result aResult = new Result();
            aResult.ID = sidtextBox.Text;
            aResult.Name = nametextBox.Text;
            aResult.Depertment = depertmenttextBox.Text;
            aResult.CourseTitle = coursetitletextBox.Text;
            aResult.CourseCode = coursecodetextBox.Text;
            aResult.Gread = greadcomboBox.Text;
            aResult.SGPA = 0;
            float.TryParse(sgpatextBox.Text, out aResult.SGPA);

            ResultBL ResultBLOBJ = new ResultBL();
            bool result = ResultBLOBJ.UpdateANewResultAndSendToDA(aResult);
            if (result)
            {
                MessageBox.Show("Update is Completed");
                this.PopulateDataGrideview();
                updateresultbutton.Enabled = true;
                deleteresultbutton.Enabled = true;
                clearresultbutton.Enabled = true;
                saveresultbutton.Enabled = true;
                
                sidtextBox.Text = " ";
                nametextBox.Text = " ";
                depertmenttextBox.Text = " ";
                coursetitletextBox.Text = " ";
                coursecodetextBox.Text = " ";
                greadcomboBox.Text = " ";
                sgpatextBox.Text = " ";
            }
            else
            {
                MessageBox.Show("RESULT:" + ResultBLOBJ.Message);
            }

        }

        private void deleteresultbutton_Click(object sender, EventArgs e)
        {
            Result aResult = new Result();
            aResult.ID = sidtextBox.Text;
            aResult.Name = nametextBox.Text;
            aResult.Depertment = depertmenttextBox.Text;
            aResult.CourseTitle = coursetitletextBox.Text;
            aResult.CourseCode = coursecodetextBox.Text;
            aResult.Gread = greadcomboBox.Text;
            aResult.SGPA = 0;
            float.TryParse(sgpatextBox.Text, out aResult.SGPA);

            ResultBL ResultBLOBJ = new ResultBL();
            bool result = ResultBLOBJ.DeleteANewResultAndSendToDA(aResult);
            if (result)
            {
                MessageBox.Show("Delete is Completed");
                this.PopulateDataGrideview();
                deleteresultbutton.Enabled = true;
                updateresultbutton.Enabled = true;
                clearresultbutton.Enabled = true;
                saveresultbutton.Enabled = true;
                
                sidtextBox.Text = " ";
                nametextBox.Text = " ";
                depertmenttextBox.Text = " ";
                coursetitletextBox.Text = " ";
                coursecodetextBox.Text = " ";
                greadcomboBox.Text = " ";
                sgpatextBox.Text = " ";
            }
            else
            {
                MessageBox.Show("RESULT:" + ResultBLOBJ.Message);
            }
        }

        private void clearresultbutton_Click(object sender, EventArgs e)
        {
            saveresultbutton.Enabled = true;
            
            updateresultbutton.Enabled = true;
            deleteresultbutton.Enabled = true;
            clearresultbutton.Enabled = true;
            sidtextBox.Text = " ";
            nametextBox.Text = " ";
            depertmenttextBox.Text = " ";
            coursetitletextBox.Text = " ";
            coursecodetextBox.Text = " ";
            greadcomboBox.Text = " ";
            sgpatextBox.Text = " ";

        }

        //private void backbutton_Click(object sender, EventArgs e)
        //{
        //    Courses CoursesUI = new Courses();
        //    CoursesUI.Show();
        //    this.Hide();
        //}

        private void ResultdataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (ResultdataGridView1.SelectedCells.Count > 0)
            {
                int SelectedRowindex = ResultdataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow SelectedRow = ResultdataGridView1.Rows[SelectedRowindex];

                string ID = Convert.ToString(SelectedRow.Cells["ID"].Value);
                string Name = Convert.ToString(SelectedRow.Cells["Name"].Value);
                string Depertment = Convert.ToString(SelectedRow.Cells["Depertment"].Value);
                string CourseTitle = Convert.ToString(SelectedRow.Cells["CourseTitle"].Value);
                string CourseCode = Convert.ToString(SelectedRow.Cells["CourseCode"].Value);
                string Grade = Convert.ToString(SelectedRow.Cells["Gread"].Value);
                string SGPA = Convert.ToString(SelectedRow.Cells["SGPA"].Value);



                sidtextBox.Text = ID;
                nametextBox.Text = Name;
                depertmenttextBox.Text = Depertment;
                coursecodetextBox.Text = CourseCode;
                coursetitletextBox.Text = CourseTitle;
                greadcomboBox.Text = Grade;
                sgpatextBox.Text = SGPA;

                saveresultbutton.Enabled = true;
                
                updateresultbutton.Enabled = true;
                deleteresultbutton.Enabled = true;
                clearresultbutton.Enabled = true;
            }
            }

        private void ResultdataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ResultdataGridView1.ClearSelection();
            saveresultbutton.Enabled = true;
            
            updateresultbutton.Enabled = true;
            deleteresultbutton.Enabled = true;
            clearresultbutton.Enabled = true;
            sidtextBox.Text = " ";
            nametextBox.Text = " ";
            depertmenttextBox.Text = " ";
            coursetitletextBox.Text = " ";
            coursecodetextBox.Text = " ";
            greadcomboBox.Text = " ";
            sgpatextBox.Text = " ";
        }

        private void RESULTUI_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void coursecodetextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                Result aResult = new Result();
                aResult.CourseCode = coursecodetextBox.Text;
                ResultBL ResultBLOBJ = new ResultBL();
                DataTable dt = new DataTable();
                dt = ResultBLOBJ.GetExistingCourseTitle(aResult);
                coursetitletextBox.Text = dt.Rows[0][0].ToString();
            }
            catch
            {

            }

        }

        private void sidtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                nametextBox.Focus();
            }
           
        }

        private void nametextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                depertmenttextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = sidtextBox;
            }
        }

        private void depertmenttextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                coursetitletextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = nametextBox;
            }
        }

        private void coursetitletextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                coursecodetextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = depertmenttextBox;
            }
        }

        private void coursecodetextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                greadcomboBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = coursetitletextBox;
            }
        }

        private void greadcomboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                sgpatextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = coursecodetextBox;
            }
        }

        private void sgpatextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveresultbutton.PerformClick();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = greadcomboBox;
            }
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
          
        }

        private void backToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            lbl.Text = DateTime.Now.ToString("T");
        }

        //private void backbutton_KeyDown(object sender, KeyEventArgs e)
        //{
        //    Courses CoursesUI = new Courses();
        //    CoursesUI.Show();
        //    this.Hide();
        //}
    }
}
