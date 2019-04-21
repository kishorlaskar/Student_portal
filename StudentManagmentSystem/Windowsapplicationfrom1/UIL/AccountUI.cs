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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
            this.populateDataGrideview();
            confirmbutton.Enabled = true;
        
            modifeybutton.Enabled = true;
            deleteaccountbuttonbutton.Enabled = true;
            clearbutton.Enabled = true;
            this.ActiveControl = accountidtextBox;
            accountidtextBox.Focus();


        }
        public void populateDataGrideview()
        {
            DataTable dt = new DataTable();
            AccountBL AccountBLOBJ = new AccountBL();
            dt = AccountBLOBJ.GetExistingAccountBL();
            AccountdataGridView1.DataSource = dt;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {

            Accounts accounts = new Accounts();


            accounts.AID = accountidtextBox.Text;
            accounts.AdmissonFee = admissionfeetextBox.Text;
            accounts.Due = duetextBox.Text;
            accounts.ExtraCarriculamFee = extracarriculamtextBox.Text;
            accounts.LabratoreyFee = labretoryfeetextBox.Text;
            accounts.LibraryFee = libraryfeetextBox.Text;
            accounts.SemisterFee = semisterfeetextBox.Text;
            accounts.TotalPaid = totalpaidtextBox.Text;
            accounts.TransPortFee = transportfeetextBox.Text;
            accounts.TutionFee = tutionfeetextBox.Text;
            accounts.Waiver = waivertextBox.Text;


            AccountBL AccountBLOBJ = new AccountBL();
            bool result = AccountBLOBJ.ValidateAnewAccountAndSendToDA(accounts);

            if (result)
            {
                MessageBox.Show("A NEW ACCOUNT ADDED");
              this.populateDataGrideview();
                confirmbutton.Enabled = true;
             
                modifeybutton.Enabled = true;
                clearbutton.Enabled = true;
                deleteaccountbuttonbutton.Enabled = true;
                accountidtextBox.Text = " ";
                admissionfeetextBox.Text = " ";
                tutionfeetextBox.Text = " ";
                waivertextBox.Text = " ";
                duetextBox.Text = " ";
                libraryfeetextBox.Text = " ";
                labretoryfeetextBox.Text = " ";
                extracarriculamtextBox.Text = " ";
                totalpaidtextBox.Text = " ";
                semisterfeetextBox.Text = " ";
                transportfeetextBox.Text = " ";
            }
            else
            {
                MessageBox.Show("RESULT: " + AccountBLOBJ.Message);
            }


     
        }

        private void extracarriculamtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox10.Text = extracarriculamtextBox.Text;

                int AdmissionFee = int.Parse(admissionfeetextBox.Text);
                int SemisterFeee = int.Parse(semisterfeetextBox.Text);
                int LibraryFeee = int.Parse(libraryfeetextBox.Text);
                int Labroterye = int.Parse(labretoryfeetextBox.Text);
                int tutionfee = int.Parse(tutionfeetextBox.Text);
                int extracariculamFee = int.Parse(textBox10.Text);
                int trans = int.Parse(transportfeetextBox.Text);
                int due = int.Parse(duetextBox.Text);
                int waiver = int.Parse(waivertextBox.Text);
                int result = AdmissionFee + SemisterFeee + LibraryFeee + Labroterye + tutionfee + trans + due - waiver;
                int res = result + extracariculamFee;
                totalpaidtextBox.Text = res.ToString();

            }
            catch
            {

            }
    
            



        }

        //private void backbutton_Click(object sender, EventArgs e)
        //{

        //    Courses CoursesUI = new Courses();
        //    CoursesUI.Show();
        //    this.Hide();
        //}

        private void clearbutton_Click(object sender, EventArgs e)
        {
            confirmbutton.Enabled = true;
            
            modifeybutton.Enabled = true;
            deleteaccountbuttonbutton.Enabled = true;
            clearbutton.Enabled = true;
            accountidtextBox.Text = " ";
            libraryfeetextBox.Text = " ";
            semisterfeetextBox.Text = " ";
            admissionfeetextBox.Text = " ";
            duetextBox.Text = " ";
            transportfeetextBox.Text = " ";
            labretoryfeetextBox.Text = " ";
            totalpaidtextBox.Text = " ";
            waivertextBox.Text = " ";
            tutionfeetextBox.Text = " ";
            extracarriculamtextBox.Text = " ";

        }

        private void changeinfogroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void modifeybutton_Click(object sender, EventArgs e)
        {
            Accounts accounts = new Accounts();


            accounts.AID = accountidtextBox.Text;
            accounts.AdmissonFee = admissionfeetextBox.Text;
            accounts.Due = duetextBox.Text;
            accounts.ExtraCarriculamFee = extracarriculamtextBox.Text;
            accounts.LabratoreyFee = labretoryfeetextBox.Text;
            accounts.LibraryFee = libraryfeetextBox.Text;
            accounts.SemisterFee = semisterfeetextBox.Text;
            accounts.TotalPaid = totalpaidtextBox.Text;
            accounts.TransPortFee = transportfeetextBox.Text;
            accounts.TutionFee = tutionfeetextBox.Text;
            accounts.Waiver = waivertextBox.Text;


            AccountBL AccountBLOBJ = new AccountBL();
            bool result = AccountBLOBJ.UpdateAnewAccountAndSendToDA(accounts);

            if (result)
            {
                MessageBox.Show("UPDATE IS COMPLETE");
                this.populateDataGrideview();
                confirmbutton.Enabled = true;
                
                modifeybutton.Enabled = true;
                clearbutton.Enabled = true;
                deleteaccountbuttonbutton.Enabled = true;
                accountidtextBox.Text = " ";
                admissionfeetextBox.Text = " ";
                tutionfeetextBox.Text = " ";
                waivertextBox.Text = " ";
                duetextBox.Text = " ";
                libraryfeetextBox.Text = " ";
                labretoryfeetextBox.Text = " ";
                extracarriculamtextBox.Text = " ";
                totalpaidtextBox.Text = " ";
                semisterfeetextBox.Text = " ";
                transportfeetextBox.Text = " ";
            }
            else
            {
                MessageBox.Show("RESULT: " + AccountBLOBJ.Message);
            }
        }

        private void deleteaccountbuttonbutton_Click(object sender, EventArgs e)
        {
            Accounts accounts = new Accounts();


            accounts.AID = accountidtextBox.Text;
            accounts.AdmissonFee = admissionfeetextBox.Text;
            accounts.Due = duetextBox.Text;
            accounts.ExtraCarriculamFee = extracarriculamtextBox.Text;
            accounts.LabratoreyFee = labretoryfeetextBox.Text;
            accounts.LibraryFee = libraryfeetextBox.Text;
            accounts.SemisterFee = semisterfeetextBox.Text;
            accounts.TotalPaid = totalpaidtextBox.Text;
            accounts.TransPortFee = transportfeetextBox.Text;
            accounts.TutionFee = tutionfeetextBox.Text;
            accounts.Waiver = waivertextBox.Text;


            AccountBL AccountBLOBJ = new AccountBL();
            bool result = AccountBLOBJ.DeleteAnewAccountAndSendToDA(accounts);

            if (result)
            {
                MessageBox.Show("DELETE IS COMPLETE");


                this.populateDataGrideview();
                confirmbutton.Enabled = true;
                
                modifeybutton.Enabled = true;
                clearbutton.Enabled = true;
                deleteaccountbuttonbutton.Enabled = true;
                accountidtextBox.Text = " ";
                admissionfeetextBox.Text = " ";
                tutionfeetextBox.Text = " ";
                waivertextBox.Text = " ";
                duetextBox.Text = " ";
                libraryfeetextBox.Text = " ";
                labretoryfeetextBox.Text = " ";
                extracarriculamtextBox.Text = " ";
                totalpaidtextBox.Text = " ";
                semisterfeetextBox.Text = " ";
                transportfeetextBox.Text = " ";
            }
            else
            {
                MessageBox.Show("RESULT: " + AccountBLOBJ.Message);
            }
        }






        private void AccountdataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AccountdataGridView1.ClearSelection();
            confirmbutton.Enabled = true;
            
            modifeybutton.Enabled = true;
            clearbutton.Enabled = true;
            deleteaccountbuttonbutton.Enabled = true;
            accountidtextBox.Text = " ";
            admissionfeetextBox.Text = " ";
            tutionfeetextBox.Text = " ";
            waivertextBox.Text = " ";
            duetextBox.Text = " ";
            libraryfeetextBox.Text = " ";
            labretoryfeetextBox.Text = " ";
            extracarriculamtextBox.Text = " ";
            totalpaidtextBox.Text = " ";
            semisterfeetextBox.Text = " ";
            transportfeetextBox.Text = " ";

        }

        private void AccountdataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (AccountdataGridView1.SelectedCells.Count > 0)
            {
                int SelectedRowindex = AccountdataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow SelectedRow = AccountdataGridView1.Rows[SelectedRowindex];

                string AID = Convert.ToString(SelectedRow.Cells["AID"].Value);
                string AdmissonFee = Convert.ToString(SelectedRow.Cells["AdmissonFee"].Value);
                string SemisterFee = Convert.ToString(SelectedRow.Cells["SemisterFee"].Value);
                string TotalPaid = Convert.ToString(SelectedRow.Cells["TotalPaid"].Value);
                string LibraryFee = Convert.ToString(SelectedRow.Cells["LibraryFee"].Value);
                string LabretoryFee = Convert.ToString(SelectedRow.Cells["LabretoryFee"].Value);
                string TutionFee = Convert.ToString(SelectedRow.Cells["TutionFee"].Value);
                string ExtraCarriculamFee = Convert.ToString(SelectedRow.Cells["ExtraCarriculamFee"].Value);
                string Due = Convert.ToString(SelectedRow.Cells["Due"].Value);
                string TransportFee = Convert.ToString(SelectedRow.Cells["TransportFee"].Value);
                string Waiver = Convert.ToString(SelectedRow.Cells["Waiver"].Value);

                accountidtextBox.Text = AID;
                admissionfeetextBox.Text = AdmissonFee;

                semisterfeetextBox.Text = SemisterFee;
                totalpaidtextBox.Text = TotalPaid;
                libraryfeetextBox.Text = LibraryFee;
                labretoryfeetextBox.Text = LabretoryFee;
                tutionfeetextBox.Text = TutionFee;
                extracarriculamtextBox.Text = ExtraCarriculamFee;
                duetextBox.Text = Due;
                transportfeetextBox.Text = TransportFee;
                waivertextBox.Text = Waiver;
                confirmbutton.Enabled = true;
               
                modifeybutton.Enabled = true;
                deleteaccountbuttonbutton.Enabled = true;
                clearbutton.Enabled = true;

                

            }
        }

        private void AccountdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void accountidtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                admissionfeetextBox.Focus();
            }
        }

        private void admissionfeetextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down)
            {
                semisterfeetextBox.Focus();
            }
            if(e.KeyCode == Keys.Up)
            {
                this.ActiveControl= accountidtextBox;

            }
        }

        private void tutionfeetextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down)
            {
                libraryfeetextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = admissionfeetextBox;
            }
        }

        private void semisterfeetextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down)
            {
                tutionfeetextBox.Focus();
            }
            if(e.KeyCode == Keys.Up)
            {
                this.ActiveControl = admissionfeetextBox;
            }
        }

        private void libraryfeetextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down)
            {
                totalpaidtextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = tutionfeetextBox;
            }
        }

        private void totalpaidtextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down)
            {
                duetextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = libraryfeetextBox;
            }
        }

        private void duetextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down)
            {
                waivertextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = totalpaidtextBox;
            }
        }

        private void waivertextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down)
            {
                labretoryfeetextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = duetextBox;
            }
        }

        private void labretoryfeetextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                transportfeetextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = waivertextBox;
            }
        }

        private void transportfeetextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
               extracarriculamtextBox.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = labretoryfeetextBox;
            }
        }

        private void extracarriculamtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmbutton.PerformClick();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.ActiveControl = transportfeetextBox;
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

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account AccountUI = new Account();
            AccountUI.Show();
            this.Hide();
        }

        private void resultToolStripMenuItem1_Click(object sender, EventArgs e)
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
            label12.Text = DateTime.Now.ToString("T");
        }

        //private void backbutton_KeyDown(object sender, KeyEventArgs e)
        //{
        //    Courses CoursesUI = new Courses();
        //    CoursesUI.Show();
        //    this.Hide();
        //}
    }
}
 