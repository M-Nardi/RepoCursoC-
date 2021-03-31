using System;
using System.Linq;
using System.Collections.Generic;
using ExercicioResolvido.Entities;
using System.IO;
using System.Globalization;

namespace ExercicioResolvido
{
    class Program
    {

        static void Print<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
        }

        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();
            
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.WriteLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(",");
                        string productName = line[0];
                        double productPrice = double.Parse(line[1], CultureInfo.InvariantCulture);

                        products.Add(new Product(productName, productPrice));
                    }

                    var averagePrice =
                        (from p in products
                         select p.Price).DefaultIfEmpty(0.0).Average();

                    Console.WriteLine("Average price: " + averagePrice.ToString("F2",CultureInfo.CurrentCulture));

                    Console.WriteLine("Products that have prices under average:");

                    var underAveragePrice = products.Where(p => p.Price <= averagePrice).OrderByDescending(p => p.Name).Select(p => p.Name);
        
                    Print(underAveragePrice);



                }


            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
