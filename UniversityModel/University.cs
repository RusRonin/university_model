using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModel
{

    class University
    {
        public List<Faculty> Faculties { get; private set; }
        public List<Student> Students { get; private set; }

        public void AddFaculty(Faculty facultyToAdd)
        {
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
