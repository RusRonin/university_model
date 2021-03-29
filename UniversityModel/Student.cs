using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModel
{
    class Student
    {
        public string StudentId { get; set; }

        public Cathedra Cathedra { get; set; }
        public List<Course> Courses { get; set; }
        public List<Teacher> Teachers { get; set; }

        public void AddCourse(Course course)
        {
            if (Cathedra.CheckCourseExistance(course))
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
            if (Cathedra.CheckTeacherExistance(teacher))
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
