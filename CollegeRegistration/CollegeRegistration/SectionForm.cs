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
     public partial class SectionForm : Form
     {
          RegistrationEntities RegistrationEntities;
          public SectionForm()
          {
               InitializeComponent();
               RegistrationEntities.Sections.Load();
               sectionListBox.DataSource = RegistrationEntities.Sections.Local.ToBindingList();
               sectionListBox.DisplayMember = nameof(Section.SectionInfo);
          }



          private void sectionTextBox_TextChanged(object sender, EventArgs e)
          {

          }

          private void SectionForm_Load(object sender, EventArgs e)
          {

          }
     }
}
