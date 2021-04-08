using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib
{
    public class Cathedra
    {
        public Faculty Faculty { get; set; }
        public List<Teacher> Teachers { get; private set; } = new List<Teacher>();
        public List<Course> Courses { get; private set; } = new List<Course>();
 
        public void AddTeacher(Teacher teacher)
        {
            teacher.Cathedra = this;
            Teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (Teachers.Contains(teacher))
            {
                Teachers.Remove(teacher);
            }
        }

        public void AddCourse(Course course)
        {
            course.Cathedra = this;
            Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (Courses.Contains(course))
            {
                Courses.Remove(course);
            }
        }

        public bool CheckCourseExistance(Course course)
        {
            return Courses.Contains(course);
        }

        public bool CheckTeacherExistance(Teacher teacher)
        {
            return Teachers.Contains(teacher);
        }
    }
}
