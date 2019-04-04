using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRegistration
{
    public partial class Student
    {
        public string BetterDisplay => $"{Name} {Major.Name} {Major.College}";
    }

    public partial class Major
    {
        public string NameAndCollege => $"{Name} {College}";
    }

    public partial class Faculty
     {
          public string FacultyInfo => $"{Name} {PhoneNumber}";
     }

     public partial class Enrollment
     {
          public string EnrollmentInfo => $"{StudentID} {SectionID} {Grade}";
     }

     public partial class Course
     {
          public string CoursesInfo => $"{Name} {Number} {Credits} {Department}";
     }

     public partial class Section
     {
          public string SectionInfo => $"{Faculty.Name} {Faculty.PhoneNumber} {Course.Name} {Course.Number} {Course.Credits} {Course.Department} {Day} {Time} {Semester}";
     }
}
