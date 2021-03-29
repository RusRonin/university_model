using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityModel
{
    class Faculty
    {
        public University University { get; private set; }
        public List<Cathedra> Cathedras { get; private set; }

        public void AddCathedra(Cathedra cathedra)
        {
            Cathedras.Add(cathedra);
        }

        public void RemoveCathedra(Cathedra cathedra)
        {
            if (Cathedras.Contains(cathedra))
            {
                Cathedras.Remove(cathedra);
            }
        }

        public void AddStudent(Student student)
        {
            University.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (University.Students.Contains(student))
            {
                University.Students.Remove(student);
            }
        }
    }
}
