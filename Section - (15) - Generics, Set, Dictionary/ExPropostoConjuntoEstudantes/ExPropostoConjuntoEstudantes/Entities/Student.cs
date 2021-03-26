using System;
using System.Collections.Generic;
using System.Text;

namespace ExPropostoConjuntoEstudantes.Entities
{
    class Student
    {

        public int Id { get; set; }

        public Student(int id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            Student other = obj as Student;
            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
