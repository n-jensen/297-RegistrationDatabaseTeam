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
     public partial class FacultyForm : Form
     {
          RegistrationEntities RegistrationEntities;
          public FacultyForm()
          {
               InitializeComponent();
               RegistrationEntities = new RegistrationEntities();
               RegistrationEntities.Students.Load();
               FacultyNameListBox.DataSource = RegistrationEntities.Faculties.Local.ToBindingList();
               FacultyNameListBox.DisplayMember = nameof(Faculty.FacultyInfo);
          }


          //FIXME:Charnesky approved
          //Add (create) faculty (name and number)
          private void facultyNameAddButton_Click(object sender, EventArgs e)
          {
               if (FacultyPhoneNumberTextBox.Text != null)
               {
                    Faculty newFaculty = new Faculty
                    {
                         Name = FacultyNameTextbox.Text,
                         PhoneNumber = FacultyPhoneNumberTextBox.Text
                    };
                    RegistrationEntities.Faculties.Add(newFaculty);
                    RegistrationEntities.SaveChanges();
               }
               updateFacultyList(); //FIXME: add these to all deletes
          }
          
          //Deleted faculty
          private void DeleteFacultyButton_Click(object sender, EventArgs e)
          {
               var selectedFaculty = FacultyNameListBox.SelectedItem as Faculty;
               if (selectedFaculty != null)
               {
                    RegistrationEntities.Faculties.Remove(selectedFaculty);
                    RegistrationEntities.SaveChanges();
               }
          }

          //Update faculty
          private void updateFacultyList()
          {
               foreach (var faculty in RegistrationEntities.Faculties)
               {
                    FacultyNameListBox.Text += $"{faculty.Name} {faculty.PhoneNumber}";
               }
          }

          //Read Faculty is the listbox


          private void FacultyNameTextbox_TextChanged(object sender, EventArgs e)
          {

          }
          private void FacultyPhoneNumberTextBox_TextChanged(object sender, EventArgs e)
          {

          }
          private void FacultyNameListBox_SelectedIndexChanged(object sender, EventArgs e)
          {

          }
          private void FacultyPhoneNumberLabel_Click(object sender, EventArgs e)
          {

          }




         

          
     }
}
