namespace CollegeRegistration
{
     partial class CourseForm
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
               this.DeleteCourseButton = new System.Windows.Forms.Button();
               this.DepartmentTextBox = new System.Windows.Forms.TextBox();
               this.CreditsTextBox = new System.Windows.Forms.TextBox();
               this.courseNumberTextBox = new System.Windows.Forms.TextBox();
               this.CoursesTextBox = new System.Windows.Forms.TextBox();
               this.addCourseButton = new System.Windows.Forms.Button();
               this.coursesListBox = new System.Windows.Forms.ListBox();
               this.SuspendLayout();
               // 
               // DeleteCourseButton
               // 
               this.DeleteCourseButton.Location = new System.Drawing.Point(156, 63);
               this.DeleteCourseButton.Name = "DeleteCourseButton";
               this.DeleteCourseButton.Size = new System.Drawing.Size(96, 34);
               this.DeleteCourseButton.TabIndex = 13;
               this.DeleteCourseButton.Text = "Delete Course";
               this.DeleteCourseButton.UseVisualStyleBackColor = true;
               // 
               // DepartmentTextBox
               // 
               this.DepartmentTextBox.Location = new System.Drawing.Point(494, 34);
               this.DepartmentTextBox.Name = "DepartmentTextBox";
               this.DepartmentTextBox.Size = new System.Drawing.Size(100, 20);
               this.DepartmentTextBox.TabIndex = 12;
               // 
               // CreditsTextBox
               // 
               this.CreditsTextBox.Location = new System.Drawing.Point(361, 34);
               this.CreditsTextBox.Name = "CreditsTextBox";
               this.CreditsTextBox.Size = new System.Drawing.Size(100, 20);
               this.CreditsTextBox.TabIndex = 11;
               // 
               // courseNumberTextBox
               // 
               this.courseNumberTextBox.Location = new System.Drawing.Point(233, 34);
               this.courseNumberTextBox.Name = "courseNumberTextBox";
               this.courseNumberTextBox.Size = new System.Drawing.Size(100, 20);
               this.courseNumberTextBox.TabIndex = 10;
               // 
               // CoursesTextBox
               // 
               this.CoursesTextBox.Location = new System.Drawing.Point(45, 34);
               this.CoursesTextBox.Name = "CoursesTextBox";
               this.CoursesTextBox.Size = new System.Drawing.Size(100, 20);
               this.CoursesTextBox.TabIndex = 9;
               this.CoursesTextBox.TextChanged += new System.EventHandler(this.CoursesTextBox_TextChanged);
               // 
               // addCourseButton
               // 
               this.addCourseButton.Location = new System.Drawing.Point(45, 63);
               this.addCourseButton.Name = "addCourseButton";
               this.addCourseButton.Size = new System.Drawing.Size(79, 34);
               this.addCourseButton.TabIndex = 8;
               this.addCourseButton.Text = "Add Course";
               this.addCourseButton.UseVisualStyleBackColor = true;
               // 
               // coursesListBox
               // 
               this.coursesListBox.FormattingEnabled = true;
               this.coursesListBox.Location = new System.Drawing.Point(45, 114);
               this.coursesListBox.Name = "coursesListBox";
               this.coursesListBox.Size = new System.Drawing.Size(179, 121);
               this.coursesListBox.TabIndex = 7;
               this.coursesListBox.SelectedIndexChanged += new System.EventHandler(this.coursesListBox_SelectedIndexChanged);
               // 
               // CourseForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.DeleteCourseButton);
               this.Controls.Add(this.DepartmentTextBox);
               this.Controls.Add(this.CreditsTextBox);
               this.Controls.Add(this.courseNumberTextBox);
               this.Controls.Add(this.CoursesTextBox);
               this.Controls.Add(this.addCourseButton);
               this.Controls.Add(this.coursesListBox);
               this.Name = "CourseForm";
               this.Text = "CourseForm";
               this.Load += new System.EventHandler(this.CourseForm_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button DeleteCourseButton;
          private System.Windows.Forms.TextBox DepartmentTextBox;
          private System.Windows.Forms.TextBox CreditsTextBox;
          private System.Windows.Forms.TextBox courseNumberTextBox;
          private System.Windows.Forms.TextBox CoursesTextBox;
          private System.Windows.Forms.Button addCourseButton;
          private System.Windows.Forms.ListBox coursesListBox;
     }
}