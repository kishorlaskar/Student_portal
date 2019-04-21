namespace WindowsFormsApplication1
{
    partial class RESULTUI
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
            this.actiongroupBox = new System.Windows.Forms.GroupBox();
            this.clearresultbutton = new System.Windows.Forms.Button();
            this.deleteresultbutton = new System.Windows.Forms.Button();
            this.updateresultbutton = new System.Windows.Forms.Button();
            this.saveresultbutton = new System.Windows.Forms.Button();
            this.courscodelabel = new System.Windows.Forms.Label();
            this.greadlabel = new System.Windows.Forms.Label();
            this.coursetitlelabel = new System.Windows.Forms.Label();
            this.sgpalabel = new System.Windows.Forms.Label();
            this.depertmentlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.sidtextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.depertmenttextBox = new System.Windows.Forms.TextBox();
            this.coursetitletextBox = new System.Windows.Forms.TextBox();
            this.coursecodetextBox = new System.Windows.Forms.TextBox();
            this.sgpatextBox = new System.Windows.Forms.TextBox();
            this.sidlabel = new System.Windows.Forms.Label();
            this.greadcomboBox = new System.Windows.Forms.ComboBox();
            this.resultinfogroupBox = new System.Windows.Forms.GroupBox();
            this.allresultgroupbox = new System.Windows.Forms.GroupBox();
            this.ResultdataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTeacherInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAccoInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchResultInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.actiongroupBox.SuspendLayout();
            this.resultinfogroupBox.SuspendLayout();
            this.allresultgroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultdataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // actiongroupBox
            // 
            this.actiongroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.actiongroupBox.Controls.Add(this.clearresultbutton);
            this.actiongroupBox.Controls.Add(this.deleteresultbutton);
            this.actiongroupBox.Controls.Add(this.updateresultbutton);
            this.actiongroupBox.Controls.Add(this.saveresultbutton);
            this.actiongroupBox.Location = new System.Drawing.Point(12, 419);
            this.actiongroupBox.Name = "actiongroupBox";
            this.actiongroupBox.Size = new System.Drawing.Size(484, 100);
            this.actiongroupBox.TabIndex = 2;
            this.actiongroupBox.TabStop = false;
            this.actiongroupBox.Text = "ACTION";
            // 
            // clearresultbutton
            // 
            this.clearresultbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearresultbutton.Location = new System.Drawing.Point(350, 34);
            this.clearresultbutton.Name = "clearresultbutton";
            this.clearresultbutton.Size = new System.Drawing.Size(93, 50);
            this.clearresultbutton.TabIndex = 0;
            this.clearresultbutton.Text = "CLEAR";
            this.clearresultbutton.UseVisualStyleBackColor = true;
            this.clearresultbutton.Click += new System.EventHandler(this.clearresultbutton_Click);
            // 
            // deleteresultbutton
            // 
            this.deleteresultbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteresultbutton.Location = new System.Drawing.Point(230, 34);
            this.deleteresultbutton.Name = "deleteresultbutton";
            this.deleteresultbutton.Size = new System.Drawing.Size(91, 50);
            this.deleteresultbutton.TabIndex = 0;
            this.deleteresultbutton.Text = "DELETE";
            this.deleteresultbutton.UseVisualStyleBackColor = true;
            this.deleteresultbutton.Click += new System.EventHandler(this.deleteresultbutton_Click);
            // 
            // updateresultbutton
            // 
            this.updateresultbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateresultbutton.Location = new System.Drawing.Point(119, 34);
            this.updateresultbutton.Name = "updateresultbutton";
            this.updateresultbutton.Size = new System.Drawing.Size(85, 50);
            this.updateresultbutton.TabIndex = 0;
            this.updateresultbutton.Text = "UPDATE";
            this.updateresultbutton.UseVisualStyleBackColor = true;
            this.updateresultbutton.Click += new System.EventHandler(this.updateresultbutton_Click);
            // 
            // saveresultbutton
            // 
            this.saveresultbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveresultbutton.ForeColor = System.Drawing.Color.Black;
            this.saveresultbutton.Location = new System.Drawing.Point(27, 34);
            this.saveresultbutton.Name = "saveresultbutton";
            this.saveresultbutton.Size = new System.Drawing.Size(79, 50);
            this.saveresultbutton.TabIndex = 0;
            this.saveresultbutton.Text = "SAVE";
            this.saveresultbutton.UseVisualStyleBackColor = true;
            this.saveresultbutton.Click += new System.EventHandler(this.saveresultbutton_Click);
            // 
            // courscodelabel
            // 
            this.courscodelabel.AutoSize = true;
            this.courscodelabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.courscodelabel.Location = new System.Drawing.Point(24, 165);
            this.courscodelabel.Name = "courscodelabel";
            this.courscodelabel.Size = new System.Drawing.Size(110, 15);
            this.courscodelabel.TabIndex = 0;
            this.courscodelabel.Text = "COURSE CODE:";
            // 
            // greadlabel
            // 
            this.greadlabel.AutoSize = true;
            this.greadlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.greadlabel.Location = new System.Drawing.Point(24, 201);
            this.greadlabel.Name = "greadlabel";
            this.greadlabel.Size = new System.Drawing.Size(58, 15);
            this.greadlabel.TabIndex = 0;
            this.greadlabel.Text = "GREAD:";
            // 
            // coursetitlelabel
            // 
            this.coursetitlelabel.AutoSize = true;
            this.coursetitlelabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.coursetitlelabel.Location = new System.Drawing.Point(24, 133);
            this.coursetitlelabel.Name = "coursetitlelabel";
            this.coursetitlelabel.Size = new System.Drawing.Size(109, 15);
            this.coursetitlelabel.TabIndex = 0;
            this.coursetitlelabel.Text = "COURSE TITLE:";
            // 
            // sgpalabel
            // 
            this.sgpalabel.AutoSize = true;
            this.sgpalabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sgpalabel.Location = new System.Drawing.Point(24, 231);
            this.sgpalabel.Name = "sgpalabel";
            this.sgpalabel.Size = new System.Drawing.Size(47, 15);
            this.sgpalabel.TabIndex = 0;
            this.sgpalabel.Text = "SGPA:";
            // 
            // depertmentlabel
            // 
            this.depertmentlabel.AutoSize = true;
            this.depertmentlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.depertmentlabel.Location = new System.Drawing.Point(24, 99);
            this.depertmentlabel.Name = "depertmentlabel";
            this.depertmentlabel.Size = new System.Drawing.Size(101, 15);
            this.depertmentlabel.TabIndex = 0;
            this.depertmentlabel.Text = "DEPERTMENT";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.namelabel.Location = new System.Drawing.Point(24, 63);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(50, 15);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "NAME:";
            // 
            // sidtextBox
            // 
            this.sidtextBox.Location = new System.Drawing.Point(158, 28);
            this.sidtextBox.Name = "sidtextBox";
            this.sidtextBox.Size = new System.Drawing.Size(100, 21);
            this.sidtextBox.TabIndex = 0;
            this.sidtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sidtextBox_KeyDown);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(158, 63);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 21);
            this.nametextBox.TabIndex = 0;
            this.nametextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nametextBox_KeyDown);
            // 
            // depertmenttextBox
            // 
            this.depertmenttextBox.Location = new System.Drawing.Point(158, 99);
            this.depertmenttextBox.Name = "depertmenttextBox";
            this.depertmenttextBox.Size = new System.Drawing.Size(100, 21);
            this.depertmenttextBox.TabIndex = 0;
            this.depertmenttextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.depertmenttextBox_KeyDown);
            // 
            // coursetitletextBox
            // 
            this.coursetitletextBox.Location = new System.Drawing.Point(158, 133);
            this.coursetitletextBox.Name = "coursetitletextBox";
            this.coursetitletextBox.Size = new System.Drawing.Size(100, 21);
            this.coursetitletextBox.TabIndex = 0;
            this.coursetitletextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.coursetitletextBox_KeyDown);
            // 
            // coursecodetextBox
            // 
            this.coursecodetextBox.Location = new System.Drawing.Point(158, 165);
            this.coursecodetextBox.Name = "coursecodetextBox";
            this.coursecodetextBox.Size = new System.Drawing.Size(100, 21);
            this.coursecodetextBox.TabIndex = 0;
            this.coursecodetextBox.TextChanged += new System.EventHandler(this.coursecodetextBox_TextChanged);
            this.coursecodetextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.coursecodetextBox_KeyDown);
            // 
            // sgpatextBox
            // 
            this.sgpatextBox.Location = new System.Drawing.Point(158, 231);
            this.sgpatextBox.Name = "sgpatextBox";
            this.sgpatextBox.Size = new System.Drawing.Size(100, 21);
            this.sgpatextBox.TabIndex = 0;
            this.sgpatextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sgpatextBox_KeyDown);
            // 
            // sidlabel
            // 
            this.sidlabel.AutoSize = true;
            this.sidlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sidlabel.Location = new System.Drawing.Point(24, 28);
            this.sidlabel.Name = "sidlabel";
            this.sidlabel.Size = new System.Drawing.Size(30, 15);
            this.sidlabel.TabIndex = 0;
            this.sidlabel.Text = "SID";
            // 
            // greadcomboBox
            // 
            this.greadcomboBox.FormattingEnabled = true;
            this.greadcomboBox.Items.AddRange(new object[] {
            "A+",
            "A",
            "A-",
            "B+",
            "B",
            "C+",
            "C-",
            "D",
            "F"});
            this.greadcomboBox.Location = new System.Drawing.Point(158, 201);
            this.greadcomboBox.Name = "greadcomboBox";
            this.greadcomboBox.Size = new System.Drawing.Size(100, 23);
            this.greadcomboBox.TabIndex = 1;
            this.greadcomboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.greadcomboBox_KeyDown);
            // 
            // resultinfogroupBox
            // 
            this.resultinfogroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.resultinfogroupBox.Controls.Add(this.greadcomboBox);
            this.resultinfogroupBox.Controls.Add(this.sidlabel);
            this.resultinfogroupBox.Controls.Add(this.sgpatextBox);
            this.resultinfogroupBox.Controls.Add(this.coursecodetextBox);
            this.resultinfogroupBox.Controls.Add(this.coursetitletextBox);
            this.resultinfogroupBox.Controls.Add(this.depertmenttextBox);
            this.resultinfogroupBox.Controls.Add(this.nametextBox);
            this.resultinfogroupBox.Controls.Add(this.sidtextBox);
            this.resultinfogroupBox.Controls.Add(this.namelabel);
            this.resultinfogroupBox.Controls.Add(this.depertmentlabel);
            this.resultinfogroupBox.Controls.Add(this.sgpalabel);
            this.resultinfogroupBox.Controls.Add(this.coursetitlelabel);
            this.resultinfogroupBox.Controls.Add(this.greadlabel);
            this.resultinfogroupBox.Controls.Add(this.courscodelabel);
            this.resultinfogroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultinfogroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.resultinfogroupBox.Location = new System.Drawing.Point(12, 118);
            this.resultinfogroupBox.Name = "resultinfogroupBox";
            this.resultinfogroupBox.Size = new System.Drawing.Size(484, 282);
            this.resultinfogroupBox.TabIndex = 1;
            this.resultinfogroupBox.TabStop = false;
            this.resultinfogroupBox.Text = "RESULT INFO";
            // 
            // allresultgroupbox
            // 
            this.allresultgroupbox.Controls.Add(this.ResultdataGridView1);
            this.allresultgroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allresultgroupbox.Location = new System.Drawing.Point(502, 118);
            this.allresultgroupbox.Name = "allresultgroupbox";
            this.allresultgroupbox.Size = new System.Drawing.Size(555, 386);
            this.allresultgroupbox.TabIndex = 2;
            this.allresultgroupbox.TabStop = false;
            this.allresultgroupbox.Text = "All Results";
            // 
            // ResultdataGridView1
            // 
            this.ResultdataGridView1.AllowUserToAddRows = false;
            this.ResultdataGridView1.AllowUserToDeleteRows = false;
            this.ResultdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultdataGridView1.Location = new System.Drawing.Point(12, 21);
            this.ResultdataGridView1.Name = "ResultdataGridView1";
            this.ResultdataGridView1.ReadOnly = true;
            this.ResultdataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResultdataGridView1.Size = new System.Drawing.Size(543, 366);
            this.ResultdataGridView1.TabIndex = 0;
            this.ResultdataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ResultdataGridView1_DataBindingComplete);
            this.ResultdataGridView1.SelectionChanged += new System.EventHandler(this.ResultdataGridView1_SelectionChanged);
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
            this.backToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.backToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 72);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 25);
            this.menuStrip1.TabIndex = 3;
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
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchStudentInfoToolStripMenuItem,
            this.searchTeacherInfoToolStripMenuItem,
            this.searchAccoInfoToolStripMenuItem,
            this.searchResultInfoToolStripMenuItem});
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.backToolStripMenuItem.Text = "Search ";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
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
            // backToolStripMenuItem1
            // 
            this.backToolStripMenuItem1.Name = "backToolStripMenuItem1";
            this.backToolStripMenuItem1.Size = new System.Drawing.Size(48, 21);
            this.backToolStripMenuItem1.Text = "Back";
            this.backToolStripMenuItem1.Click += new System.EventHandler(this.backToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 69);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "STUDENT MANAGMENT SYSTEM";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Red;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(990, 72);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(83, 25);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.signOutToolStripMenuItem.Text = "Sign_Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click_1);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(878, 72);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(72, 18);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RESULTUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.results;
            this.ClientSize = new System.Drawing.Size(1080, 516);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.allresultgroupbox);
            this.Controls.Add(this.actiongroupBox);
            this.Controls.Add(this.resultinfogroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RESULTUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.Load += new System.EventHandler(this.RESULTUI_Load);
            this.actiongroupBox.ResumeLayout(false);
            this.resultinfogroupBox.ResumeLayout(false);
            this.resultinfogroupBox.PerformLayout();
            this.allresultgroupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultdataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox actiongroupBox;
        private System.Windows.Forms.Button clearresultbutton;
        private System.Windows.Forms.Button deleteresultbutton;
        private System.Windows.Forms.Button updateresultbutton;
        private System.Windows.Forms.Button saveresultbutton;
        private System.Windows.Forms.Label courscodelabel;
        private System.Windows.Forms.Label greadlabel;
        private System.Windows.Forms.Label coursetitlelabel;
        private System.Windows.Forms.Label sgpalabel;
        private System.Windows.Forms.Label depertmentlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox sidtextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox depertmenttextBox;
        private System.Windows.Forms.TextBox coursetitletextBox;
        private System.Windows.Forms.TextBox coursecodetextBox;
        private System.Windows.Forms.TextBox sgpatextBox;
        private System.Windows.Forms.Label sidlabel;
        private System.Windows.Forms.ComboBox greadcomboBox;
        private System.Windows.Forms.GroupBox resultinfogroupBox;
        private System.Windows.Forms.GroupBox allresultgroupbox;
        private System.Windows.Forms.DataGridView ResultdataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchStudentInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchTeacherInfoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem searchAccoInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchResultInfoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Timer timer1;
    }
}