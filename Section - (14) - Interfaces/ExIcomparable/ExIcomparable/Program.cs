using System;
using System.IO;
using System.Collections.Generic;
using ExIcomparable.Entities;


namespace ExIcomparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Udemy\C#\Section - (14) - Interfaces\ExIcomparable\names.csv";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    List<Employee> list = new List<Employee>();

                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }

                }

            }

            catch (IOException e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);

            }


        }
    }
}
