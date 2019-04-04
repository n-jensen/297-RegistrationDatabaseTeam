namespace CollegeRegistration
{
    partial class StudentForm
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
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.addStudentButton = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.studentsList = new System.Windows.Forms.ListBox();
               this.majorsListBox = new System.Windows.Forms.ListBox();
               this.label2 = new System.Windows.Forms.Label();
               this.button1 = new System.Windows.Forms.Button();
               this.majorNameTextBox = new System.Windows.Forms.TextBox();
               this.ericsClassesLabel = new System.Windows.Forms.Label();
               this.button2 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.DeleteStudentButton = new System.Windows.Forms.Button();
               this.OpenMajorFormButton = new System.Windows.Forms.Button();
               this.OpenCourseFormButton = new System.Windows.Forms.Button();
               this.OpenFacultyFormButton = new System.Windows.Forms.Button();
               this.OpenEnrollmentFormButton = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(101, 54);
               this.textBox1.Margin = new System.Windows.Forms.Padding(2);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(140, 20);
               this.textBox1.TabIndex = 0;
               this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
               // 
               // addStudentButton
               // 
               this.addStudentButton.Location = new System.Drawing.Point(42, 105);
               this.addStudentButton.Margin = new System.Windows.Forms.Padding(2);
               this.addStudentButton.Name = "addStudentButton";
               this.addStudentButton.Size = new System.Drawing.Size(102, 42);
               this.addStudentButton.TabIndex = 1;
               this.addStudentButton.Text = "Add Student";
               this.addStudentButton.UseVisualStyleBackColor = true;
               this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(22, 57);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(75, 13);
               this.label1.TabIndex = 2;
               this.label1.Text = "Student Name";
               // 
               // studentsList
               // 
               this.studentsList.FormattingEnabled = true;
               this.studentsList.Location = new System.Drawing.Point(25, 172);
               this.studentsList.Margin = new System.Windows.Forms.Padding(2);
               this.studentsList.Name = "studentsList";
               this.studentsList.Size = new System.Drawing.Size(251, 173);
               this.studentsList.TabIndex = 3;
               this.studentsList.SelectedIndexChanged += new System.EventHandler(this.studentsList_SelectedIndexChanged);
               // 
               // majorsListBox
               // 
               this.majorsListBox.FormattingEnabled = true;
               this.majorsListBox.Location = new System.Drawing.Point(336, 172);
               this.majorsListBox.Margin = new System.Windows.Forms.Padding(2);
               this.majorsListBox.Name = "majorsListBox";
               this.majorsListBox.Size = new System.Drawing.Size(251, 173);
               this.majorsListBox.TabIndex = 7;
               this.majorsListBox.SelectedIndexChanged += new System.EventHandler(this.majorsListBox_SelectedIndexChanged);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(333, 59);
               this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(64, 13);
               this.label2.TabIndex = 6;
               this.label2.Text = "Major Name";
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(359, 110);
               this.button1.Margin = new System.Windows.Forms.Padding(2);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(95, 37);
               this.button1.TabIndex = 5;
               this.button1.Text = "Add Major";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // majorNameTextBox
               // 
               this.majorNameTextBox.Location = new System.Drawing.Point(405, 57);
               this.majorNameTextBox.Margin = new System.Windows.Forms.Padding(2);
               this.majorNameTextBox.Name = "majorNameTextBox";
               this.majorNameTextBox.Size = new System.Drawing.Size(140, 20);
               this.majorNameTextBox.TabIndex = 4;
               // 
               // ericsClassesLabel
               // 
               this.ericsClassesLabel.AutoSize = true;
               this.ericsClassesLabel.Location = new System.Drawing.Point(23, 374);
               this.ericsClassesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.ericsClassesLabel.Name = "ericsClassesLabel";
               this.ericsClassesLabel.Size = new System.Drawing.Size(74, 13);
               this.ericsClassesLabel.TabIndex = 8;
               this.ericsClassesLabel.Text = "Eric\'s Classes:";
               // 
               // button2
               // 
               this.button2.Location = new System.Drawing.Point(672, 234);
               this.button2.Margin = new System.Windows.Forms.Padding(2);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(110, 43);
               this.button2.TabIndex = 9;
               this.button2.Text = "Sections";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button3
               // 
               this.button3.Location = new System.Drawing.Point(458, 110);
               this.button3.Margin = new System.Windows.Forms.Padding(2);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(99, 37);
               this.button3.TabIndex = 10;
               this.button3.Text = "Delete Major";
               this.button3.UseVisualStyleBackColor = true;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // DeleteStudentButton
               // 
               this.DeleteStudentButton.Location = new System.Drawing.Point(149, 105);
               this.DeleteStudentButton.Name = "DeleteStudentButton";
               this.DeleteStudentButton.Size = new System.Drawing.Size(109, 42);
               this.DeleteStudentButton.TabIndex = 11;
               this.DeleteStudentButton.Text = "Delete Student";
               this.DeleteStudentButton.UseVisualStyleBackColor = true;
               // 
               // OpenMajorFormButton
               // 
               this.OpenMajorFormButton.Location = new System.Drawing.Point(672, 170);
               this.OpenMajorFormButton.Margin = new System.Windows.Forms.Padding(2);
               this.OpenMajorFormButton.Name = "OpenMajorFormButton";
               this.OpenMajorFormButton.Size = new System.Drawing.Size(110, 43);
               this.OpenMajorFormButton.TabIndex = 12;
               this.OpenMajorFormButton.Text = "Major";
               this.OpenMajorFormButton.UseVisualStyleBackColor = true;
               this.OpenMajorFormButton.Click += new System.EventHandler(this.OpenMajorFormButton_Click);
               // 
               // OpenCourseFormButton
               // 
               this.OpenCourseFormButton.Location = new System.Drawing.Point(672, 106);
               this.OpenCourseFormButton.Margin = new System.Windows.Forms.Padding(2);
               this.OpenCourseFormButton.Name = "OpenCourseFormButton";
               this.OpenCourseFormButton.Size = new System.Drawing.Size(110, 43);
               this.OpenCourseFormButton.TabIndex = 13;
               this.OpenCourseFormButton.Text = "Course";
               this.OpenCourseFormButton.UseVisualStyleBackColor = true;
               this.OpenCourseFormButton.Click += new System.EventHandler(this.OpenCourseFormButton_Click);
               // 
               // OpenFacultyFormButton
               // 
               this.OpenFacultyFormButton.Location = new System.Drawing.Point(672, 42);
               this.OpenFacultyFormButton.Margin = new System.Windows.Forms.Padding(2);
               this.OpenFacultyFormButton.Name = "OpenFacultyFormButton";
               this.OpenFacultyFormButton.Size = new System.Drawing.Size(110, 43);
               this.OpenFacultyFormButton.TabIndex = 14;
               this.OpenFacultyFormButton.Text = "Faculty";
               this.OpenFacultyFormButton.UseVisualStyleBackColor = true;
               this.OpenFacultyFormButton.Click += new System.EventHandler(this.OpenFacultyFormButton_Click);
               // 
               // OpenEnrollmentFormButton
               // 
               this.OpenEnrollmentFormButton.Location = new System.Drawing.Point(672, 299);
               this.OpenEnrollmentFormButton.Margin = new System.Windows.Forms.Padding(2);
               this.OpenEnrollmentFormButton.Name = "OpenEnrollmentFormButton";
               this.OpenEnrollmentFormButton.Size = new System.Drawing.Size(110, 43);
               this.OpenEnrollmentFormButton.TabIndex = 15;
               this.OpenEnrollmentFormButton.Text = "Enrollment";
               this.OpenEnrollmentFormButton.UseVisualStyleBackColor = true;
               this.OpenEnrollmentFormButton.Click += new System.EventHandler(this.OpenEnrollmentFormButton_Click);
               // 
               // StudentForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(986, 525);
               this.Controls.Add(this.OpenEnrollmentFormButton);
               this.Controls.Add(this.OpenFacultyFormButton);
               this.Controls.Add(this.OpenCourseFormButton);
               this.Controls.Add(this.OpenMajorFormButton);
               this.Controls.Add(this.DeleteStudentButton);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.ericsClassesLabel);
               this.Controls.Add(this.majorsListBox);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.majorNameTextBox);
               this.Controls.Add(this.studentsList);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.addStudentButton);
               this.Controls.Add(this.textBox1);
               this.Margin = new System.Windows.Forms.Padding(2);
               this.Name = "StudentForm";
               this.Text = "Students";
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox studentsList;
        private System.Windows.Forms.ListBox majorsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox majorNameTextBox;
        private System.Windows.Forms.Label ericsClassesLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
          private System.Windows.Forms.Button DeleteStudentButton;
          private System.Windows.Forms.Button OpenMajorFormButton;
          private System.Windows.Forms.Button OpenCourseFormButton;
          private System.Windows.Forms.Button OpenFacultyFormButton;
          private System.Windows.Forms.Button OpenEnrollmentFormButton;
     }
}

