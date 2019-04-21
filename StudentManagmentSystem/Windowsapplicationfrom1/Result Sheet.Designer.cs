namespace WindowsFormsApplication1
{
    partial class Result_Sheet
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.resultbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 42);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(830, 339);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // resultbutton
            // 
            this.resultbutton.Location = new System.Drawing.Point(12, 13);
            this.resultbutton.Name = "resultbutton";
            this.resultbutton.Size = new System.Drawing.Size(75, 23);
            this.resultbutton.TabIndex = 1;
            this.resultbutton.Text = "Click Here";
            this.resultbutton.UseVisualStyleBackColor = true;
            this.resultbutton.Click += new System.EventHandler(this.resultbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(93, 15);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(100, 20);
            this.idtextBox.TabIndex = 3;
            // 
            // Result_Sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 418);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultbutton);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Result_Sheet";
            this.Text = "Result_Sheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button resultbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idtextBox;
    }
}