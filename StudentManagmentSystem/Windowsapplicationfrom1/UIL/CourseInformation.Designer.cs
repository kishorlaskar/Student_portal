using System;

namespace WindowsFormsApplication1
{
    partial class CourseO
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
            this.Coursenamelabel = new System.Windows.Forms.Label();
            this.Courseidlabel = new System.Windows.Forms.Label();
            this.Coursecreditlabel = new System.Windows.Forms.Label();
            this.Semisterlabel = new System.Windows.Forms.Label();
            this.Coursefeelabel = new System.Windows.Forms.Label();
            this.Teacherlabe = new System.Windows.Forms.Label();
            this.coursenametextBox = new System.Windows.Forms.TextBox();
            this.courseidtextBox = new System.Windows.Forms.TextBox();
            this.CredittextBox = new System.Windows.Forms.TextBox();
            this.semistertextBox = new System.Windows.Forms.TextBox();
            this.coursefeetextBox = new System.Windows.Forms.TextBox();
            this.teachertextBox = new System.Windows.Forms.TextBox();
            this.confirmbutton1 = new System.Windows.Forms.Button();
            this.deletcoursebutton = new System.Windows.Forms.Button();
            this.CoursegroupBox = new System.Windows.Forms.GroupBox();
            this.confirmgroupBox = new System.Windows.Forms.GroupBox();
            this.CANCELbutton1 = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.CoursedataGridView1 = new System.Windows.Forms.DataGridView();
            this.existinggroupBox = new System.Windows.Forms.GroupBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courselabe = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CoursegroupBox.SuspendLayout();
            this.confirmgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoursedataGridView1)).BeginInit();
            this.existinggroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Coursenamelabel
            // 
            this.Coursenamelabel.AutoSize = true;
            this.Coursenamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coursenamelabel.Location = new System.Drawing.Point(55, 33);
            this.Coursenamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Coursenamelabel.Name = "Coursenamelabel";
            this.Coursenamelabel.Size = new System.Drawing.Size(106, 16);
            this.Coursenamelabel.TabIndex = 0;
            this.Coursenamelabel.Text = "Course Name:";
            this.Coursenamelabel.Click += new System.EventHandler(this.Coursenamelabel_Click);
            // 
            // Courseidlabel
            // 
            this.Courseidlabel.AutoSize = true;
            this.Courseidlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courseidlabel.Location = new System.Drawing.Point(43, 119);
            this.Courseidlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Courseidlabel.Name = "Courseidlabel";
            this.Courseidlabel.Size = new System.Drawing.Size(78, 16);
            this.Courseidlabel.TabIndex = 0;
            this.Courseidlabel.Text = "Course Id:";
            this.Courseidlabel.Click += new System.EventHandler(this.Courseidlabel_Click);
            // 
            // Coursecreditlabel
            // 
            this.Coursecreditlabel.AutoSize = true;
            this.Coursecreditlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coursecreditlabel.Location = new System.Drawing.Point(43, 208);
            this.Coursecreditlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Coursecreditlabel.Name = "Coursecreditlabel";
            this.Coursecreditlabel.Size = new System.Drawing.Size(106, 16);
            this.Coursecreditlabel.TabIndex = 0;
            this.Coursecreditlabel.Text = "Course Credit:";
            this.Coursecreditlabel.Click += new System.EventHandler(this.Coursecreditlabel_Click);
            // 
            // Semisterlabel
            // 
            this.Semisterlabel.AutoSize = true;
            this.Semisterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Semisterlabel.Location = new System.Drawing.Point(457, 33);
            this.Semisterlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Semisterlabel.Name = "Semisterlabel";
            this.Semisterlabel.Size = new System.Drawing.Size(69, 16);
            this.Semisterlabel.TabIndex = 0;
            this.Semisterlabel.Text = "Semister";
            // 
            // Coursefeelabel
            // 
            this.Coursefeelabel.AutoSize = true;
            this.Coursefeelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coursefeelabel.Location = new System.Drawing.Point(457, 208);
            this.Coursefeelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Coursefeelabel.Name = "Coursefeelabel";
            this.Coursefeelabel.Size = new System.Drawing.Size(88, 16);
            this.Coursefeelabel.TabIndex = 0;
            this.Coursefeelabel.Text = "Course Fee";
            this.Coursefeelabel.Click += new System.EventHandler(this.Coursefeelabel_Click);
            // 
            // Teacherlabe
            // 
            this.Teacherlabe.AutoSize = true;
            this.Teacherlabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacherlabe.Location = new System.Drawing.Point(457, 119);
            this.Teacherlabe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Teacherlabe.Name = "Teacherlabe";
            this.Teacherlabe.Size = new System.Drawing.Size(70, 16);
            this.Teacherlabe.TabIndex = 0;
            this.Teacherlabe.Text = "Teacher:";
            this.Teacherlabe.Click += new System.EventHandler(this.Teacherlabe_Click);
            // 
            // coursenametextBox
            // 
            this.coursenametextBox.Location = new System.Drawing.Point(112, 60);
            this.coursenametextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coursenametextBox.Multiline = true;
            this.coursenametextBox.Name = "coursenametextBox";
            this.coursenametextBox.Size = new System.Drawing.Size(171, 29);
            this.coursenametextBox.TabIndex = 1;
            this.coursenametextBox.TextChanged += new System.EventHandler(this.coursenametextBox_TextChanged);
            this.coursenametextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.coursenametextBox_KeyDown);
            // 
            // courseidtextBox
            // 
            this.courseidtextBox.Location = new System.Drawing.Point(112, 139);
            this.courseidtextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseidtextBox.Multiline = true;
            this.courseidtextBox.Name = "courseidtextBox";
            this.courseidtextBox.Size = new System.Drawing.Size(171, 29);
            this.courseidtextBox.TabIndex = 2;
            this.courseidtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.courseidtextBox_KeyDown);
            // 
            // CredittextBox
            // 
            this.CredittextBox.Location = new System.Drawing.Point(112, 228);
            this.CredittextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CredittextBox.Multiline = true;
            this.CredittextBox.Name = "CredittextBox";
            this.CredittextBox.Size = new System.Drawing.Size(171, 29);
            this.CredittextBox.TabIndex = 3;
            this.CredittextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.CredittextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CredittextBox_KeyDown);
            // 
            // semistertextBox
            // 
            this.semistertextBox.Location = new System.Drawing.Point(495, 60);
            this.semistertextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.semistertextBox.Multiline = true;
            this.semistertextBox.Name = "semistertextBox";
            this.semistertextBox.Size = new System.Drawing.Size(171, 29);
            this.semistertextBox.TabIndex = 4;
            this.semistertextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.semistertextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.semistertextBox_KeyDown);
            // 
            // coursefeetextBox
            // 
            this.coursefeetextBox.Location = new System.Drawing.Point(495, 228);
            this.coursefeetextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coursefeetextBox.Multiline = true;
            this.coursefeetextBox.Name = "coursefeetextBox";
            this.coursefeetextBox.Size = new System.Drawing.Size(171, 29);
            this.coursefeetextBox.TabIndex = 5;
            this.coursefeetextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.coursefeetextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.coursefeetextBox_KeyDown);
            // 
            // teachertextBox
            // 
            this.teachertextBox.Location = new System.Drawing.Point(495, 139);
            this.teachertextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teachertextBox.Multiline = true;
            this.teachertextBox.Name = "teachertextBox";
            this.teachertextBox.Size = new System.Drawing.Size(171, 29);
            this.teachertextBox.TabIndex = 6;
            this.teachertextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.teachertextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teachertextBox_KeyDown);
            // 
            // confirmbutton1
            // 
            this.confirmbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.confirmbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbutton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmbutton1.Location = new System.Drawing.Point(37, 36);
            this.confirmbutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmbutton1.Name = "confirmbutton1";
            this.confirmbutton1.Size = new System.Drawing.Size(103, 53);
            this.confirmbutton1.TabIndex = 9;
            this.confirmbutton1.Text = "Confirm";
            this.confirmbutton1.UseVisualStyleBackColor = false;
            this.confirmbutton1.Click += new System.EventHandler(this.confirmbutton1_Click);
            // 
            // deletcoursebutton
            // 
            this.deletcoursebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deletcoursebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletcoursebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletcoursebutton.Location = new System.Drawing.Point(333, 36);
            this.deletcoursebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deletcoursebutton.Name = "deletcoursebutton";
            this.deletcoursebutton.Size = new System.Drawing.Size(123, 53);
            this.deletcoursebutton.TabIndex = 10;
            this.deletcoursebutton.Text = "Delete";
            this.deletcoursebutton.UseVisualStyleBackColor = false;
            this.deletcoursebutton.Click += new System.EventHandler(this.deletcoursebutton_Click);
            // 
            // CoursegroupBox
            // 
            this.CoursegroupBox.Controls.Add(this.Coursenamelabel);
            this.CoursegroupBox.Controls.Add(this.coursenametextBox);
            this.CoursegroupBox.Controls.Add(this.Courseidlabel);
            this.CoursegroupBox.Controls.Add(this.courseidtextBox);
            this.CoursegroupBox.Controls.Add(this.Coursecreditlabel);
            this.CoursegroupBox.Controls.Add(this.teachertextBox);
            this.CoursegroupBox.Controls.Add(this.CredittextBox);
            this.CoursegroupBox.Controls.Add(this.Teacherlabe);
            this.CoursegroupBox.Controls.Add(this.coursefeetextBox);
            this.CoursegroupBox.Controls.Add(this.Semisterlabel);
            this.CoursegroupBox.Controls.Add(this.semistertextBox);
            this.CoursegroupBox.Controls.Add(this.Coursefeelabel);
            this.CoursegroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursegroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CoursegroupBox.Location = new System.Drawing.Point(47, 172);
            this.CoursegroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoursegroupBox.Name = "CoursegroupBox";
            this.CoursegroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoursegroupBox.Size = new System.Drawing.Size(741, 331);
            this.CoursegroupBox.TabIndex = 11;
            this.CoursegroupBox.TabStop = false;
            this.CoursegroupBox.Text = "ALL Course Information";
            // 
            // confirmgroupBox
            // 
            this.confirmgroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirmgroupBox.Controls.Add(this.CANCELbutton1);
            this.confirmgroupBox.Controls.Add(this.Updatebutton);
            this.confirmgroupBox.Controls.Add(this.deletcoursebutton);
            this.confirmgroupBox.Controls.Add(this.confirmbutton1);
            this.confirmgroupBox.Location = new System.Drawing.Point(47, 511);
            this.confirmgroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmgroupBox.Name = "confirmgroupBox";
            this.confirmgroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmgroupBox.Size = new System.Drawing.Size(741, 100);
            this.confirmgroupBox.TabIndex = 12;
            this.confirmgroupBox.TabStop = false;
            this.confirmgroupBox.Text = "ActiongroupBox";
            // 
            // CANCELbutton1
            // 
            this.CANCELbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CANCELbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCELbutton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CANCELbutton1.Location = new System.Drawing.Point(505, 36);
            this.CANCELbutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CANCELbutton1.Name = "CANCELbutton1";
            this.CANCELbutton1.Size = new System.Drawing.Size(123, 53);
            this.CANCELbutton1.TabIndex = 12;
            this.CANCELbutton1.Text = "Cancel\r\n";
            this.CANCELbutton1.UseVisualStyleBackColor = false;
            this.CANCELbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Updatebutton.Location = new System.Drawing.Point(189, 36);
            this.Updatebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(116, 53);
            this.Updatebutton.TabIndex = 11;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.updatebutton1_Click_1);
            // 
            // CoursedataGridView1
            // 
            this.CoursedataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursedataGridView1.Location = new System.Drawing.Point(8, 20);
            this.CoursedataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoursedataGridView1.Name = "CoursedataGridView1";
            this.CoursedataGridView1.Size = new System.Drawing.Size(441, 399);
            this.CoursedataGridView1.TabIndex = 13;
            this.CoursedataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.CoursedataGridView1_DataBindingComplete);
            this.CoursedataGridView1.SelectionChanged += new System.EventHandler(this.CoursedataGridView1_SelectionChanged);
            // 
            // existinggroupBox
            // 
            this.existinggroupBox.Controls.Add(this.CoursedataGridView1);
            this.existinggroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existinggroupBox.Location = new System.Drawing.Point(837, 172);
            this.existinggroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.existinggroupBox.Name = "existinggroupBox";
            this.existinggroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.existinggroupBox.Size = new System.Drawing.Size(449, 426);
            this.existinggroupBox.TabIndex = 14;
            this.existinggroupBox.TabStop = false;
            this.existinggroupBox.Text = "Existing Courses";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            this.menuStrip1.Location = new System.Drawing.Point(3, 84);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(504, 25);
            this.menuStrip1.TabIndex = 15;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 75);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(299, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT MANAGMENT SYSTEM";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Red;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(1208, 84);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(85, 25);
            this.menuStrip2.TabIndex = 17;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.signOutToolStripMenuItem.Text = "Sign_Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // courselabe
            // 
            this.courselabe.AutoSize = true;
            this.courselabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courselabe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.courselabe.Location = new System.Drawing.Point(1116, 84);
            this.courselabe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.courselabe.Name = "courselabe";
            this.courselabe.Size = new System.Drawing.Size(72, 18);
            this.courselabe.TabIndex = 18;
            this.courselabe.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CourseO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1329, 631);
            this.Controls.Add(this.courselabe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.existinggroupBox);
            this.Controls.Add(this.confirmgroupBox);
            this.Controls.Add(this.CoursegroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CourseO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseInformation";
            this.Load += new System.EventHandler(this.CourseO_Load);
            this.CoursegroupBox.ResumeLayout(false);
            this.CoursegroupBox.PerformLayout();
            this.confirmgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CoursedataGridView1)).EndInit();
            this.existinggroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label Coursenamelabel;
        private System.Windows.Forms.Label Courseidlabel;
        private System.Windows.Forms.Label Coursecreditlabel;
        private System.Windows.Forms.Label Semisterlabel;
        private System.Windows.Forms.Label Coursefeelabel;
        private System.Windows.Forms.Label Teacherlabe;
        private System.Windows.Forms.TextBox coursenametextBox;
        private System.Windows.Forms.TextBox courseidtextBox;
        private System.Windows.Forms.TextBox CredittextBox;
        private System.Windows.Forms.TextBox semistertextBox;
        private System.Windows.Forms.TextBox coursefeetextBox;
        private System.Windows.Forms.TextBox teachertextBox;
        private System.Windows.Forms.Button confirmbutton1;
        private System.Windows.Forms.Button deletcoursebutton;
        private System.Windows.Forms.GroupBox CoursegroupBox;
        private System.Windows.Forms.GroupBox confirmgroupBox;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.DataGridView CoursedataGridView1;
        private System.Windows.Forms.GroupBox existinggroupBox;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button CANCELbutton1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchTeacherInfoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem searchAccoInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchResultInfoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Label courselabe;
        private System.Windows.Forms.Timer timer1;

        public string Teacher { get; internal set; }
        public string Id { get; internal set; }
    }
}