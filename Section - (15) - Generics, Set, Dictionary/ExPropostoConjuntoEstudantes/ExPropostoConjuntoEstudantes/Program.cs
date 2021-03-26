using System;
using System.IO;
using System.Collections.Generic;
using ExPropostoConjuntoEstudantes.Entities;

namespace ExPropostoConjuntoEstudantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alex instructor students: ");

            HashSet<Student> list = new HashSet<Student>();

            int classA = 0;
            int classB = 0;
            int classC = 0;

            Console.Write("How many students for course A? :" );
            int amountStudentsA = int.Parse(Console.ReadLine());

            while (classA < amountStudentsA)
            {
                Console.Write("Student ID: ");
                int idStudent = int.Parse(Console.ReadLine());
                list.Add(new Student(idStudent));
                classA++;
            }

            Console.Write("How many students for course B? :");
            int amountStudentsB = int.Parse(Console.ReadLine());
            while (classB < amountStudentsB)
            {
                Console.Write("Student ID: ");
                int idStudent = int.Parse(Console.ReadLine());
                list.Add(new Student(idStudent));
                classB++;
            }

            Console.Write("How many students for course C? :");
            int amountStudentsC = int.Parse(Console.ReadLine());
            while (classC < amountStudentsC)
            {
                Console.Write("Student ID: ");
                int idStudent = int.Parse(Console.ReadLine());
                list.Add(new Student(idStudent));
                classC++;
            }

            Console.WriteLine();
            Console.WriteLine("Amount of students: " + list.Count);


        }
    }
}
