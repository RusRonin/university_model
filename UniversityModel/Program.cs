using System;
using UniversityLib;

namespace UniversityModel
{
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University();

            Faculty faculty = new Faculty();
            university.AddFaculty(faculty);

            Cathedra cathedra = new Cathedra();
            faculty.AddCathedra(cathedra);
            
            Teacher teacher1 = new Teacher(1);
            cathedra.AddTeacher(teacher1);
            Teacher teacher2 = new Teacher(2);
            cathedra.AddTeacher(teacher2);
            
            Course course1 = new Course(1);
            cathedra.AddCourse(course1);
            Course course2 = new Course(2);
            cathedra.AddCourse(course2);

            Student student1 = new Student(1);
            faculty.AddStudent(student1);
            Student student2 = new Student(2);
            faculty.AddStudent(student2);

            teacher1.AddCourse(course1);
            teacher2.AddCourse(course1);
            teacher2.AddCourse(course2);
            Console.WriteLine("teacher1's courses: ");
            foreach (Course course in teacher1.Courses)
            {
                Console.WriteLine(course.CourseId);
            }
            Console.WriteLine("teacher2's courses: ");
            foreach (Course course in teacher2.Courses)
            {
                Console.WriteLine(course.CourseId);
            }
            Console.WriteLine("course1's teachers: ");
            foreach (Teacher teacher in course1.Teachers)
            {
                Console.WriteLine(teacher.TeacherId);
            }
            Console.WriteLine("course2's teachers: ");
            foreach (Teacher teacher in course2.Teachers)
            {
                Console.WriteLine(teacher.TeacherId);
            }

            student1.AddCourse(course1);
            student1.AddTeacher(teacher1);
            student2.AddCourse(course1);
            student2.AddTeacher(teacher2);
            Console.WriteLine("course1's students: ");
            foreach (Student student in course1.Students)
            {
                Console.WriteLine(student.StudentId);
            }
            Console.WriteLine("course2's students: ");
            foreach (Student student in course2.Students)
            {
                Console.WriteLine(student.StudentId);
            }
            Console.WriteLine("teacher1's students: ");
            foreach (Student student in teacher1.Students)
            {
                Console.WriteLine(student.StudentId);
            }
            Console.WriteLine("teacher2's students: ");
            foreach (Student student in teacher2.Students)
            {
                Console.WriteLine(student.StudentId);
            }
        }
    }
}
