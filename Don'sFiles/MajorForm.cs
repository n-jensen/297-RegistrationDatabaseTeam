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
     public partial class MajorForm : Form
     {
          RegistrationEntities RegistrationEntities;
          public MajorForm()
          {
               InitializeComponent();
               RegistrationEntities = new RegistrationEntities();
               RegistrationEntities.Majors.Load();
               MajorNameListBox.DataSource = RegistrationEntities.Majors.Local.ToBindingList();
               MajorNameListBox.DisplayMember = nameof(Major.NameAndCollege);
               SetUpCollegeNames();
          }

          //Add major (name and college)
          private void MajorAddButton_Click(object sender, EventArgs e)
          {
               if (MajorCollegeTextBox.Text != null)
               {
                    Major newMajor = new Major
                    {
                         Name = MajorNameTextBox.Text,
                         College = MajorCollegeListBox.SelectedItem.ToString()
                    };
                    RegistrationEntities.Majors.Add(newMajor);
                    RegistrationEntities.SaveChanges();
               }
               //updateMajorList();
          }



          
          //Delete Major
          private void DeleteMajorButton_Click(object sender, EventArgs e)
          {
               var selectedMajor = MajorNameListBox.SelectedItem as Major;
               if (selectedMajor != null)
               {
                    if (selectedMajor.Students.Count > 0)
                    {
                         MessageBox.Show("You can't delete a major that has students!");
                    }
                    else
                    {
                         RegistrationEntities.Majors.Remove(selectedMajor);
                         RegistrationEntities.SaveChanges();
                    }
               }
          }

          private void updateMajorList()
          {
               foreach (var major in RegistrationEntities.Majors)
               {
                    MajorNameListBox.Text += $"{major.Name} {major.College}";
               }
          }



          
          private void MajorNameListBox_SelectedIndexChanged(object sender, EventArgs e)
          {

          }
          private void MajorCollegeListBox_SelectedIndexChanged(object sender, EventArgs e)
          {

          }

          private void SetUpCollegeNames()
          {
               MajorCollegeListBox.Text = "CECS";
               MajorCollegeListBox.Text += "CASL";
               MajorCollegeListBox.Text += "COB";
               MajorCollegeListBox.Text += "CEHHS";
          }
          
     }
}
