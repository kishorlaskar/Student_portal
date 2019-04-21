using System;

namespace WindowsFormsApplication1
{
    partial class Teachers
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
            this.teacheridlabel = new System.Windows.Forms.Label();
            this.teachernamelabel = new System.Windows.Forms.Label();
            this.designationlabel = new System.Windows.Forms.Label();
            this.depertmentlabel = new System.Windows.Forms.Label();
            this.contactnolabel = new System.Windows.Forms.Label();
            this.courseadvisorlabel = new System.Windows.Forms.Label();
            this.councellinghourlabel = new System.Windows.Forms.Label();
            this.teachergroupBox = new System.Windows.Forms.GroupBox();
            this.salarytextBox = new System.Windows.Forms.TextBox();
            this.teacheradresstextbox = new System.Windows.Forms.TextBox();
            this.councellinghourtextBox = new System.Windows.Forms.TextBox();
            this.teacherdepertmenttextBox = new System.Windows.Forms.TextBox();
            this.teachercontacttextBox = new System.Windows.Forms.TextBox();
            this.desegnationtextBox = new System.Windows.Forms.TextBox();
            this.teachernametextBox = new System.Windows.Forms.TextBox();
            this.teacheridtextbox = new System.Windows.Forms.TextBox();
            this.courseAdvisorcomboBox = new System.Windows.Forms.ComboBox();
            this.salarylabel = new System.Windows.Forms.Label();
            this.teacheradresslabel = new System.Windows.Forms.Label();
            this.TeachersModaretiongroupBox = new System.Windows.Forms.GroupBox();
            this.teacherdeletebutton = new System.Windows.Forms.Button();
            this.teacherupdatebutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.TeacherdataGridView = new System.Windows.Forms.DataGridView();
            this.existingteachergroupBox = new System.Windows.Forms.GroupBox();
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.teachergroupBox.SuspendLayout();
            this.TeachersModaretiongroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherdataGridView)).BeginInit();
            this.existingteachergroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacheridlabel
            // 
            this.teacheridlabel.AutoSize = true;
            this.teacheridlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacheridlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teacheridlabel.Location = new System.Drawing.Point(6, 39);
            this.teacheridlabel.Name = "teacheridlabel";
            this.teacheridlabel.Size = new System.Drawing.Size(20, 13);
            this.teacheridlabel.TabIndex = 0;
            this.teacheridlabel.Text = "ID";
            // 
            // teachernamelabel
            // 
            this.teachernamelabel.AutoSize = true;
            this.teachernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachernamelabel.Location = new System.Drawing.Point(6, 91);
            this.teachernamelabel.Name = "teachernamelabel";
            this.teachernamelabel.Size = new System.Drawing.Size(46, 13);
            this.teachernamelabel.TabIndex = 0;
            this.teachernamelabel.Text = "NAME:";
            // 
            // designationlabel
            // 
            this.designationlabel.AutoSize = true;
            this.designationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designationlabel.Location = new System.Drawing.Point(0, 147);
            this.designationlabel.Name = "designationlabel";
            this.designationlabel.Size = new System.Drawing.Size(96, 13);
            this.designationlabel.TabIndex = 0;
            this.designationlabel.Text = "DESIGNATION:";
            // 
            // depertmentlabel
            // 
            this.depertmentlabel.AutoSize = true;
            this.depertmentlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depertmentlabel.Location = new System.Drawing.Point(-3, 208);
            this.depertmentlabel.Name = "depertmentlabel";
            this.depertmentlabel.Size = new System.Drawing.Size(96, 13);
            this.depertmentlabel.TabIndex = 0;
            this.depertmentlabel.Text = "DEPERTMENT:";
            // 
            // contactnolabel
            // 
            this.contactnolabel.AutoSize = true;
            this.contactnolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactnolabel.Location = new System.Drawing.Point(311, 29);
            this.contactnolabel.Name = "contactnolabel";
            this.contactnolabel.Size = new System.Drawing.Size(91, 13);
            this.contactnolabel.TabIndex = 0;
            this.contactnolabel.Text = "CONTACT NO:";
            // 
            // courseadvisorlabel
            // 
            this.courseadvisorlabel.AutoSize = true;
            this.courseadvisorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseadvisorlabel.Location = new System.Drawing.Point(281, 75);
            this.courseadvisorlabel.Name = "courseadvisorlabel";
            this.courseadvisorlabel.Size = new System.Drawing.Size(121, 13);
            this.courseadvisorlabel.TabIndex = 0;
            this.courseadvisorlabel.Text = "COURSE ADVISOR:";
            // 
            // councellinghourlabel
            // 
            this.councellinghourlabel.AutoSize = true;
            this.councellinghourlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.councellinghourlabel.Location = new System.Drawing.Point(264, 124);
            this.councellinghourlabel.Name = "councellinghourlabel";
            this.councellinghourlabel.Size = new System.Drawing.Size(138, 13);
            this.councellinghourlabel.TabIndex = 0;
            this.councellinghourlabel.Text = "COUNCELLING HOUR:";
            // 
            // teachergroupBox
            // 
            this.teachergroupBox.Controls.Add(this.salarytextBox);
            this.teachergroupBox.Controls.Add(this.teacheradresstextbox);
            this.teachergroupBox.Controls.Add(this.councellinghourtextBox);
            this.teachergroupBox.Controls.Add(this.teacherdepertmenttextBox);
            this.teachergroupBox.Controls.Add(this.teachercontacttextBox);
            this.teachergroupBox.Controls.Add(this.desegnationtextBox);
            this.teachergroupBox.Controls.Add(this.teachernametextBox);
            this.teachergroupBox.Controls.Add(this.teacheridtextbox);
            this.teachergroupBox.Controls.Add(this.courseAdvisorcomboBox);
            this.teachergroupBox.Controls.Add(this.salarylabel);
            this.teachergroupBox.Controls.Add(this.teacheradresslabel);
            this.teachergroupBox.Controls.Add(this.courseadvisorlabel);
            this.teachergroupBox.Controls.Add(this.depertmentlabel);
            this.teachergroupBox.Controls.Add(this.councellinghourlabel);
            this.teachergroupBox.Controls.Add(this.teachernamelabel);
            this.teachergroupBox.Controls.Add(this.designationlabel);
            this.teachergroupBox.Controls.Add(this.contactnolabel);
            this.teachergroupBox.Controls.Add(this.teacheridlabel);
            this.teachergroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachergroupBox.Location = new System.Drawing.Point(25, 148);
            this.teachergroupBox.Name = "teachergroupBox";
            this.teachergroupBox.Size = new System.Drawing.Size(506, 259);
            this.teachergroupBox.TabIndex = 1;
            this.teachergroupBox.TabStop = false;
            this.teachergroupBox.Text = "TeachersInfo";
            // 
            // salarytextBox
            // 
            this.salarytextBox.Location = new System.Drawing.Point(386, 233);
            this.salarytextBox.Name = "salarytextBox";
            this.salarytextBox.Size = new System.Drawing.Size(100, 21);
            this.salarytextBox.TabIndex = 3;
            this.salarytextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.salarytextBox_KeyDown);
            // 
            // teacheradresstextbox
            // 
            this.teacheradresstextbox.Location = new System.Drawing.Point(386, 182);
            this.teacheradresstextbox.Name = "teacheradresstextbox";
            this.teacheradresstextbox.Size = new System.Drawing.Size(100, 21);
            this.teacheradresstextbox.TabIndex = 3;
            this.teacheradresstextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teacheradresstextbox_KeyDown);
            // 
            // councellinghourtextBox
            // 
            this.councellinghourtextBox.Location = new System.Drawing.Point(386, 144);
            this.councellinghourtextBox.Name = "councellinghourtextBox";
            this.councellinghourtextBox.Size = new System.Drawing.Size(100, 21);
            this.councellinghourtextBox.TabIndex = 3;
            this.councellinghourtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.councellinghourtextBox_KeyDown);
            // 
            // teacherdepertmenttextBox
            // 
            this.teacherdepertmenttextBox.Location = new System.Drawing.Point(15, 233);
            this.teacherdepertmenttextBox.Name = "teacherdepertmenttextBox";
            this.teacherdepertmenttextBox.Size = new System.Drawing.Size(100, 21);
            this.teacherdepertmenttextBox.TabIndex = 3;
            this.teacherdepertmenttextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teacherdepertmenttextBox_KeyDown);
            // 
            // teachercontacttextBox
            // 
            this.teachercontacttextBox.Location = new System.Drawing.Point(386, 52);
            this.teachercontacttextBox.Name = "teachercontacttextBox";
            this.teachercontacttextBox.Size = new System.Drawing.Size(100, 21);
            this.teachercontacttextBox.TabIndex = 3;
            this.teachercontacttextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teachercontacttextBox_KeyDown);
            // 
            // desegnationtextBox
            // 
            this.desegnationtextBox.Location = new System.Drawing.Point(15, 167);
            this.desegnationtextBox.Name = "desegnationtextBox";
            this.desegnationtextBox.Size = new System.Drawing.Size(100, 21);
            this.desegnationtextBox.TabIndex = 3;
            this.desegnationtextBox.TextChanged += new System.EventHandler(this.desegnationtextBox_TextChanged);
            this.desegnationtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.desegnationtextBox_KeyDown);
            // 
            // teachernametextBox
            // 
            this.teachernametextBox.Location = new System.Drawing.Point(15, 117);
            this.teachernametextBox.Name = "teachernametextBox";
            this.teachernametextBox.Size = new System.Drawing.Size(100, 21);
            this.teachernametextBox.TabIndex = 3;
            this.teachernametextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teachernametextBox_KeyDown);
            // 
            // teacheridtextbox
            // 
            this.teacheridtextbox.Location = new System.Drawing.Point(15, 55);
            this.teacheridtextbox.Name = "teacheridtextbox";
            this.teacheridtextbox.Size = new System.Drawing.Size(100, 21);
            this.teacheridtextbox.TabIndex = 3;
            this.teacheridtextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teacheridtextbox_KeyDown);
            // 
            // courseAdvisorcomboBox
            // 
            this.courseAdvisorcomboBox.FormattingEnabled = true;
            this.courseAdvisorcomboBox.Items.AddRange(new object[] {
            "Computer Fundamental",
            "C- language",
            "C++ language",
            "C# language",
            "Data Communication\'",
            "Ordinary and Differential Equation",
            "Intregation Factors",
            "Electronics Device",
            "Electrical & Electronics",
            "Digital Electronics",
            "Bangladsh Studis",
            "Statictis&Probablity",
            "Algorothim",
            "Web Desigining ",
            "Data Mining",
            "Graphics Designing",
            "Data Structure",
            "Economics",
            "Finance",
            "English & Liteachery",
            "Free Lancing",
            "Art of Living"});
            this.courseAdvisorcomboBox.Location = new System.Drawing.Point(386, 91);
            this.courseAdvisorcomboBox.Name = "courseAdvisorcomboBox";
            this.courseAdvisorcomboBox.Size = new System.Drawing.Size(100, 23);
            this.courseAdvisorcomboBox.TabIndex = 2;
            this.courseAdvisorcomboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.courseAdvisorcomboBox_KeyDown);
            // 
            // salarylabel
            // 
            this.salarylabel.AutoSize = true;
            this.salarylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarylabel.Location = new System.Drawing.Point(335, 208);
            this.salarylabel.Name = "salarylabel";
            this.salarylabel.Size = new System.Drawing.Size(59, 13);
            this.salarylabel.TabIndex = 1;
            this.salarylabel.Text = "SALARY:";
            // 
            // teacheradresslabel
            // 
            this.teacheradresslabel.AutoSize = true;
            this.teacheradresslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacheradresslabel.Location = new System.Drawing.Point(326, 167);
            this.teacheradresslabel.Name = "teacheradresslabel";
            this.teacheradresslabel.Size = new System.Drawing.Size(61, 13);
            this.teacheradresslabel.TabIndex = 1;
            this.teacheradresslabel.Text = "ADRESS:";
            // 
            // TeachersModaretiongroupBox
            // 
            this.TeachersModaretiongroupBox.Controls.Add(this.teacherdeletebutton);
            this.TeachersModaretiongroupBox.Controls.Add(this.teacherupdatebutton);
            this.TeachersModaretiongroupBox.Controls.Add(this.Savebutton);
            this.TeachersModaretiongroupBox.Controls.Add(this.clearbutton);
            this.TeachersModaretiongroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeachersModaretiongroupBox.Location = new System.Drawing.Point(9, 431);
            this.TeachersModaretiongroupBox.Name = "TeachersModaretiongroupBox";
            this.TeachersModaretiongroupBox.Size = new System.Drawing.Size(522, 76);
            this.TeachersModaretiongroupBox.TabIndex = 4;
            this.TeachersModaretiongroupBox.TabStop = false;
            this.TeachersModaretiongroupBox.Text = "TeacherModaretion";
            // 
            // teacherdeletebutton
            // 
            this.teacherdeletebutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.teacherdeletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherdeletebutton.Location = new System.Drawing.Point(262, 19);
            this.teacherdeletebutton.Name = "teacherdeletebutton";
            this.teacherdeletebutton.Size = new System.Drawing.Size(102, 51);
            this.teacherdeletebutton.TabIndex = 4;
            this.teacherdeletebutton.Text = "DELETE";
            this.teacherdeletebutton.UseVisualStyleBackColor = false;
            this.teacherdeletebutton.Click += new System.EventHandler(this.teacherdeletebutton_Click);
            // 
            // teacherupdatebutton
            // 
            this.teacherupdatebutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.teacherupdatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherupdatebutton.Location = new System.Drawing.Point(124, 19);
            this.teacherupdatebutton.Name = "teacherupdatebutton";
            this.teacherupdatebutton.Size = new System.Drawing.Size(99, 51);
            this.teacherupdatebutton.TabIndex = 3;
            this.teacherupdatebutton.Text = "UPDATE";
            this.teacherupdatebutton.UseVisualStyleBackColor = false;
            this.teacherupdatebutton.Click += new System.EventHandler(this.teacherupdatebutton_Click_1);
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.Location = new System.Drawing.Point(6, 19);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(90, 51);
            this.Savebutton.TabIndex = 2;
            this.Savebutton.Text = "SAVE";
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.Location = new System.Drawing.Point(402, 19);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(100, 51);
            this.clearbutton.TabIndex = 0;
            this.clearbutton.Text = "CLEAR";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeacherdataGridView
            // 
            this.TeacherdataGridView.AllowUserToAddRows = false;
            this.TeacherdataGridView.AllowUserToDeleteRows = false;
            this.TeacherdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherdataGridView.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.TeacherdataGridView.Location = new System.Drawing.Point(6, 19);
            this.TeacherdataGridView.Name = "TeacherdataGridView";
            this.TeacherdataGridView.ReadOnly = true;
            this.TeacherdataGridView.Size = new System.Drawing.Size(367, 323);
            this.TeacherdataGridView.TabIndex = 5;
            this.TeacherdataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.TeacherdataGridView_DataBindingComplete);
            this.TeacherdataGridView.SelectionChanged += new System.EventHandler(this.TeacherdataGridView_SelectionChanged);
            // 
            // existingteachergroupBox
            // 
            this.existingteachergroupBox.Controls.Add(this.TeacherdataGridView);
            this.existingteachergroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existingteachergroupBox.Location = new System.Drawing.Point(557, 159);
            this.existingteachergroupBox.Name = "existingteachergroupBox";
            this.existingteachergroupBox.Size = new System.Drawing.Size(379, 348);
            this.existingteachergroupBox.TabIndex = 6;
            this.existingteachergroupBox.TabStop = false;
            this.existingteachergroupBox.Text = "ExistingTeacher";
            this.existingteachergroupBox.Enter += new System.EventHandler(this.groupBox1_Enter_1);
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
            this.toolStripMenuItem1,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(15, 81);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
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
            this.searchResultInfoToolStripMenuItem.Text = "Search Result Info";
            this.searchResultInfoToolStripMenuItem.Click += new System.EventHandler(this.searchResultInfoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 21);
            this.toolStripMenuItem1.Text = "Report";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 66);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(815, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT MANAGMENT SYSTEM";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Red;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(928, 81);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(83, 25);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.signOutToolStripMenuItem.Text = "Sign_Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click_1);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(836, 81);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(72, 18);
            this.label.TabIndex = 9;
            this.label.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 570);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.existingteachergroupBox);
            this.Controls.Add(this.TeachersModaretiongroupBox);
            this.Controls.Add(this.teachergroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teacher_Load);
            this.teachergroupBox.ResumeLayout(false);
            this.teachergroupBox.PerformLayout();
            this.TeachersModaretiongroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherdataGridView)).EndInit();
            this.existingteachergroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Teacherupdatebutton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label teacheridlabel;
        private System.Windows.Forms.Label teachernamelabel;
        private System.Windows.Forms.Label designationlabel;
        private System.Windows.Forms.Label depertmentlabel;
        private System.Windows.Forms.Label contactnolabel;
        private System.Windows.Forms.Label courseadvisorlabel;
        private System.Windows.Forms.Label councellinghourlabel;
        private System.Windows.Forms.GroupBox teachergroupBox;
        private System.Windows.Forms.ComboBox courseAdvisorcomboBox;
        private System.Windows.Forms.Label teacheradresslabel;
        private System.Windows.Forms.TextBox teacheridtextbox;
        private System.Windows.Forms.TextBox teacheradresstextbox;
        private System.Windows.Forms.TextBox councellinghourtextBox;
        private System.Windows.Forms.TextBox teacherdepertmenttextBox;
        private System.Windows.Forms.TextBox teachercontacttextBox;
        private System.Windows.Forms.TextBox desegnationtextBox;
        private System.Windows.Forms.TextBox teachernametextBox;
        private System.Windows.Forms.GroupBox TeachersModaretiongroupBox;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Label salarylabel;
        private System.Windows.Forms.TextBox salarytextBox;
        private System.Windows.Forms.DataGridView TeacherdataGridView;
        private System.Windows.Forms.GroupBox existingteachergroupBox;
        private System.Windows.Forms.Button teacherupdatebutton;
        private System.Windows.Forms.Button teacherdeletebutton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchTeacherInfoToolStripMenuItem;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem searchAccoInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchResultInfoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timer1;

        public string ContactNo { get; internal set; }
        public string Councellinghour { get; internal set; }
    }
}