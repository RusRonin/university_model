using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib
{
    public class Faculty
    {
        public University University { get; set; }
        public List<Cathedra> Cathedras { get; private set; } = new List<Cathedra>();

        public void AddCathedra(Cathedra cathedra)
        {
            cathedra.Faculty = this;
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
