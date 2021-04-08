using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib
{
    public class Teacher
    {
        public int TeacherId { get; private set; }

        public Cathedra Cathedra { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Course> Courses { get; set; } = new List<Course>();
        
        public Teacher(int id)
        {
            TeacherId = id;
        }

        public void AddCourse(Course course)
        {
            if (Cathedra.CheckCourseExistance(course))
            {
                course.Teachers.Add(this);
                Courses.Add(course);
            }
        }

        public void RemoveCourse(Course course)
        {
            if (Courses.Contains(course))
            {
                Courses.Remove(course);
            }
        }
    }
}
