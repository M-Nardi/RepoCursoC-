using System;
using HerdarContratos.Model.Entities;
using HerdarContratos.Model.Enums;

namespace HerdarContratos
{
    class Program
    {
        static void Main(string[] args)
        {

            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };

            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.White };

            IShape s3 = new Rectangle() { Width = 3.5, Height = 4.2};

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
