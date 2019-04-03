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
               FacultyList.DataSource = RegistrationEntities.Faculties.Local.ToBindingList();
               FacultyList.DisplayMember = nameof(Faculty.Name);
          }

          private void FacultyNameTextbox_TextChanged(object sender, EventArgs e)
          {

          }

          private void facultyNameAddButton_Click(object sender, EventArgs e)
          {

          }
     }
}
