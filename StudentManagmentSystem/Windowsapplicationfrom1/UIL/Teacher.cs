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
    public partial class Teachers : Form
    {
        private object TId;
        private string contactno;
        private string councellinghour;
        private string coursespecialiest;

        public string Desegnation { get; private set; }
        public string Depertment { get; private set; }
        public string Salary { get; private set; }
        public string Adress { get; private set; }
        public string Message { get; private set; }
        public string CourseSpecialist { get; internal set; }

        private string TID = " ";

        public Teachers()
        {
            InitializeComponent();
             this.populateDAataGrideview();
            teacherupdatebutton.Enabled = true;
            teacherdeletebutton.Enabled = true;
            clearbutton.Enabled = true;
            Savebutton.Enabled = true;
            
            this.ActiveControl = teacheridtextbox;
            teacheridtextbox.Focus();

            //teacheridtextbox.Text = " ";
            //teachernametextBox.Text = " ";
            //desegnationtextBox.Text = " ";
            //teacherdepertmenttextBox.Text = " ";
            //teachercontacttextBox.Text = " ";
            //courseSpecialiestcomboBox.Text = " ";
            //councellinghourtextBox.Text = " ";
            //salarytextBox.Text = " ";
            //teacheradresstextbox.Text = " ";


        }
        public void populateDAataGrideview()
        {
            DataTable dt = new DataTable();
            TeacherBL TeacherBLOBJ = new TeacherBL();
           dt = TeacherBLOBJ.GetExistingTeacherBL();
            TeacherdataGridView.DataSource = dt;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacherupdatebutton.Enabled = true;
            teacherdeletebutton.Enabled = true;
            clearbutton.Enabled = true;
            Savebutton.Enabled = true;
           
            teacheridtextbox.Text = " ";
            teachernametextBox.Text = " ";
            desegnationtextBox.Text = " ";
            teacherdepertmenttextBox.Text = " ";
            teachercontacttextBox.Text = " ";
            courseAdvisorcomboBox.Text = " ";
            councellinghourtextBox.Text = " ";
            salarytextBox.Text = " ";
            teacheradresstextbox.Text = " ";



        }

        //private void teacherbackbutton_Click(object sender, EventArgs e)
        //{

        //    Courses CoursesUI = new Courses();
        //    CoursesUI.Show();
        //    this.Hide();
        //}

        private void Savebutton_Click(object sender, EventArgs e)
        {
            Teacher aTeacher = new Teacher();
            aTeacher.ID = teacheridtextbox.Text;
            aTeacher.Name = teachernametextBox.Text;
            aTeacher.Desegnation = desegnationtextBox.Text;
            aTeacher.Depertment = teacherdepertmenttextBox.Text;
            aTeacher.ContactNo = teachercontacttextBox.Text;
            aTeacher.CourseAdvisor = courseAdvisorcomboBox.Text;
            aTeacher.CouncellingHour = councellinghourtextBox.Text;
            aTeacher.Salary = 0;
            float.TryParse(salarytextBox.Text, out aTeacher.Salary);
            aTeacher.Adress = teacheradresstextbox.Text;

            TeacherBL TeacherBLOBJ = new TeacherBL();
            bool result = TeacherBLOBJ.ValidateANewTeacherAndSendToDA(aTeacher);

            //string connectionstring = @"Data Source =DESKTOP-1U7PLQM\SQLEXPRESS;Database =SMS;Integrated Security = SSPI";
            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = connectionstring;
            //connection.Open();

            //string query = "INSERT INTO Teacher VALUES('" + teacheridtextbox.Text + "','" + teachernametextBox.Text + "','" + designationtextBox.Text + "','" + teacherdepertmenttextBox.Text + "','" + teachercontacttextBox.Text + "','" + coursespecialiestcomboBox.Text + "','" + councellinghourtextBox.Text + "','" + salarytextBox.Text + "','" + teacheradresstextbox.Text + "')";
            //SqlCommand command = new SqlCommand(query, connection);
            //int rowsAffected = command.ExecuteNonQuery();
            //MessageBox.Show(rowsAffected + "row(s) Affected.");
            if (result)
            {
                MessageBox.Show("Welcome A New Teacher");

                this.populateDAataGrideview();
                Savebutton.Enabled = true;
               
                teacherupdatebutton.Enabled = true;
                teacherdeletebutton.Enabled = true;
                clearbutton.Enabled = true;

                teacheridtextbox.Text = " ";
                teachernametextBox.Text = " ";
                desegnationtextBox.Text = " ";
                teacherdepertmenttextBox.Text = " ";
                teachercontacttextBox.Text = " ";
                courseAdvisorcomboBox.Text = " ";
                councellinghourtextBox.Text = " ";
                salarytextBox.Text = " ";
                teacheradresstextbox.Text = " ";
            }
            else
            {
                MessageBox.Show("RESULT: " + TeacherBLOBJ.Message);
            }
        }


        //private bool ValidateNewTeacherandSendToDA(Teachers aTeacher)
        //{
        //    throw new NotImplementedException();
        //}

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void TeacherdataGridView_SelectionChanged(object sender, EventArgs e)
        {

            if (TeacherdataGridView.SelectedCells.Count > 0)
            {
                int SelectedRowindex = TeacherdataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow SelectedRow = TeacherdataGridView.Rows[SelectedRowindex];

                 TID = Convert.ToString(SelectedRow.Cells["TID"].Value);
                string Name = Convert.ToString(SelectedRow.Cells["Name"].Value);
                string Desegnation = Convert.ToString(SelectedRow.Cells["Desegnation"].Value);
                string Depertment = Convert.ToString(SelectedRow.Cells["Depertment"].Value);

                string ContactNo = Convert.ToString(SelectedRow.Cells["ContactNo"].Value);
                string CourseAdvisor = Convert.ToString(SelectedRow.Cells["CourseAdvisor"].Value);
                string CouncellingHour = Convert.ToString(SelectedRow.Cells["CouncellingHour"].Value);

                string Salary = Convert.ToString(SelectedRow.Cells["Salary"].Value);
                string Adress = Convert.ToString(SelectedRow.Cells["Adress"].Value);

                teacheridtextbox.Text = TID;
                teachernametextBox.Text = Name;
                desegnationtextBox.Text = Desegnation;
                teacherdepertmenttextBox.Text = Depertment;
                teachercontacttextBox.Text = ContactNo;
                courseAdvisorcomboBox.Text = CourseAdvisor;
                councellinghourtextBox.Text = CouncellingHour;
                salarytextBox.Text = Salary;
                teacheradresstextbox.Text = Adress;

                teacherupdatebutton.Enabled = true;
                teacherdeletebutton.Enabled = true;
                clearbutton.Enabled = true;
                Savebutton.Enabled = true;
      




            }
        }

        //private void teacherupdatebutton_Click(object sender, EventArgs e)
        //{
        //    Teacher aTeacher = new Teacher();
        //    aTeacher.ID = teacheridtextbox.Text;
        //    aTeacher.Name = teachernametextBox.Text;
        //    aTeacher.Desegnation = desegnationtextBox.Text;
        //    aTeacher.Depertment = teacherdepertmenttextBox.Text;
        //    aTeacher.ContactNo = teachercontacttextBox.Text;
        //    aTeacher.CourseSpecialist = coursespecialiestcomboBox.Text;
        //    aTeacher.CouncellingHour = councellinghourtextBox.Text;
        //    aTeacher.Salary = 0;
        //    float.TryParse(salarytextBox.Text, out aTeacher.Salary);
        //    aTeacher.Adress = teacheradresstextbox.Text;

        //    TeacherBL TeacherBLOBJ = new TeacherBL();
        //    bool result = TeacherBLOBJ.UpdateANewTeacherAndSendToDA(aTeacher);
        //    if (result)
        //    {
        //        MessageBox.Show("UPDATE IS COMPLETE");
        //        this.populateDAataGrideview();
        //        teacherupdatebutton.Enabled = false;
        //        teacherdeletebutton.Enabled = false;
        //        clearbutton.Enabled = false;
        //        Savebutton.Enabled = true;
        //        teacherbackbutton.Enabled = true;
        //        teacherupdatebutton.Text = " ";
        //        teacheridtextbox.Text = " ";
        //        teachernametextBox.Text = " ";
        //        desegnationtextBox.Text = " ";
        //        teacherdepertmenttextBox.Text = " ";
        //        teachercontacttextBox.Text = " ";
        //        coursespecialiestcomboBox.Text = " ";
        //        councellinghourtextBox.Text = " ";
        //        salarytextBox.Text = " ";
        //        teacheradresstextbox.Text = " ";
        //        coursespecialiestcomboBox.Text = " ";





        //    }
        //    else
        //    {
        //        MessageBox.Show("RESULT: " + TeacherBLOBJ.Message);

        //    }
        //}

        private void teacherdeletebutton_Click(object sender, EventArgs e)
        {
            Teacher aTeacher = new Teacher();
            aTeacher.ID = teacheridtextbox.Text;
            aTeacher.Name = teachernametextBox.Text;
            aTeacher.Desegnation = desegnationtextBox.Text;
            aTeacher.Depertment = teacherdepertmenttextBox.Text;
            aTeacher.ContactNo = teachercontacttextBox.Text;
            aTeacher.CourseAdvisor = courseAdvisorcomboBox.Text;
            aTeacher.CouncellingHour = councellinghourtextBox.Text;
            aTeacher.Salary = 0;
            float.TryParse(salarytextBox.Text, out aTeacher.Salary);
            aTeacher.Adress = teacheradresstextbox.Text;

            TeacherBL TeacherBLOBJ = new TeacherBL();
            bool result = TeacherBLOBJ.DeleteANewTeacherAndSendToDA(aTeacher);
            if (result)
            {
                MessageBox.Show("DELETE  IS COMPLETE");
                this.populateDAataGrideview();
                teacherupdatebutton.Enabled = true;
                teacherdeletebutton.Enabled = true;
                clearbutton.Enabled = true;
                Savebutton.Enabled = true;
                
                teacheridtextbox.Text = " ";
                teachernametextBox.Text = " ";
                desegnationtextBox.Text = " ";
                teacherdepertmenttextBox.Text = " ";
                teachercontacttextBox.Text = " ";
                courseAdvisorcomboBox.Text = " ";
                councellinghourtextBox.Text = " ";
                salarytextBox.Text = " ";
                teacheradresstextbox.Text = " ";
                





            }
            else
            {
                MessageBox.Show("RESULT: " + TeacherBLOBJ.Message);

            }
        }

        private void desegnationtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void teacherupdatebutton_Click_1(object sender, EventArgs e)
        {

            Teacher aTeacher = new Teacher();
            aTeacher.ID = teacheridtextbox.Text;
            aTeacher.Name = teachernametextBox.Text;
            aTeacher.Desegnation = desegnationtextBox.Text;
            aTeacher.Depertment = teacherdepertmenttextBox.Text;
            aTeacher.ContactNo = teachercontacttextBox.Text;
            aTeacher.CourseAdvisor = courseAdvisorcomboBox.Text;
            aTeacher.CouncellingHour = councellinghourtextBox.Text;
            aTeacher.Salary = 0;
            float.TryParse(salarytextBox.Text, out aTeacher.Salary);
            aTeacher.Adress = teacheradresstextbox.Text;

            TeacherBL TeacherBLOBJ = new TeacherBL();
            bool result = TeacherBLOBJ.UpdateANewTeacherAndSendToDA(aTeacher);
            if (result)
            {
                MessageBox.Show("UPDATE IS COMPLETE");
                this.populateDAataGrideview();
                teacherupdatebutton.Enabled = true;
                teacherdeletebutton.Enabled = true;
                clearbutton.Enabled = true;
                Savebutton.Enabled = true;
              

                
                teacheridtextbox.Text = " ";
                teachernametextBox.Text = " ";
                desegnationtextBox.Text = " ";
                teacherdepertmenttextBox.Text = " ";
                teachercontacttextBox.Text = " ";
                courseAdvisorcomboBox.Text = "";
                councellinghourtextBox.Text = " ";
                salarytextBox.Text = " ";
                teacheradresstextbox.Text = " ";
                





            }
            else
            {
                MessageBox.Show("RESULT: " + TeacherBLOBJ.Message);

            }
        }

        private void TeacherdataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            TeacherdataGridView.ClearSelection();
            teacherupdatebutton.Enabled = true;
            teacherdeletebutton.Enabled = true;
            clearbutton.Enabled = true;
            Savebutton.Enabled = true;
           


            teacheridtextbox.Text = " ";
            teachernametextBox.Text = " ";
            desegnationtextBox.Text = " ";
            teacherdepertmenttextBox.Text = " ";
            teachercontacttextBox.Text = " ";
            courseAdvisorcomboBox.Text = "";
            councellinghourtextBox.Text = " ";
            salarytextBox.Text = " ";
            teacheradresstextbox.Text = " ";
        }

        private void teachernametextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                desegnationtextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = teacheridtextbox;
            }
        }

        private void desegnationtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                teacherdepertmenttextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = teachernametextBox;
            }
        }

        private void teacherdepertmenttextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                teachercontacttextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = desegnationtextBox;
            }
        }

        private void teachercontacttextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                courseAdvisorcomboBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = teacherdepertmenttextBox;
            }
        }

        private void courseAdvisorcomboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                councellinghourtextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = teachercontacttextBox;
            }
        }

        private void councellinghourtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                teacheradresstextbox.Focus();

            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = courseAdvisorcomboBox;
            }
        }

        private void teacheradresstextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                salarytextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = councellinghourtextBox;
            }
        }

        private void salarytextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Savebutton.PerformClick();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = teacheradresstextbox;
            }
        }

        private void teacheridtextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                teachernametextBox.Focus();
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
            CoursesU asign = new CoursesU();
            asign.Show();
            this.Hide();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void searchStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Student_Info asearch = new Search_Student_Info();
            asearch.Show();
            this.Hide();
        }

        private void searchTeacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Teacher_Info st = new Search_Teacher_Info();
            st.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchAccoInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Acco_info se = new Search_Acco_info();
            se.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
            label.Text = DateTime.Now.ToString("T");
        }

        //private void teacherbackbutton_KeyDown(object sender, KeyEventArgs e)
        //{
        //    Courses CoursesUI = new Courses();
        //    CoursesUI.Show();
        //    this.Hide();
        //}
    }
    }


