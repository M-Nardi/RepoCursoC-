using System;
using System.Collections.Generic;
using ExercicioMetodosAbstratos.Entities;
using ExercicioMetodosAbstratos.Entities.Enums;

namespace ExercicioMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int amountShape = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int shapesCount = 1;
            while (shapesCount <= amountShape)
            {

                Console.WriteLine("Shape #" + shapesCount + " data:");

                Console.Write("Rectangle or Circle (r/c)? : ");
                string shapeType = Console.ReadLine();

                Console.Write("Color (Black/Blue/Red)? : ");
                Color shapeColor = Enum.Parse<Color>(Console.ReadLine());

                if (shapeType == "r")
                {
                    Console.Write("Insert Width: ");
                    double shapeWidth = double.Parse(Console.ReadLine());

                    Console.Write("Insert Height: ");
                    double shapeHeight = double.Parse(Console.ReadLine());

                    list.Add(new Rectangle(shapeWidth, shapeHeight, shapeColor));

                }

                if (shapeType == "c")
                {
                    Console.Write("Insert Radius: ");
                    double shapeRadius = double.Parse(Console.ReadLine());

                    list.Add(new Circle(shapeRadius,shapeColor));

                }

                shapesCount++;
                Console.WriteLine();
            }


            Console.WriteLine("SHAPE AREAS:");

            foreach (Shape shapes in list)
            {
                Console.WriteLine(shapes.Area().ToString("F2"));
            }


        }
    }
}
