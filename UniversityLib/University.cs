using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib
{

    public class University
    {
        public List<Faculty> Faculties { get; private set; } = new List<Faculty>();
        public List<Student> Students { get; private set; } = new List<Student>();

        public void AddFaculty(Faculty facultyToAdd)
        {
            facultyToAdd.University = this;
            Faculties.Add(facultyToAdd);
        }

        public void RemoveFaculty(Faculty facultyToRemove)
        {
            if (Faculties.Contains(facultyToRemove))
            {
                Faculties.Remove(facultyToRemove);
            }
        }
    }
}
