using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib
{
    public class Student
    {
        public int StudentId { get; private set; }

        public Cathedra Cathedra { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();

        public Student(int id)
        {
            StudentId = id;
        }

        public void AddCourse(Course course)
        {
            if ((course.Cathedra != null) && (course.Cathedra.CheckCourseExistance(course)))
            {
                course.Students.Add(this);
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

        public void AddTeacher(Teacher teacher)
        {
            if ((teacher.Cathedra != null) && (teacher.Cathedra.CheckTeacherExistance(teacher)))
            {
                teacher.Students.Add(this);
                Teachers.Add(teacher);
            }
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (Teachers.Contains(teacher))
            {
                Teachers.Remove(teacher);
            }
        }
    }
}
