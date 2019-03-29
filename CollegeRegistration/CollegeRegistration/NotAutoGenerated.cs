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
}
