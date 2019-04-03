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
    public partial class Form1 : Form
    {
          //https://github.com/EricCharnesky/CIS297-Winter2019/blob/master/CollegeRegistration/CollegeRegistration/Form1.cs
          RegistrationEntities RegistrationEntities;
        public Form1()
        {
            InitializeComponent();
            RegistrationEntities = new RegistrationEntities();
            RegistrationEntities.Students.Load();
            studentsList.DataSource = RegistrationEntities.Students.Local.ToBindingList();
            studentsList.DisplayMember = nameof(Student.BetterDisplay);
            RegistrationEntities.Majors.Load();
            majorsListBox.DataSource = RegistrationEntities.Majors.Local.ToBindingList();
            majorsListBox.DisplayMember = nameof(Major.NameAndCollege);
            

            //updateStudentsList();
            //updateMajorsList();

            var erics = RegistrationEntities.Students.Where(s => s.Name.StartsWith("E")).ToList();
            erics = erics.Where(s => s.Major.College == "CECS").ToList();
            foreach( var eric in erics )
            {
                ericsClassesLabel.Text += $"{eric.Name} - {eric.Major.Name} - {eric.Major.College}{Environment.NewLine}";
            }

            // linq to ojbects without lambda extensions syntax
            /*
            var query = from Student student in RegistrationEntities.Students
                        where student.Name == "Eric"
                        select student;

           foreach( var result in query )
            {
                result.
            }
            */

            //RegistrationEntities.Students.Remove()
        }

          //https://github.com/EricCharnesky/CIS297-Winter2019/blob/master/CollegeRegistration/CollegeRegistration/Form1.cs
          private void addStudentButton_Click(object sender, EventArgs e)
        {
            var selectedMajor = majorsListBox.SelectedItem as Major;
            if ( selectedMajor != null )
            {
                Student newStudent = new Student
                {
                    Name = textBox1.Text,
                    Major = selectedMajor
                };
                RegistrationEntities.Students.Add(newStudent);
                RegistrationEntities.SaveChanges();
            }
            
            //updateStudentsList();

        }

          //https://github.com/EricCharnesky/CIS297-Winter2019/blob/master/CollegeRegistration/CollegeRegistration/Form1.cs
          private void updateStudentsList()
        {
            foreach( var student in RegistrationEntities.Students )
            {
                studentsList.Text += $"{student.Name} {student.Major.Name} {student.Major.College}";
            }
            
        }

          //https://github.com/EricCharnesky/CIS297-Winter2019/blob/master/CollegeRegistration/CollegeRegistration/Form1.cs
          private void updateMajorsList()
        {
            foreach (var major in RegistrationEntities.Majors)
            {
                majorsListBox.Text += $"{major.Name}";
            }

        }
          //https://github.com/EricCharnesky/CIS297-Winter2019/blob/master/CollegeRegistration/CollegeRegistration/Form1.cs
          private void button1_Click(object sender, EventArgs e)
        {
            Major newMajor = new Major()
            {
                Name = majorNameTextBox.Text,
                College = "CECS"
            };
            RegistrationEntities.Majors.Add(newMajor);
            RegistrationEntities.SaveChanges();
            //updateMajorsList();
        }

          //https://github.com/EricCharnesky/CIS297-Winter2019/blob/master/CollegeRegistration/CollegeRegistration/Form1.cs
          private void button2_Click(object sender, EventArgs e)
        {
            var sectionsForm = new Sections();
            sectionsForm.Show();
        }

          //https://github.com/EricCharnesky/CIS297-Winter2019/blob/master/CollegeRegistration/CollegeRegistration/Form1.cs
          private void button3_Click(object sender, EventArgs e)
        {
            var selectedMajor = majorsListBox.SelectedItem as Major;
            if ( selectedMajor != null )
            {
                if ( selectedMajor.Students.Count > 0)
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

          private void textBox1_TextChanged(object sender, EventArgs e)
          {

          }
     }
}
