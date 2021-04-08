using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib
{
    public class Course
    {
        public int CourseId { get; private set; }

        public Cathedra Cathedra { get; set; }
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public List<Student> Students { get; set; } = new List<Student>();

        public Course(int id)
        {
            CourseId = id;
        }
    }
}
