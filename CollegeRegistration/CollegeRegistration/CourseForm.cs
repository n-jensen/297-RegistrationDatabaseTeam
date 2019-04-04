using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeRegistration
{
     public partial class CourseForm : Form
     {
          RegistrationEntities RegistrationEntities;
          public CourseForm()
          {
               InitializeComponent();
               RegistrationEntities = new RegistrationEntities();
               RegistrationEntities.Courses.Load();
               coursesListBox.DataSource = RegistrationEntities.Courses.Local.ToBindingList();
               coursesListBox.DisplayMember = nameof(Course.CoursesInfo);

          }

          private void addCourseButton_Click(object sender, EventArgs e)
          {
               if (coursesListBox.SelectedItem != null)
               {
                    Course newCourse = new Course
                    {
                         Name = CoursesTextBox.Text,
                        Number = courseNumberTextBox.Text,
                        Credits = Convert.ToInt32(CreditsTextBox), 
                        Department = DepartmentTextBox.Text
                    };
                    RegistrationEntities.Courses.Add(newCourse);
                    RegistrationEntities.SaveChanges();
               }
               updateCoursesList();
          }

          private void updateCoursesList()
          {
               foreach (var courses in RegistrationEntities.Courses)
               {
                    coursesListBox.Text += $"{courses.Name} {courses.Number} {courses.Credits} {courses.Department}";
               }
          }

          private void CourseForm_Load(object sender, EventArgs e)
          {

          }

          private void DeleteCourseButton_Click(object sender, EventArgs e)
          {
               var selectedCourse = coursesListBox.SelectedItem as Major;
               if (selectedCourse != null)
               {
                    if (selectedCourse.Name == null)
                    {
                         MessageBox.Show("You can't delete a course that has not been added");
                    }
                    else
                    {
                         RegistrationEntities.Majors.Remove(selectedCourse);
                         RegistrationEntities.SaveChanges();
                    }
               }
          }

          private void coursesListBox_SelectedIndexChanged(object sender, EventArgs e)
          {

          }

          private void CoursesTextBox_TextChanged(object sender, EventArgs e)
          {

          }
     }
}