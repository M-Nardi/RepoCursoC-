using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ExIcomparable.Entities
{
    class Employee : IComparable
    {



        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vet = csvEmployee.Split(',');
            Name = vet[0];
            Salary = Double.Parse(vet[1]);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Objeto nao é funcionario");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2");
        }
    }
}
