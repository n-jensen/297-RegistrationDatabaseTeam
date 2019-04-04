using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
               RegistrationEntities.Course.Load();
               coursesListBox.DataSource = RegistrationEntities.Course.Local.ToBindingList();
               coursesListBox.DisplayMember = nameof(Course.CoursesInfo);

          }



          private void CoursesList(object sender, EventArgs e)
          {

          }

          private void addCourseButton_Click(object sender, EventArgs e)
          {

               if (CoursesTextBox.Text != null)
               {

                    Courses newCourses = new Courses()
                    {
                         Name = CoursesTextBox.Text,
                         Number = courseNumberTextBox.Text,
                         Credits = Convert.ToInt32(CreditsTextBox.Text),
                         Department = DepartmentTextBox.Text

                    };
                    RegistrationEntities.Course.Add(newCourses);
                    RegistrationEntities.SaveChanges();
               }
               //updateMajorList();
          }

          private void updateCoursesList()
          {
               foreach (var courses in RegistrationEntities.Course)
               {
                    coursesListBox.Text += $"{courses.Name} {courses.Number} {courses.Credits} {courses.Department}";
               }
          }

          private void CoursesTextBox_TextChanged(object sender, EventArgs e)
          {

          }

          private void courseNumber(object sender, EventArgs e)
          {

          }

          private void CourseForm_Load(object sender, EventArgs e)
          {

          }

          private void CreditsTextBox_TextChanged(object sender, EventArgs e)
          {

          }

          private void DeleteCourseButton_Click(object sender, EventArgs e)
          {
               var selectedCourses = coursesListBox.SelectedItem as Major;
               if (selectedCourses != null)
               {
                    if (coursesListBox == null)
                    {
                         MessageBox.Show("You can't delete a course that has not been entered!");
                    }
                    else
                    {
                         RegistrationEntities.Majors.Remove(selectedCourses);
                         RegistrationEntities.SaveChanges();
                    }
               }
          }
     }
}