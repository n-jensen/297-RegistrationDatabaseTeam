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
     public partial class EnrollmentForm : Form
     {
          RegistrationEntities RegistrationEntities;
          public EnrollmentForm()
          {
               InitializeComponent();
               RegistrationEntities = new RegistrationEntities();
               RegistrationEntities.Enrollments.Load();
               EnrollListBox.DataSource = RegistrationEntities.Enrollments.Local.ToBindingList();
               EnrollListBox.DisplayMember = nameof(Enrollment.EnrollmentInfo);
          }

         
          //Add 
          private void AddStudentIDButton_Click(object sender, EventArgs e)
          {
               if ((EnrollStudentIDTextBox.Text != null) && (EnrollSectionIDTextBox.Text != null) && (EnrollGradeTextBox.Text != null))
               {
                    Enrollment newEnrollment = new Enrollment
                    {
                         //FIXME: Convert to int somehow
                         StudentID = Convert.ToInt16(EnrollStudentIDTextBox.Text),
                         SectionID = Convert.ToInt16(EnrollSectionIDTextBox.Text),
                         Grade = EnrollGradeTextBox.Text
                    };
                    RegistrationEntities.Enrollments.Add(newEnrollment);
                    RegistrationEntities.SaveChanges();
               }
               updateEnrollmentList(); 
          }

          //delete
          private void DeleteEnrolledStudent()
          {
               var selectedEnrolledStudent = EnrollListBox.SelectedItem as Enrollment;
               if (selectedEnrolledStudent != null)
               {
                    RegistrationEntities.Enrollments.Remove(selectedEnrolledStudent);
                    RegistrationEntities.SaveChanges();
               }
          }

          //update
          private void updateEnrollmentList()
          {
               foreach (var enroll in RegistrationEntities.Enrollments)
               {
                    EnrollListBox.Text += $"{enroll.StudentID} {enroll.SectionID} {enroll.Grade}";
               }
          }


          private void AddSectionIDButton_Click(object sender, EventArgs e)
          {

          }
          private void AddGradeButton_Click(object sender, EventArgs e)
          {

          }
          private void EnrollListBox_SelectedIndexChanged(object sender, EventArgs e)
          {

          }
     }
}
