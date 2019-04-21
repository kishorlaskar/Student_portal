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
    public partial class Search_Student_Info : Form
    {
        public Search_Student_Info()
        {
            InitializeComponent();
            this.PopulateDataGrideview();
            searchbutton.Enabled = true;
            clearbutton.Enabled = true;
            idtextbox.Text = "";
            nametextBox.Text = "";
            agetextBox.Text = "";
            parmanentadresstextBox.Text = "";
            presenttextBox.Text = "";
            facultytextBox.Text = "";
            gendercomboBox.Text = "";
            contacttextBox.Text = "";
            bloodgrouptextBox.Text = "";
            this.ActiveControl = idtextbox;

        }
        private void PopulateDataGrideview()
        {
            Search_Student_BL searchbl = new Search_Student_BL();
            DataTable dt = new DataTable();
            dt = searchbl.GetExistingStudentSearchFromBL();
            searchSTDdataGridView.DataSource = dt;
        }

        private void Search_Student_Info_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            searchbutton.Enabled = true;
            clearbutton.Enabled = true;
            idtextbox.Text = "";
            nametextBox.Text = "";
            agetextBox.Text = "";
            facultytextBox.Text = "";
            parmanentadresstextBox.Text = "";
            presenttextBox.Text = "";
            contacttextBox.Text = "";
            bloodgrouptextBox.Text = "";
            gendercomboBox.Text = "";

        }
   

        //private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void searchStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Student_Info search = new Search_Student_Info();
            search.Show();
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

        //private void backToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    login LoginUI = new login();
        //    LoginUI.Show();
        //    this.Hide();
        //}

        private void searchbutton_Click(object sender, EventArgs e)
        {
            Search aSearch = new Search();
            aSearch.Id = idtextbox.Text;
            aSearch.Name = nametextBox.Text;
            aSearch.Age = 0;
            float.TryParse(agetextBox.Text,out aSearch.Age);
            aSearch.Faculty = facultytextBox.Text;
            aSearch.ParmanentAdress = parmanentadresstextBox.Text;
            aSearch.PresentAdress = presenttextBox.Text;
            aSearch.Gender = gendercomboBox.Text;
            aSearch.ContactNo = contacttextBox.Text;
            aSearch.Bloodgroup = bloodgrouptextBox.Text;
            Search_Student_BL SearchBl = new Search_Student_BL();
            DataTable result = SearchBl.Search_StudentANDSendToDAL(aSearch);
            if ( result != null)
            {

                searchSTDdataGridView.DataSource = result;
                idtextbox.Text = "";
                nametextBox.Text = "";
                agetextBox.Text = "";
                parmanentadresstextBox.Text = "";
                presenttextBox.Text = "";
                facultytextBox.Text = "";
                gendercomboBox.Text = "";
                contacttextBox.Text = "";
                bloodgrouptextBox.Text = "";

            }
            else
            {
                MessageBox.Show("An Error Has Been Occured!!");
            }





        }

        private void searchTeacherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Teacher_Info st = new Search_Teacher_Info();
            st.Show();
            this.Hide();
        }

        private void searchSTDdataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
                //nametextBox.Text = searchSTDdataGridView.SelectedRows[0].Cells[0].Value.ToString();
                //idtextbox.Text = searchSTDdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                //agetextBox.Text = searchSTDdataGridView.SelectedRows[0].Cells[2].Value.ToString();
                //facultytextBox.Text = searchSTDdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                //parmanentadresstextBox.Text = searchSTDdataGridView.SelectedRows[0].Cells[4].Value.ToString();
                //presentadress.Text = searchSTDdataGridView.SelectedRows[0].Cells[5].Value.ToString();
                //gendercomboBox.Text = searchSTDdataGridView.SelectedRows[0].Cells[6].Value.ToString();
                //contacttextBox.Text = searchSTDdataGridView.SelectedRows[0].Cells[7].Value.ToString();
                //bloodgrouptextBox.Text = searchSTDdataGridView.SelectedRows[0].Cells[8].Value.ToString();

                //searchbutton.Enabled = true;
                //clearbutton.Enabled = true;

        }

        private void searchSTDdataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            searchSTDdataGridView.ClearSelection();
            searchbutton.Enabled = true;
            clearbutton.Enabled = true;
            idtextbox.Text = "";
            nametextBox.Text = "";
            agetextBox.Text = "";
            facultytextBox.Text = "";
            parmanentadresstextBox.Text = "";
            presenttextBox.Text = "";
            contacttextBox.Text = "";
            bloodgrouptextBox.Text = "";
            gendercomboBox.Text = "";

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoursesU aCourse = new CoursesU();
            aCourse.Show();
            this.Hide();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void idtextbox_KeyDown(object sender, KeyEventArgs e)
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
                agetextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = idtextbox;

            }
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
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
                nametextBox.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
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
                agetextBox.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
            }
        }

        private void parmanentadresstextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                presenttextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                facultytextBox.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
            }
        }

        private void presenttextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                gendercomboBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                parmanentadresstextBox.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
            }
        }

        private void gendercomboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                contacttextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                presenttextBox.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
            }
        }

        private void contacttextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                bloodgrouptextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                gendercomboBox.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
            }
        }

        private void bloodgrouptextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchbutton.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                contacttextBox.Focus();
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
                searchbutton.Focus();
            }
        }

        private void searchbutton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                clearbutton.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                bloodgrouptextBox.Focus();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("T");
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

 