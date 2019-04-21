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
    public partial class Students : Form
    {



        private string ID = " ";


        public Students()
        {
            InitializeComponent();

            this.populateDataGriedview();
            updatebutton.Enabled = true;
            deletebutton.Enabled = true;
            cancelbutton1.Enabled = true;
            savebutton.Enabled = true;
            
            massagetextBox.Text = " ";
            idtextBox.Text = " ";
            agetextBox.Text = " ";
            facultytextBox.Text = " ";
            parmanentadresstextBox.Text = " ";
            presentadresstextBox.Text = " ";
            gendercomboBox.Text = " ";
            contactnotextBox.Text = " ";
            bloodgrouptextBox.Text = " ";
            this.ActiveControl = massagetextBox;
            massagetextBox.Focus();
        }
        private void populateDataGriedview()
        {
            DataTable dt = new DataTable();
            StudentBL StudentBL = new StudentBL();
            dt = StudentBL.GetExistingStudentFromBL();
            StudentdataGridView.DataSource = dt;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }



        private void savebutton_Click(object sender, EventArgs e)
        {

            Student aStudents = new Student();
            aStudents.Name = massagetextBox.Text;
            aStudents.Id = idtextBox.Text;

            aStudents.Age = 0;
            float.TryParse(agetextBox.Text, out aStudents.Age);

            aStudents.Faculty = facultytextBox.Text;
            aStudents.ParmanentAdress = parmanentadresstextBox.Text;
            aStudents.PresentAdress = presentadresstextBox.Text;
            aStudents.Gender = gendercomboBox.Text;
            aStudents.ContactNo = contactnotextBox.Text;
            aStudents.Bloodgroup = bloodgrouptextBox.Text;
            StudentBL StudentBLOBJ = new StudentBL();
            bool result = StudentBLOBJ.ValidateNewStudentandSendToDA(aStudents);
            if (result)
            {
                MessageBox.Show("A New Course Has been Saved..!!");
                this.populateDataGriedview();
                updatebutton.Enabled = false;
                deletebutton.Enabled = false;
                cancelbutton1.Enabled = false;
                savebutton.Enabled = true;
                
                massagetextBox.Text = " ";
                idtextBox.Text = " ";
                agetextBox.Text = " ";
                facultytextBox.Text = " ";
                parmanentadresstextBox.Text = " ";
                presentadresstextBox.Text = " ";
                gendercomboBox.Text = " ";
                contactnotextBox.Text = " ";
                bloodgrouptextBox.Text = " ";
                this.populateDataGriedview();


            }
            else
            {
                MessageBox.Show("Result: " + StudentBLOBJ.Message);

            }




        }


        private void datagridview1_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void updatebutton_Click(object sender, EventArgs e)
        {
            Student aStudents = new Student();
            aStudents.Name = massagetextBox.Text;
            aStudents.Id = idtextBox.Text;

            aStudents.Age = 0;
            float.TryParse(agetextBox.Text, out aStudents.Age);

            aStudents.Faculty = facultytextBox.Text;
            aStudents.ParmanentAdress = parmanentadresstextBox.Text;
            aStudents.PresentAdress = presentadresstextBox.Text;
            aStudents.Gender = gendercomboBox.Text;
            aStudents.ContactNo = contactnotextBox.Text;
            aStudents.Bloodgroup = bloodgrouptextBox.Text;
            StudentBL StudentBLOBJ = new StudentBL();
            bool result = StudentBLOBJ.UpdateNewStudentandSendToDA(aStudents);
            if (result)
            {
                MessageBox.Show("Changes  Has been Saved..!!");
                this.populateDataGriedview();
                updatebutton.Enabled = true;
                deletebutton.Enabled = true;
                cancelbutton1.Enabled = true;
                savebutton.Enabled = true;
                
                massagetextBox.Text = " ";
                idtextBox.Text = " ";
                agetextBox.Text = " ";
                facultytextBox.Text = " ";
                parmanentadresstextBox.Text = " ";
                presentadresstextBox.Text = " ";
                gendercomboBox.Text = " ";
                contactnotextBox.Text = " ";
                bloodgrouptextBox.Text = " ";



            }
            else
            {
                MessageBox.Show("Result: " + StudentBLOBJ.Message);

            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            savebutton.Enabled = true;
            updatebutton.Enabled = true;
            deletebutton.Enabled = true;
            cancelbutton1.Enabled = true;
           

        }

        private void StudentdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void StudentdataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            massagetextBox.Text = StudentdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            idtextBox.Text = StudentdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            agetextBox.Text = StudentdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            facultytextBox.Text = StudentdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            parmanentadresstextBox.Text = StudentdataGridView.SelectedRows[0].Cells[4].Value.ToString();
            presentadresstextBox.Text = StudentdataGridView.SelectedRows[0].Cells[5].Value.ToString();
            gendercomboBox.Text = StudentdataGridView.SelectedRows[0].Cells[6].Value.ToString();
            contactnotextBox.Text = StudentdataGridView.SelectedRows[0].Cells[7].Value.ToString();
            bloodgrouptextBox.Text = StudentdataGridView.SelectedRows[0].Cells[8].Value.ToString();

            updatebutton.Enabled = true;
            deletebutton.Enabled = true;
            cancelbutton1.Enabled = true;
            savebutton.Enabled = true;
            

        }

        private void cancelbutton_Click_1(object sender, EventArgs e)
        {

            updatebutton.Enabled = true;
            deletebutton.Enabled = true;
            cancelbutton1.Enabled = true;
            savebutton.Enabled = true;
          
            massagetextBox.Text = " ";
            idtextBox.Text = " ";
            agetextBox.Text = " ";
            facultytextBox.Text = " ";
            parmanentadresstextBox.Text = " ";
            presentadresstextBox.Text = " ";
            gendercomboBox.Text = " ";
            contactnotextBox.Text = " ";
            bloodgrouptextBox.Text = " ";

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {

            Student aStudents = new Student();
            aStudents.Name = massagetextBox.Text;
            aStudents.Id = idtextBox.Text;

            aStudents.Age = 0;
            float.TryParse(agetextBox.Text, out aStudents.Age);

            aStudents.Faculty = facultytextBox.Text;
            aStudents.ParmanentAdress = parmanentadresstextBox.Text;
            aStudents.PresentAdress = presentadresstextBox.Text;
            aStudents.Gender = gendercomboBox.Text;
            aStudents.ContactNo = contactnotextBox.Text;
            aStudents.Bloodgroup = bloodgrouptextBox.Text;
            StudentBL StudentBLOBJ = new StudentBL();
            bool result = StudentBLOBJ.DeleteAStudentandSendFromDA(aStudents);
            if (result)
            {
                MessageBox.Show("The Student's Information is deleted from DB..!!");
                this.populateDataGriedview();
                updatebutton.Enabled = true;
                deletebutton.Enabled = true;
                cancelbutton1.Enabled = true;
                savebutton.Enabled = true;
               
                massagetextBox.Text = " ";
                idtextBox.Text = " ";
                agetextBox.Text = " ";
                facultytextBox.Text = " ";
                parmanentadresstextBox.Text = " ";
                presentadresstextBox.Text = " ";
                gendercomboBox.Text = " ";
                contactnotextBox.Text = " ";
                bloodgrouptextBox.Text = " ";



            }
            else
            {
                MessageBox.Show("Result: " + StudentBLOBJ.Message);

            }

        }

        private void StudentdataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            StudentdataGridView.ClearSelection();
            updatebutton.Enabled = true;
            deletebutton.Enabled = true;
            cancelbutton1.Enabled = true;
            savebutton.Enabled = true;
            
            massagetextBox.Text = " ";
            idtextBox.Text = " ";
            agetextBox.Text = " ";
            facultytextBox.Text = " ";
            parmanentadresstextBox.Text = " ";
            presentadresstextBox.Text = " ";
            gendercomboBox.Text = " ";
            contactnotextBox.Text = " ";
            bloodgrouptextBox.Text = " ";

        }

        private void massagetextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                idtextBox.Focus();
            }

        }

        private void idtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                agetextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = massagetextBox;
            }
        }

        private void agetextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                facultytextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = idtextBox;
            }
        }

        private void parmanentadresstextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                presentadresstextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = agetextBox;
            }
        }

        private void facultytextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                parmanentadresstextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = agetextBox;
            }
        }


        private void presentadresstextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                gendercomboBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = parmanentadresstextBox;
            }
        }

        private void gendercomboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                contactnotextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = presentadresstextBox;
            }
        }
        private void contactnotextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down)
            {
                bloodgrouptextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = gendercomboBox;
            }
        }

        private void bloodgrouptextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                savebutton.PerformClick();
            }

            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = contactnotextBox;
            }
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Students studentsUI = new Students();
            studentsUI.Show();
            this.Hide();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseO CoursesUI = new CourseO();
            CoursesUI.Show();
            Hide();
        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void back1button_Click(object sender, EventArgs e)
        {

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
            lblStatus.Text = DateTime.Now.ToString("T");
        }

        private void Students_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}


    







            
        

        

    

