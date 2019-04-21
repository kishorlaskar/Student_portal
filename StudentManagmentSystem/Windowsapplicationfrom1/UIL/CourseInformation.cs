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
    public partial class CourseO : Form
    {
    //    private string CID = " ";
        public CourseO()
        {
            InitializeComponent();
            this.PopulateDatagridview();
            Updatebutton.Enabled = true;
            deletcoursebutton.Enabled = true;
            CANCELbutton1.Enabled = true;
            confirmbutton1.Enabled = true;
           

            //semistertextBox.Text = semistertextBox.Text;
            //teachertextBox.Text = teachertextBox .Text ;
            //coursefeetextBox.Text = coursefeetextBox .Text  ;
            coursenametextBox.Text = " ";
            courseidtextBox.Text = " ";
            CredittextBox.Text = " ";
            semistertextBox.Text = " ";
            teachertextBox.Text = " ";
            coursefeetextBox.Text = " ";
            this.ActiveControl = coursenametextBox;
            coursenametextBox.Focus();

        }
        public void PopulateDatagridview()
        {
            DataTable dt = new DataTable();
            CourseBL aCourseBL = new CourseBL();
            dt = aCourseBL.GetExistingCoursesBL();
            CoursedataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Coursecreditlabel_Click(object sender, EventArgs e)
        {

        }

        private void Teacherlabe_Click(object sender, EventArgs e)
        {

        }

        private void Coursefeelabel_Click(object sender, EventArgs e)
        {

        }

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    Course aCoursesInformation = new Course();



        //    aCoursesInformation.Name = coursenametextBox.Text;
        //    aCoursesInformation.Id = courseidtextBox.Text;

        //    aCoursesInformation.Crdit = 0;
        //    double.TryParse(CredittextBox.Text, out aCoursesInformation.Crdit);

        //    aCoursesInformation.Semister = semistertextBox.Text;
        //    aCoursesInformation.Teacher = teachertextBox.Text;
        //    aCoursesInformation.CourseFee = coursefeetextBox.Text;


        //}


        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Courses CoursesUI = new Courses();
        //    CoursesUI.Show();
        //    this.Hide();
        //}

        //private void button3_Click_1(object sender, EventArgs e)
        //{
        //    Course  aCoursesInformation = new Course ();



        //    aCoursesInformation.Name = coursenametextBox.Text;
        //        aCoursesInformation.Id = courseidtextBox.Text;

        //        aCoursesInformation.Crdit = 0;
        //        double  .TryParse(CredittextBox.Text, out aCoursesInformation.Crdit);

        //        aCoursesInformation.Semister = semistertextBox.Text;
        //        aCoursesInformation.Teacher = teachertextBox.Text;
        //    aCoursesInformation.CourseFee = coursefeetextBox.Text;

        //        CourseBL  CourseOBJ = new CourseBL();
        //        bool result = CourseOBJ.ValidateNewCourseandSendToDA(aCoursesInformation);
        //        if (result)
        //        {
        //            MessageBox.Show("A NEW COURSE ADDED");
        //            this.populateDataGriedview();
        //            updatebutton1.Enabled = false;
        //         deletcoursebutton.Enabled = false;

        //           confirmbutton1.Enabled = true;
        //            backbutton1.Enabled = true;
        //            coursenametextBox.Text = " ";
        //           courseidtextBox.Text = " ";
        //            CredittextBox.Text = " ";
        //            semistertextBox.Text = " ";
        //            teachertextBox.Text = " ";
        //           coursefeetextBox.Text = " ";

        //            this.populateDataGriedview();


        //        }
        //        else
        //        {
        //            MessageBox.Show("Result: "+ CourseOBJ.Message);

        //        }




        //    }



        private void updatebutton1_Click(object sender, EventArgs e)
        {

        }

        //private void backbutton1_Click(object sender, EventArgs e)
        //{
        //    Courses CoursesUI = new Courses();
        //    CoursesUI.Show();
        //    this.Hide();
        //}

        private void confirmbutton1_Click(object sender, EventArgs e)
        {

            DAL.DAO.CourseO aCourseInfo = new DAL.DAO.CourseO();
            aCourseInfo.Name = coursenametextBox.Text;
            aCourseInfo.Id = courseidtextBox.Text;

            aCourseInfo.Credit = 0;
            double.TryParse(CredittextBox.Text, out aCourseInfo.Credit);




            aCourseInfo.Semister = semistertextBox.Text;
            aCourseInfo.Teacher = teachertextBox.Text;
            aCourseInfo.CourseFee = coursefeetextBox.Text;

            CourseBL CourseBLOBJ = new CourseBL();
            bool result = CourseBLOBJ.ValidateNewCourseandSendToDA(aCourseInfo);
            if (result)
            {
                MessageBox.Show("A NEW COURSE ADDED");
                //this.populateDataGriedview();
                this.PopulateDatagridview();
                Updatebutton.Enabled = true;
                deletcoursebutton.Enabled = true;
                CANCELbutton1.Enabled = true;


                confirmbutton1.Enabled = true;
                
                coursenametextBox.Text = " ";
                courseidtextBox.Text = " ";
                CredittextBox.Text = " ";
                semistertextBox.Text = " ";
                teachertextBox.Text = " ";
                coursefeetextBox.Text = " ";

            }
            else
            {
                MessageBox.Show("RESULT: " + CourseBLOBJ.Message);

            }
        }

        private void updatebutton1_Click_1(object sender, EventArgs e)
        {
            DAL.DAO.CourseO aCourseInfo = new DAL.DAO.CourseO();
            aCourseInfo.Name = coursenametextBox.Text;
            aCourseInfo.Id = courseidtextBox.Text;
            aCourseInfo.Credit = 0;
            
            double.TryParse(CredittextBox.Text, out aCourseInfo.Credit);

            aCourseInfo.Semister = semistertextBox.Text;
            aCourseInfo.Teacher = teachertextBox.Text;
            aCourseInfo.CourseFee = coursefeetextBox.Text;

            CourseBL CourseBLOBJ = new CourseBL();
            bool result = CourseBLOBJ.UpdateNewCourseandSendToDA(aCourseInfo);
            if (result)
            {
                MessageBox.Show("UPDATE IS COMPLETE");
                this.PopulateDatagridview();
                Updatebutton.Enabled = true;
                deletcoursebutton.Enabled = true;
                CANCELbutton1.Enabled = true;
                confirmbutton1.Enabled = true;
               
                coursenametextBox.Text = " ";
                courseidtextBox.Text = " ";
                CredittextBox.Text = " ";
                semistertextBox.Text = " ";
                teachertextBox.Text = " ";
                coursefeetextBox.Text = " ";

      


            }
            else
            {
                MessageBox.Show("RESULT: " + CourseBLOBJ.Message);

            }
        }

      

        private void deletcoursebutton_Click(object sender, EventArgs e)
        {
            DAL.DAO.CourseO aCourseInfo = new DAL.DAO.CourseO();
            aCourseInfo.Name = coursenametextBox.Text;
            aCourseInfo.Id = courseidtextBox.Text;
            aCourseInfo.Credit = 0;

            double.TryParse(CredittextBox.Text, out aCourseInfo.Credit);

            aCourseInfo.Semister = semistertextBox.Text;
            aCourseInfo.Teacher = teachertextBox.Text;
            aCourseInfo.CourseFee = coursefeetextBox.Text;

            CourseBL CourseBLOBJ = new CourseBL();
            bool result = CourseBLOBJ.DeletACourseBL(aCourseInfo);
            if (result)
            {
                MessageBox.Show("The Course is Delete FromDB...!!!");
                this.PopulateDatagridview();
                Updatebutton.Enabled = true;
                deletcoursebutton.Enabled = true;
                CANCELbutton1.Enabled = true;
                confirmbutton1.Enabled = true;
              
                coursenametextBox.Text = " ";
                courseidtextBox.Text = " ";
                CredittextBox.Text = " ";
                semistertextBox.Text = " ";
                teachertextBox.Text = " ";
                coursefeetextBox.Text = " ";




            }
            else
            {
                MessageBox.Show("RESULT: " + CourseBLOBJ.Message);

            }
        }

        private void CoursedataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (CoursedataGridView1.SelectedCells.Count > 0)
            {
                int SelectedRowindex = CoursedataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow SelectedRow = CoursedataGridView1.Rows[SelectedRowindex];

                string CourseName = Convert.ToString(SelectedRow.Cells["CourseName"].Value);
                string CID = Convert.ToString(SelectedRow.Cells["CID"].Value);
                string CourseCredit = Convert.ToString(SelectedRow.Cells["CourseCredit"].Value);
                string Semister = Convert.ToString(SelectedRow.Cells["Semister"].Value);
                string Teacher = Convert.ToString(SelectedRow.Cells["Teacher"].Value);
                string CourseFee = Convert.ToString(SelectedRow.Cells["CourseFee"].Value);

                coursenametextBox.Text = CourseName;
                courseidtextBox.Text = CID;
                CredittextBox.Text = CourseCredit;
                semistertextBox.Text = Semister;
                teachertextBox.Text = Teacher;
                coursefeetextBox.Text = CourseFee;
                Updatebutton.Enabled = true;
                deletcoursebutton.Enabled = true;
                CANCELbutton1.Enabled = true;

                confirmbutton1.Enabled = true;
               



            }
        }






        private void button1_Click(object sender, EventArgs e)
        {
            Updatebutton.Enabled = true;
            deletcoursebutton.Enabled = true;
            confirmbutton1.Enabled = true;
            
            coursenametextBox.Text = " ";
            courseidtextBox.Text = " ";
            CredittextBox.Text = " ";
            semistertextBox.Text = " ";
            teachertextBox.Text = " ";
            coursefeetextBox.Text = " ";

        }

        private void CoursedataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CoursedataGridView1.ClearSelection();
            Updatebutton.Enabled = true;
            deletcoursebutton.Enabled = true;
            CANCELbutton1.Enabled = true;
            confirmbutton1.Enabled = true;
            
            coursenametextBox.Text = " ";
            courseidtextBox.Text = " ";
            CredittextBox.Text = " ";
            semistertextBox.Text = " ";
            teachertextBox.Text = " ";
            coursefeetextBox.Text = " ";
        }

        private void coursenametextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                coursenametextBox.Focus();
            }

        }

        private void CredittextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                semistertextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = courseidtextBox;
            }
        }

        private void courseidtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                CredittextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = coursenametextBox;
            }
        }

        private void semistertextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                teachertextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = CredittextBox;
            }
        }

        private void teachertextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                coursefeetextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = semistertextBox;
            }

        }

        private void coursefeetextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmbutton1.PerformClick();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = teachertextBox;
            }
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseO CoursesUI = new CourseO();
            CoursesUI.Show();
            Hide();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Students studentsUI = new Students();
            studentsUI.Show();
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

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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

        private void Courseidlabel_Click(object sender, EventArgs e)
        {

        }

        private void Coursenamelabel_Click(object sender, EventArgs e)
        {

        }

        private void coursenametextBox_TextChanged(object sender, EventArgs e)
        {
           
            //if (e.KeyCode == Keys.Up)
            //{
            //    this.ActiveControl = teachertextBox;
            //}
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
            courselabe.Text = DateTime.Now.ToString("T");
        }

        private void CourseO_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //private void backbutton1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Escape)
        //    {
        //        Courses CoursesUI = new Courses();
        //        CoursesUI.Show();
        //        this.Hide();
        //    }

        //}
    }
}
