using System;

namespace WindowsFormsApplication1
{
    partial class Students
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
            this.savebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gendercomboBox = new System.Windows.Forms.ComboBox();
            this.agetextBox = new System.Windows.Forms.TextBox();
            this.bloodgrouptextBox = new System.Windows.Forms.TextBox();
            this.contactnotextBox = new System.Windows.Forms.TextBox();
            this.massagetextBox = new System.Windows.Forms.TextBox();
            this.presentadresstextBox = new System.Windows.Forms.TextBox();
            this.parmanentadresstextBox = new System.Windows.Forms.TextBox();
            this.facultytextBox = new System.Windows.Forms.TextBox();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cancelbutton1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentdataGridView = new System.Windows.Forms.DataGridView();
            this.studentgroupBox = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentdataGridView)).BeginInit();
            this.studentgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.savebutton.Location = new System.Drawing.Point(42, 33);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(101, 40);
            this.savebutton.TabIndex = 1;
            this.savebutton.Text = "SAVE";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deletebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deletebutton.Location = new System.Drawing.Point(285, 33);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(105, 40);
            this.deletebutton.TabIndex = 1;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updatebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updatebutton.Location = new System.Drawing.Point(174, 33);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(92, 40);
            this.updatebutton.TabIndex = 1;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox2.Controls.Add(this.gendercomboBox);
            this.groupBox2.Controls.Add(this.agetextBox);
            this.groupBox2.Controls.Add(this.bloodgrouptextBox);
            this.groupBox2.Controls.Add(this.contactnotextBox);
            this.groupBox2.Controls.Add(this.massagetextBox);
            this.groupBox2.Controls.Add(this.presentadresstextBox);
            this.groupBox2.Controls.Add(this.parmanentadresstextBox);
            this.groupBox2.Controls.Add(this.facultytextBox);
            this.groupBox2.Controls.Add(this.idtextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 321);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add student information";
            // 
            // gendercomboBox
            // 
            this.gendercomboBox.FormattingEnabled = true;
            this.gendercomboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendercomboBox.Location = new System.Drawing.Point(402, 109);
            this.gendercomboBox.Name = "gendercomboBox";
            this.gendercomboBox.Size = new System.Drawing.Size(100, 21);
            this.gendercomboBox.TabIndex = 7;
            this.gendercomboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gendercomboBox_KeyDown);
            // 
            // agetextBox
            // 
            this.agetextBox.Location = new System.Drawing.Point(106, 153);
            this.agetextBox.Name = "agetextBox";
            this.agetextBox.Size = new System.Drawing.Size(100, 20);
            this.agetextBox.TabIndex = 6;
            this.agetextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.agetextBox_KeyDown);
            // 
            // bloodgrouptextBox
            // 
            this.bloodgrouptextBox.Location = new System.Drawing.Point(402, 205);
            this.bloodgrouptextBox.Name = "bloodgrouptextBox";
            this.bloodgrouptextBox.Size = new System.Drawing.Size(100, 20);
            this.bloodgrouptextBox.TabIndex = 5;
            this.bloodgrouptextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bloodgrouptextBox_KeyDown);
            // 
            // contactnotextBox
            // 
            this.contactnotextBox.Location = new System.Drawing.Point(402, 160);
            this.contactnotextBox.Name = "contactnotextBox";
            this.contactnotextBox.Size = new System.Drawing.Size(100, 20);
            this.contactnotextBox.TabIndex = 3;
            this.contactnotextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contactnotextBox_KeyDown);
            // 
            // massagetextBox
            // 
            this.massagetextBox.Location = new System.Drawing.Point(106, 64);
            this.massagetextBox.Name = "massagetextBox";
            this.massagetextBox.Size = new System.Drawing.Size(100, 20);
            this.massagetextBox.TabIndex = 2;
            this.massagetextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.massagetextBox_KeyDown);
            // 
            // presentadresstextBox
            // 
            this.presentadresstextBox.Location = new System.Drawing.Point(402, 76);
            this.presentadresstextBox.Name = "presentadresstextBox";
            this.presentadresstextBox.Size = new System.Drawing.Size(100, 20);
            this.presentadresstextBox.TabIndex = 2;
            this.presentadresstextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.presentadresstextBox_KeyDown);
            // 
            // parmanentadresstextBox
            // 
            this.parmanentadresstextBox.Location = new System.Drawing.Point(107, 245);
            this.parmanentadresstextBox.Name = "parmanentadresstextBox";
            this.parmanentadresstextBox.Size = new System.Drawing.Size(100, 20);
            this.parmanentadresstextBox.TabIndex = 2;
            this.parmanentadresstextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.parmanentadresstextBox_KeyDown);
            // 
            // facultytextBox
            // 
            this.facultytextBox.Location = new System.Drawing.Point(106, 201);
            this.facultytextBox.Name = "facultytextBox";
            this.facultytextBox.Size = new System.Drawing.Size(100, 20);
            this.facultytextBox.TabIndex = 2;
            this.facultytextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.facultytextBox_KeyDown);
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(106, 105);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(100, 20);
            this.idtextBox.TabIndex = 2;
            this.idtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idtextBox_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Blood Group";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Contact No";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(298, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Gender";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(274, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Present Adress";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 255);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Parmanent Adress";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Faculty";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Age";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Id";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Name";
            // 
            // cancelbutton1
            // 
            this.cancelbutton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelbutton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelbutton1.Location = new System.Drawing.Point(432, 33);
            this.cancelbutton1.Name = "cancelbutton1";
            this.cancelbutton1.Size = new System.Drawing.Size(93, 40);
            this.cancelbutton1.TabIndex = 2;
            this.cancelbutton1.Text = "CANCEL";
            this.cancelbutton1.UseVisualStyleBackColor = false;
            this.cancelbutton1.Click += new System.EventHandler(this.cancelbutton_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Blue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.teacherToolStripMenuItem,
            this.teacherToolStripMenuItem1,
            this.accountToolStripMenuItem,
            this.resultToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 55);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.teacherToolStripMenuItem.Text = "Course";
            this.teacherToolStripMenuItem.Click += new System.EventHandler(this.teacherToolStripMenuItem_Click);
            // 
            // teacherToolStripMenuItem1
            // 
            this.teacherToolStripMenuItem1.Name = "teacherToolStripMenuItem1";
            this.teacherToolStripMenuItem1.Size = new System.Drawing.Size(67, 21);
            this.teacherToolStripMenuItem1.Text = "Teacher";
            this.teacherToolStripMenuItem1.Click += new System.EventHandler(this.teacherToolStripMenuItem1_Click);
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
            this.searchResultInfoToolStripMenuItem.Text = "Search Result info";
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
            this.groupBox1.BackColor = System.Drawing.Color.Navy;
            this.groupBox1.Controls.Add(this.cancelbutton1);
            this.groupBox1.Controls.Add(this.deletebutton);
            this.groupBox1.Controls.Add(this.savebutton);
            this.groupBox1.Controls.Add(this.updatebutton);
            this.groupBox1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Location = new System.Drawing.Point(21, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 88);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 49);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT MANAGMENT SYSTEM";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Red;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(1022, 55);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(83, 25);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.signOutToolStripMenuItem.Text = "Sign_Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // StudentdataGridView
            // 
            this.StudentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentdataGridView.Location = new System.Drawing.Point(6, 19);
            this.StudentdataGridView.Name = "StudentdataGridView";
            this.StudentdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentdataGridView.Size = new System.Drawing.Size(472, 339);
            this.StudentdataGridView.TabIndex = 0;
            this.StudentdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentdataGridView_CellContentClick);
            this.StudentdataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StudentdataGridView_CellMouseClick);
            this.StudentdataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.StudentdataGridView_DataBindingComplete);
            this.StudentdataGridView.SelectionChanged += new System.EventHandler(this.StudentdataGridView_SelectionChanged);
            // 
            // studentgroupBox
            // 
            this.studentgroupBox.Controls.Add(this.StudentdataGridView);
            this.studentgroupBox.Location = new System.Drawing.Point(621, 105);
            this.studentgroupBox.Name = "studentgroupBox";
            this.studentgroupBox.Size = new System.Drawing.Size(499, 358);
            this.studentgroupBox.TabIndex = 3;
            this.studentgroupBox.TabStop = false;
            this.studentgroupBox.Text = "Existing Student Information";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(905, 55);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 24);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1111, 572);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.studentgroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentdataGridView)).EndInit();
            this.studentgroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       
        private void StudentdataGridView_SelectionChanged(object sender, EventArgs e)
        {

            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox massagetextBox;
        private System.Windows.Forms.TextBox presentadresstextBox;
        private System.Windows.Forms.TextBox parmanentadresstextBox;
        private System.Windows.Forms.TextBox facultytextBox;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox contactnotextBox;
        private System.Windows.Forms.ComboBox gendercomboBox;
        private System.Windows.Forms.TextBox agetextBox;
        private System.Windows.Forms.TextBox bloodgrouptextBox;
        private System.Windows.Forms.Button cancelbutton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchTeacherInfoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem searchAccoInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchResultInfoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.DataGridView StudentdataGridView;
        private System.Windows.Forms.GroupBox studentgroupBox;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timer1;
    }
}