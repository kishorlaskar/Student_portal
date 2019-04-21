namespace WindowsFormsApplication1
{
    partial class Search_Teacher_Info
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.courseadvisorcomboBox = new System.Windows.Forms.ComboBox();
            this.adresstextBox = new System.Windows.Forms.TextBox();
            this.salarytextBox = new System.Windows.Forms.TextBox();
            this.councellinghourtextBox = new System.Windows.Forms.TextBox();
            this.contactnotextBox = new System.Windows.Forms.TextBox();
            this.depertmenttextBox = new System.Windows.Forms.TextBox();
            this.desegnationtextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.teachersearchinfodataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTeacherInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAccoInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchResultInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersearchinfodataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.courseadvisorcomboBox);
            this.groupBox1.Controls.Add(this.adresstextBox);
            this.groupBox1.Controls.Add(this.salarytextBox);
            this.groupBox1.Controls.Add(this.councellinghourtextBox);
            this.groupBox1.Controls.Add(this.contactnotextBox);
            this.groupBox1.Controls.Add(this.depertmenttextBox);
            this.groupBox1.Controls.Add(this.desegnationtextBox);
            this.groupBox1.Controls.Add(this.nametextBox);
            this.groupBox1.Controls.Add(this.idtextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT_HERE";
            // 
            // courseadvisorcomboBox
            // 
            this.courseadvisorcomboBox.FormattingEnabled = true;
            this.courseadvisorcomboBox.Items.AddRange(new object[] {
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
            this.courseadvisorcomboBox.Location = new System.Drawing.Point(179, 181);
            this.courseadvisorcomboBox.Name = "courseadvisorcomboBox";
            this.courseadvisorcomboBox.Size = new System.Drawing.Size(100, 21);
            this.courseadvisorcomboBox.TabIndex = 5;
            this.courseadvisorcomboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.courseadvisorcomboBox_KeyDown);
            // 
            // adresstextBox
            // 
            this.adresstextBox.Location = new System.Drawing.Point(179, 292);
            this.adresstextBox.Name = "adresstextBox";
            this.adresstextBox.Size = new System.Drawing.Size(100, 20);
            this.adresstextBox.TabIndex = 2;
            this.adresstextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adresstextBox_KeyDown);
            // 
            // salarytextBox
            // 
            this.salarytextBox.Location = new System.Drawing.Point(179, 253);
            this.salarytextBox.Name = "salarytextBox";
            this.salarytextBox.Size = new System.Drawing.Size(100, 20);
            this.salarytextBox.TabIndex = 2;
            this.salarytextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.salarytextBox_KeyDown);
            // 
            // councellinghourtextBox
            // 
            this.councellinghourtextBox.Location = new System.Drawing.Point(179, 217);
            this.councellinghourtextBox.Name = "councellinghourtextBox";
            this.councellinghourtextBox.Size = new System.Drawing.Size(100, 20);
            this.councellinghourtextBox.TabIndex = 2;
            this.councellinghourtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.councellinghourtextBox_KeyDown);
            // 
            // contactnotextBox
            // 
            this.contactnotextBox.Location = new System.Drawing.Point(179, 149);
            this.contactnotextBox.Name = "contactnotextBox";
            this.contactnotextBox.Size = new System.Drawing.Size(100, 20);
            this.contactnotextBox.TabIndex = 2;
            this.contactnotextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contactnotextBox_KeyDown);
            // 
            // depertmenttextBox
            // 
            this.depertmenttextBox.Location = new System.Drawing.Point(179, 121);
            this.depertmenttextBox.Name = "depertmenttextBox";
            this.depertmenttextBox.Size = new System.Drawing.Size(100, 20);
            this.depertmenttextBox.TabIndex = 2;
            this.depertmenttextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.depertmenttextBox_KeyDown);
            // 
            // desegnationtextBox
            // 
            this.desegnationtextBox.Location = new System.Drawing.Point(179, 90);
            this.desegnationtextBox.Name = "desegnationtextBox";
            this.desegnationtextBox.Size = new System.Drawing.Size(100, 20);
            this.desegnationtextBox.TabIndex = 2;
            this.desegnationtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.desegnationtextBox_KeyDown);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(179, 54);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 20);
            this.nametextBox.TabIndex = 2;
            this.nametextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nametextBox_KeyDown);
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(179, 19);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(100, 20);
            this.idtextBox.TabIndex = 2;
            this.idtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idtextBox_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "ADRESS:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "SALARY:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "COUNCELLING_HOUR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "COURSE_ADVISOR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "CONTACTNO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "DEPERTMENT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DESEGNATION:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.teachersearchinfodataGridView);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(492, 107);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(467, 337);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // teachersearchinfodataGridView
            // 
            this.teachersearchinfodataGridView.AllowUserToAddRows = false;
            this.teachersearchinfodataGridView.AllowUserToDeleteRows = false;
            this.teachersearchinfodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersearchinfodataGridView.Location = new System.Drawing.Point(3, 3);
            this.teachersearchinfodataGridView.Name = "teachersearchinfodataGridView";
            this.teachersearchinfodataGridView.ReadOnly = true;
            this.teachersearchinfodataGridView.Size = new System.Drawing.Size(464, 334);
            this.teachersearchinfodataGridView.TabIndex = 0;
            this.teachersearchinfodataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.teachersearchinfodataGridView_DataBindingComplete);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 59);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(128, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(789, 58);
            this.label10.TabIndex = 0;
            this.label10.Text = "STUDENT MANAGMENT SYSTEM";
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.Blue;
            this.searchbutton.Location = new System.Drawing.Point(319, 479);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(108, 43);
            this.searchbutton.TabIndex = 4;
            this.searchbutton.Text = "SEARCH";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            this.searchbutton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchbutton_KeyDown);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.Blue;
            this.clearbutton.Location = new System.Drawing.Point(477, 479);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(105, 40);
            this.clearbutton.TabIndex = 4;
            this.clearbutton.Text = "CLEAR";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            this.clearbutton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clearbutton_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Blue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem1,
            this.courseToolStripMenuItem1,
            this.teacherToolStripMenuItem1,
            this.accountToolStripMenuItem1,
            this.resultToolStripMenuItem1,
            this.searchToolStripMenuItem1,
            this.reportToolStripMenuItem,
            this.backToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(12, 62);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem1
            // 
            this.studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            this.studentToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.studentToolStripMenuItem1.Text = "Student";
            this.studentToolStripMenuItem1.Click += new System.EventHandler(this.studentToolStripMenuItem1_Click);
            // 
            // courseToolStripMenuItem1
            // 
            this.courseToolStripMenuItem1.Name = "courseToolStripMenuItem1";
            this.courseToolStripMenuItem1.Size = new System.Drawing.Size(62, 21);
            this.courseToolStripMenuItem1.Text = "Course";
            this.courseToolStripMenuItem1.Click += new System.EventHandler(this.courseToolStripMenuItem1_Click);
            // 
            // teacherToolStripMenuItem1
            // 
            this.teacherToolStripMenuItem1.Name = "teacherToolStripMenuItem1";
            this.teacherToolStripMenuItem1.Size = new System.Drawing.Size(67, 21);
            this.teacherToolStripMenuItem1.Text = "Teacher";
            this.teacherToolStripMenuItem1.Click += new System.EventHandler(this.teacherToolStripMenuItem1_Click);
            // 
            // accountToolStripMenuItem1
            // 
            this.accountToolStripMenuItem1.Name = "accountToolStripMenuItem1";
            this.accountToolStripMenuItem1.Size = new System.Drawing.Size(70, 21);
            this.accountToolStripMenuItem1.Text = "Account";
            this.accountToolStripMenuItem1.Click += new System.EventHandler(this.accountToolStripMenuItem1_Click);
            // 
            // resultToolStripMenuItem1
            // 
            this.resultToolStripMenuItem1.Name = "resultToolStripMenuItem1";
            this.resultToolStripMenuItem1.Size = new System.Drawing.Size(58, 21);
            this.resultToolStripMenuItem1.Text = "Result";
            this.resultToolStripMenuItem1.Click += new System.EventHandler(this.resultToolStripMenuItem1_Click);
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchStudentInfoToolStripMenuItem1,
            this.searchTeacherInfoToolStripMenuItem1,
            this.searchAccoInfoToolStripMenuItem,
            this.searchResultInfoToolStripMenuItem});
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(60, 21);
            this.searchToolStripMenuItem1.Text = "Search";
            // 
            // searchStudentInfoToolStripMenuItem1
            // 
            this.searchStudentInfoToolStripMenuItem1.Name = "searchStudentInfoToolStripMenuItem1";
            this.searchStudentInfoToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.searchStudentInfoToolStripMenuItem1.Text = "Search Student Info";
            this.searchStudentInfoToolStripMenuItem1.Click += new System.EventHandler(this.searchStudentInfoToolStripMenuItem1_Click);
            // 
            // searchTeacherInfoToolStripMenuItem1
            // 
            this.searchTeacherInfoToolStripMenuItem1.Name = "searchTeacherInfoToolStripMenuItem1";
            this.searchTeacherInfoToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.searchTeacherInfoToolStripMenuItem1.Text = "Search Teacher Info";
            this.searchTeacherInfoToolStripMenuItem1.Click += new System.EventHandler(this.searchTeacherInfoToolStripMenuItem1_Click);
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
            // backToolStripMenuItem2
            // 
            this.backToolStripMenuItem2.Name = "backToolStripMenuItem2";
            this.backToolStripMenuItem2.Size = new System.Drawing.Size(48, 21);
            this.backToolStripMenuItem2.Text = "Back";
            this.backToolStripMenuItem2.Click += new System.EventHandler(this.backToolStripMenuItem2_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Red;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(887, 62);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(83, 25);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.signOutToolStripMenuItem.Text = "Sign_Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(780, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Search_Teacher_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 531);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Search_Teacher_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Teacher_Info";
            this.Load += new System.EventHandler(this.Search_Teacher_Info_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teachersearchinfodataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adresstextBox;
        private System.Windows.Forms.TextBox salarytextBox;
        private System.Windows.Forms.TextBox councellinghourtextBox;
        private System.Windows.Forms.TextBox contactnotextBox;
        private System.Windows.Forms.TextBox depertmenttextBox;
        private System.Windows.Forms.TextBox desegnationtextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.DataGridView teachersearchinfodataGridView;
        private System.Windows.Forms.ComboBox courseadvisorcomboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchStudentInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchTeacherInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem searchAccoInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchResultInfoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
    }
}