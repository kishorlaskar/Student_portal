using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class sign_In : Form
    {
        public sign_In()
        {
            InitializeComponent();
            this.ActiveControl = usernametextBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernametextBox.Text == "Kishor" && passwordtextBox.Text == "1234")
            {

                CoursesU aCourse = new CoursesU();
                aCourse.Show();
                this.Hide();
            }

            else if (usernametextBox.Text == "Kishor" && passwordtextBox.Text == "")
            {
                MessageBox.Show("Password is Invalid");
            }
            else if (usernametextBox.Text == "" && passwordtextBox.Text == "1234")
            {
                MessageBox.Show("User Name is Invalid");
            }
            else if (usernametextBox.Text != "Kishor" && passwordtextBox.Text != "1234")
            {
                MessageBox.Show("UserName or Password is not Match !!");
            }
        }



        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sign_In_Load(object sender, EventArgs e)
        {

        }

        private void usernametextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                passwordtextBox.Focus();
            }

        }

        private void passwordtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                usernametextBox.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                signinbutton.Focus();
            }
        }

        //private void exitbutton_Click(object sender, EventArgs e)
        //    {
        //        Application.Exit();
        //    }

    }
}

