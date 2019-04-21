namespace WindowsFormsApplication1
{
    partial class Search_Student_Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTeacherInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAccoInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchResultInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gendercomboBox = new System.Windows.Forms.ComboBox();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.facultytextBox = new System.Windows.Forms.TextBox();
            this.parmanentadresstextBox = new System.Windows.Forms.TextBox();
            this.bloodgrouptextBox = new System.Windows.Forms.TextBox();
            this.contacttextBox = new System.Windows.Forms.TextBox();
            this.presenttextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.agetextBox = new System.Windows.Forms.TextBox();
            this.presentadress = new System.Windows.Forms.Label();
            this.bloodgroup = new System.Windows.Forms.Label();
            this.contactlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.parmanentadress = new System.Windows.Forms.Label();
            this.faculty = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchSTDdataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchSTDdataGridView)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Blue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.resultToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 59);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.courseToolStripMenuItem.Text = "Course";
            this.courseToolStripMenuItem.Click += new System.EventHandler(this.courseToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.teacherToolStripMenuItem.Text = "Teacher";
            this.teacherToolStripMenuItem.Click += new System.EventHandler(this.teacherToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.resultToolStripMenuItem.Text = "Result";
            this.resultToolStripMenuItem.Click += new System.EventHandler(this.resultToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchStudentInfoToolStripMenuItem,
            this.searchTeacherInfoToolStripMenuItem,
            this.searchAccoInfoToolStripMenuItem,
            this.searchResultInfoToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // searchStudentInfoToolStripMenuItem
            // 
            this.searchStudentInfoToolStripMenuItem.Name = "searchStudentInfoToolStripMenuItem";
            this.searchStudentInfoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.searchStudentInfoToolStripMenuItem.Text = "Search Student Info";
            this.searchStudentInfoToolStripMenuItem.Click += new System.EventHandler(this.searchStudentInfoToolStripMenuItem_Click);
            // 
            // searchTeacherInfoToolStripMenuItem
            // 
            this.searchTeacherInfoToolStripMenuItem.Name = "searchTeacherInfoToolStripMenuItem";
            this.searchTeacherInfoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.searchTeacherInfoToolStripMenuItem.Text = "Search Teacher Info";
            this.searchTeacherInfoToolStripMenuItem.Click += new System.EventHandler(this.searchTeacherInfoToolStripMenuItem_Click);
            // 
            // searchAccoInfoToolStripMenuItem
            // 
            this.searchAccoInfoToolStripMenuItem.Name = "searchAccoInfoToolStripMenuItem";
            this.searchAccoInfoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.searchAccoInfoToolStripMenuItem.Text = "Search Acco Info";
            this.searchAccoInfoToolStripMenuItem.Click += new System.EventHandler(this.searchAccoInfoToolStripMenuItem_Click);
            // 
            // searchResultInfoToolStripMenuItem
            // 
            this.searchResultInfoToolStripMenuItem.Name = "searchResultInfoToolStripMenuItem";
            this.searchResultInfoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.searchResultInfoToolStripMenuItem.Text = "Search Result  Info";
            this.searchResultInfoToolStripMenuItem.Click += new System.EventHandler(this.searchResultInfoToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gendercomboBox);
            this.groupBox1.Controls.Add(this.idtextbox);
            this.groupBox1.Controls.Add(this.facultytextBox);
            this.groupBox1.Controls.Add(this.parmanentadresstextBox);
            this.groupBox1.Controls.Add(this.bloodgrouptextBox);
            this.groupBox1.Controls.Add(this.contacttextBox);
            this.groupBox1.Controls.Add(this.presenttextBox);
            this.groupBox1.Controls.Add(this.nametextBox);
            this.groupBox1.Controls.Add(this.agetextBox);
            this.groupBox1.Controls.Add(this.presentadress);
            this.groupBox1.Controls.Add(this.bloodgroup);
            this.groupBox1.Controls.Add(this.contactlabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.parmanentadress);
            this.groupBox1.Controls.Add(this.faculty);
            this.groupBox1.Controls.Add(this.age);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.idlabel);
            this.groupBox1.Location = new System.Drawing.Point(36, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENTER SOMETHING";
            // 
            // gendercomboBox
            // 
            this.gendercomboBox.FormattingEnabled = true;
            this.gendercomboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Common"});
            this.gendercomboBox.Location = new System.Drawing.Point(178, 235);
            this.gendercomboBox.Name = "gendercomboBox";
            this.gendercomboBox.Size = new System.Drawing.Size(132, 21);
            this.gendercomboBox.TabIndex = 5;
            this.gendercomboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gendercomboBox_KeyDown);
            // 
            // idtextbox
            // 
            this.idtextbox.Location = new System.Drawing.Point(178, 24);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(134, 20);
            this.idtextbox.TabIndex = 4;
            this.idtextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idtextbox_KeyDown);
            // 
            // facultytextBox
            // 
            this.facultytextBox.Location = new System.Drawing.Point(179, 122);
            this.facultytextBox.Name = "facultytextBox";
            this.facultytextBox.Size = new System.Drawing.Size(133, 20);
            this.facultytextBox.TabIndex = 3;
            this.facultytextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.facultytextBox_KeyDown);
            // 
            // parmanentadresstextBox
            // 
            this.parmanentadresstextBox.Location = new System.Drawing.Point(179, 157);
            this.parmanentadresstextBox.Name = "parmanentadresstextBox";
            this.parmanentadresstextBox.Size = new System.Drawing.Size(133, 20);
            this.parmanentadresstextBox.TabIndex = 3;
            this.parmanentadresstextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.parmanentadresstextBox_KeyDown);
            // 
            // bloodgrouptextBox
            // 
            this.bloodgrouptextBox.Location = new System.Drawing.Point(177, 315);
            this.bloodgrouptextBox.Name = "bloodgrouptextBox";
            this.bloodgrouptextBox.Size = new System.Drawing.Size(133, 20);
            this.bloodgrouptextBox.TabIndex = 3;
            this.bloodgrouptextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bloodgrouptextBox_KeyDown);
            // 
            // contacttextBox
            // 
            this.contacttextBox.Location = new System.Drawing.Point(179, 279);
            this.contacttextBox.Name = "contacttextBox";
            this.contacttextBox.Size = new System.Drawing.Size(133, 20);
            this.contacttextBox.TabIndex = 3;
            this.contacttextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contacttextBox_KeyDown);
            // 
            // presenttextBox
            // 
            this.presenttextBox.Location = new System.Drawing.Point(179, 195);
            this.presenttextBox.Name = "presenttextBox";
            this.presenttextBox.Size = new System.Drawing.Size(133, 20);
            this.presenttextBox.TabIndex = 3;
            this.presenttextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.presenttextBox_KeyDown);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(178, 57);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(133, 20);
            this.nametextBox.TabIndex = 3;
            this.nametextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nametextBox_KeyDown);
            // 
            // agetextBox
            // 
            this.agetextBox.Location = new System.Drawing.Point(179, 87);
            this.agetextBox.Name = "agetextBox";
            this.agetextBox.Size = new System.Drawing.Size(133, 20);
            this.agetextBox.TabIndex = 3;
            this.agetextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.agetextBox_KeyDown);
            // 
            // presentadress
            // 
            this.presentadress.AutoSize = true;
            this.presentadress.Location = new System.Drawing.Point(48, 198);
            this.presentadress.Name = "presentadress";
            this.presentadress.Size = new System.Drawing.Size(108, 13);
            this.presentadress.TabIndex = 2;
            this.presentadress.Text = "PRESENT ADRESS:";
            // 
            // bloodgroup
            // 
            this.bloodgroup.AutoSize = true;
            this.bloodgroup.Location = new System.Drawing.Point(48, 315);
            this.bloodgroup.Name = "bloodgroup";
            this.bloodgroup.Size = new System.Drawing.Size(89, 13);
            this.bloodgroup.TabIndex = 2;
            this.bloodgroup.Text = "BLOOD GROUP:";
            // 
            // contactlabel
            // 
            this.contactlabel.AutoSize = true;
            this.contactlabel.Location = new System.Drawing.Point(48, 279);
            this.contactlabel.Name = "contactlabel";
            this.contactlabel.Size = new System.Drawing.Size(61, 13);
            this.contactlabel.TabIndex = 2;
            this.contactlabel.Text = "CONTACT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "GENDER:";
            // 
            // parmanentadress
            // 
            this.parmanentadress.AutoSize = true;
            this.parmanentadress.Location = new System.Drawing.Point(48, 159);
            this.parmanentadress.Name = "parmanentadress";
            this.parmanentadress.Size = new System.Drawing.Size(125, 13);
            this.parmanentadress.TabIndex = 2;
            this.parmanentadress.Text = "PARMANENT ADRESS:";
            // 
            // faculty
            // 
            this.faculty.AutoSize = true;
            this.faculty.Location = new System.Drawing.Point(48, 122);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(58, 13);
            this.faculty.TabIndex = 2;
            this.faculty.Text = "FACULTY:";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(48, 87);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(32, 13);
            this.age.TabIndex = 2;
            this.age.Text = "AGE:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(48, 57);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 13);
            this.name.TabIndex = 1;
            this.name.Text = "NAME:";
            this.name.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(48, 29);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(21, 13);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "ID:";
            this.idlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.Blue;
            this.searchbutton.Location = new System.Drawing.Point(325, 508);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(141, 52);
            this.searchbutton.TabIndex = 2;
            this.searchbutton.Text = "SEARCH";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            this.searchbutton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchbutton_KeyDown);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.Blue;
            this.clearbutton.Location = new System.Drawing.Point(523, 508);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(121, 52);
            this.clearbutton.TabIndex = 2;
            this.clearbutton.Text = "CLEAR";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            this.clearbutton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clearbutton_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchSTDdataGridView);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(548, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 351);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUTPUT";
            // 
            // searchSTDdataGridView
            // 
            this.searchSTDdataGridView.AllowUserToAddRows = false;
            this.searchSTDdataGridView.AllowUserToDeleteRows = false;
            this.searchSTDdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchSTDdataGridView.Location = new System.Drawing.Point(3, 17);
            this.searchSTDdataGridView.Name = "searchSTDdataGridView";
            this.searchSTDdataGridView.ReadOnly = true;
            this.searchSTDdataGridView.Size = new System.Drawing.Size(412, 334);
            this.searchSTDdataGridView.TabIndex = 0;
            this.searchSTDdataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.searchSTDdataGridView_DataBindingComplete);
            this.searchSTDdataGridView.SelectionChanged += new System.EventHandler(this.searchSTDdataGridView_SelectionChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Red;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(903, 59);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(175, 25);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.signOutToolStripMenuItem.Text = "Sign_Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 56);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(847, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT MANAGMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(803, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Search_Student_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Search_Student_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Student_Info";
            this.Load += new System.EventHandler(this.Search_Student_Info_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchSTDdataGridView)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label presentadress;
        private System.Windows.Forms.Label bloodgroup;
        private System.Windows.Forms.Label contactlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label parmanentadress;
        private System.Windows.Forms.Label faculty;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.TextBox facultytextBox;
        private System.Windows.Forms.TextBox parmanentadresstextBox;
        private System.Windows.Forms.TextBox bloodgrouptextBox;
        private System.Windows.Forms.TextBox contacttextBox;
        private System.Windows.Forms.TextBox presenttextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox agetextBox;
        private System.Windows.Forms.ComboBox gendercomboBox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.ToolStripMenuItem searchStudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchTeacherInfoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView searchSTDdataGridView;
        private System.Windows.Forms.ToolStripMenuItem searchAccoInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchResultInfoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}