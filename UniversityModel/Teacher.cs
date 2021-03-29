using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModel
{
    class Teacher
    {
        public string TeacherId { get; set; }

        public Cathedra Cathedra { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        
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
